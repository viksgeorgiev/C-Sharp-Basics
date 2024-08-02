namespace _04.Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Student> list = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] information = input.Split(" ").ToArray();

                string name = information[0];
                string secondName = information[1];
                int age = int.Parse(information[2]);
                string homeTown = information[3];

                Student student = new(name, secondName, age, homeTown);
                list.Add(student);
            }
            string townInput = Console.ReadLine();

            List<Student> toPrint = list.Where(s => s.HomeTown == townInput).ToList();

            foreach (Student student in toPrint) 
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
