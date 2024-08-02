using System;
using System.Runtime.InteropServices;

namespace _06.VehicleCatalogue
{

    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal HorsePower { get; set; }

        public Vehicle(string vehicleType, string vehicleModel, string vehicleColor, decimal vehicleHorsePower)
        {
            Type = vehicleType;
            Model = vehicleModel;
            Color = vehicleColor;
            HorsePower = vehicleHorsePower;
        }



        public override string ToString()
        {
            if (Type == "car")
            {
                return $"Type: Car\n" +
                    $"Model: {Model}\n" +
                    $"Color: {Color}\n" +
                    $"Horsepower: {HorsePower}";
            }
            else
            {
                return $"Type: Truck\n" +
                    $"Model: {Model}\n" +
                    $"Color: {Color}\n" +
                    $"Horsepower: {HorsePower}";
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehiclesLIst = new List<Vehicle>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputVehicles = input.Split(" ").ToArray();

                string typeOfVehicle = inputVehicles[0];
                string modelOfVehicle = inputVehicles[1];
                string colorOfVehicle = inputVehicles[2];
                decimal horsePowerOfVehicle = decimal.Parse(inputVehicles[3]);

                Vehicle vehicleInstance = new Vehicle(typeOfVehicle, modelOfVehicle, colorOfVehicle, horsePowerOfVehicle);
                vehiclesLIst.Add(vehicleInstance);

            }

            input = string.Empty;

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(FindVehicle(vehiclesLIst, input).ToString());
            }



            decimal avgCarHorsepower = vehiclesLIst
                                        .Where(v => v.Type == "car")
                                        .Select(v => v.HorsePower)
                                        .DefaultIfEmpty()
                                        .Average();

            decimal avgTruckHorsePower = vehiclesLIst
                                        .Where(v => v.Type == "truck")
                                        .Select(v => v.HorsePower)
                                        .DefaultIfEmpty()
                                        .Average();

            Console.WriteLine($"Cars have average horsepower of: {avgCarHorsepower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHorsePower:F2}.");
        }


        public static Vehicle FindVehicle(List<Vehicle> vehicleList, string vehicleModel)
        {
            return vehicleList.Find(v => v.Model == vehicleModel);
        }
    }
}
