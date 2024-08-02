namespace B03NeedForSpeedIII
{
    public class Cars
    {
        public string Name { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }

        public Cars(string name, int mileage, int fuel)
        {
            Name = name;
            Mileage = mileage;
            Fuel = fuel;
        }
        public override string ToString()
        {
            return $"{Name} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, Cars> dictCars = new Dictionary<string, Cars>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputData = Console.ReadLine().Split("|").ToArray();

                string carName = inputData[0];
                int carMileage = int.Parse(inputData[1]);
                int carFuel = int.Parse(inputData[2]);

                Cars newCar = new Cars(carName, carMileage, carFuel);
                dictCars.Add(carName, newCar);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split(" : ").ToArray();

                if (commands[0] == "Drive")
                {
                    string car = commands[1];
                    int distance = int.Parse(commands[2]);
                    int fuel = int.Parse(commands[3]);

                    if (dictCars[car].Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        dictCars[car].Fuel -= fuel;
                        dictCars[car].Mileage += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (dictCars[car].Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                        dictCars.Remove(car);
                    }
                }
                if (commands[0] == "Refuel")
                {
                    string car = commands[1];
                    int fuel = int.Parse(commands[2]);

                    if (dictCars[car].Fuel + fuel <= 75)
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                        dictCars[car].Fuel += fuel;
                    }
                    else if (dictCars[car].Fuel + fuel > 75)
                    {
                        int leftFuel = dictCars[car].Fuel + fuel - 75;
                        int refueldAmount = fuel - leftFuel;
                        dictCars[car].Fuel = 75;
                        Console.WriteLine($"{car} refueled with {refueldAmount} liters");
                    }

                }
                if (commands[0] == "Revert")
                {
                    string car = commands[1];
                    int kilometers = int.Parse(commands[2]);

                    if (dictCars[car].Mileage - kilometers < 10000)
                    {
                        dictCars[car].Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        dictCars[car].Mileage -= kilometers;
                    }
                }
            }

            foreach (Cars car in dictCars.Values)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
