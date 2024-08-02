using System.Reflection;

namespace _07.VehicleCatalogue
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class CatalogueVehicle
    {
        public List<Car> Cars { get; }
        public List<Truck> Trucks { get; }

        public CatalogueVehicle()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            CatalogueVehicle vehicle = new CatalogueVehicle();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] vehicleData = input.Split("/", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string brand = vehicleData[1];
                string model = vehicleData[2];
                int horsePowerOrWeight = int.Parse(vehicleData[3]);

                if (vehicleData[0] == "Car")
                {
                    vehicle.Cars.Add(new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePowerOrWeight
                    });
                }
                else if (vehicleData[0] == "Truck")
                {
                    vehicle.Trucks.Add(new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = horsePowerOrWeight
                    });
                }
            }

            if(vehicle.Cars.Count > 0) 
            {
                Console.WriteLine("Cars:");
                foreach (Car car in vehicle.Cars.OrderBy(c => c.Brand)) 
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if(vehicle.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in vehicle.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
