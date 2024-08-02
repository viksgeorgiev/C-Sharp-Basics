namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputStudents = input.Split(" : ");

                string courseName = inputStudents[0];
                string studentName = inputStudents[1];

                if (!courses.ContainsKey(courseName))
                {
                    List<string> student = new List<string>
                    {
                        studentName
                    };
                    courses.Add(courseName, student);
                }
                else 
                {
                    courses[courseName].Add(studentName);
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
