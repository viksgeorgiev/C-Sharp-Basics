namespace _07.OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] dataInput = input.Split(" ").ToArray();

                string personName = dataInput[0];
                string personId = dataInput[1];
                int personAge = int.Parse(dataInput[2]);
                if (listOfPersons.Any(p => p.Id == personId))
                {
                    Person found = listOfPersons.Find(p => p.Id == personId);
                    found.Name = personName;
                    found.Age = personAge;
                }
                else
                {
                    Person personInstance = new Person(personName, personId, personAge);
                    listOfPersons.Add(personInstance);
                }
            }

            List<Person> listForPrinting = listOfPersons.OrderBy(p => p.Age).ToList();

            foreach (Person person in listForPrinting) 
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
