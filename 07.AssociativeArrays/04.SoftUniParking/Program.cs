namespace _04.SoftUniParking
{
    public class ParkingLot
    {
        public string UserName { get; set; }

        public string LicensePlate { get; set; }

        public ParkingLot(string userName, string licensePlate)
        {
            UserName = userName;
            LicensePlate = licensePlate;
        }

        public static bool ContainsUser(string user, Dictionary<string, ParkingLot> parkingLot)
        {
            return parkingLot.ContainsKey(user);
        }

        public override string ToString()
        {
            return $"{UserName} => {LicensePlate}";
        }


    }
    internal class Program
    {



        static void Main(string[] args)
        {

            Dictionary<string, ParkingLot> parkingLot = new();

            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                switch (input[0])
                {
                    case "register":
                        string usernameInput = input[1];
                        string licensePlateInput = input[2];

                        ParkingLot parking = new ParkingLot(usernameInput, licensePlateInput);

                        if (ParkingLot.ContainsUser(usernameInput, parkingLot))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateInput}");
                        }
                        else
                        {
                            parkingLot.Add(usernameInput, parking);
                            Console.WriteLine($"{usernameInput} registered {licensePlateInput} successfully");
                        }

                        break;
                    case "unregister":
                        usernameInput = input[1];
                        if (!ParkingLot.ContainsUser(usernameInput, parkingLot))
                        {
                            Console.WriteLine($"ERROR: user {usernameInput} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{usernameInput} unregistered successfully");
                            parkingLot.Remove(usernameInput);
                        }
                        break;
                }
            }

            foreach (var pair in parkingLot.Values)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
