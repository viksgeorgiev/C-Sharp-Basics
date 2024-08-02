using System.Collections.Generic;
using System.Diagnostics;

namespace _04.Students
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public Students(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentInformation = Console.ReadLine().Split(" ").ToArray();
                string firstName = studentInformation[0];
                string lastName = studentInformation[1];
                float grade = float.Parse(studentInformation[2]);
                Students student = new Students(firstName, lastName, grade);
                students.Add(student);
            }

            var sortPersonDescending = students.OrderByDescending(student => student.Grade);


            foreach (Students student in sortPersonDescending)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
