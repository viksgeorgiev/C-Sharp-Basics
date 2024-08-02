namespace _06.StudentAcademy
{
    public class Student
    {
        public string StudentName { get; set; }
        public List<double> Grades { get; set; }

        public Student(string studentName, List<double> grades)
        {
            StudentName = studentName;          
            Grades = grades;
        }

        public override string ToString()
        {
            return $"{StudentName} -> {Grades.Average():F2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRowsOfPairs = int.Parse(Console.ReadLine());

            Dictionary<string, Student> academyDictionary = new();

            for (int i = 0; i < numberOfRowsOfPairs; i++)
            {
                string studentNameInput = Console.ReadLine();
                double studentScoreInput = double.Parse(Console.ReadLine());

                List<double> studentScoreList = new List<double>() { studentScoreInput };

                Student student = new Student(studentNameInput, studentScoreList);

                if (!academyDictionary.ContainsKey(studentNameInput))
                {
                    academyDictionary.Add(studentNameInput, student);
                }
                else
                {
                    academyDictionary[studentNameInput].Grades.Add(studentScoreInput);
                }
            }

            var sortedDictionary = academyDictionary.Where(s => s.Value.Grades.Average() >= 4.50);

            foreach (var student in sortedDictionary) 
            {
                Console.WriteLine(student.Value.ToString());
            }
        }
    }
}
