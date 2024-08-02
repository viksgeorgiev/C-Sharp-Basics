namespace _07.CompanyUsers
{
    public class Company
    {
        public string Name { get; set; }
        public List<string> EmployeeIds { get; set; }

        public Company(string name, List<string> employeeIds)
        {
            Name = name;
            EmployeeIds = employeeIds;
        }

        public override string ToString()
        {
            string result = string.Empty;

            result += $"{Name}\n";

            foreach (var employee in EmployeeIds)
            {
                result += $"-- {employee}\n";
            }
            return result.Trim();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;

            Dictionary<string, Company> companyDict = new Dictionary<string, Company>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] dataInput = input.Split(" -> ");

                string companyName = dataInput[0];
                string employeeId = dataInput[1];
                if (!companyDict.ContainsKey(companyName))
                {
                    List<string> employeeIdsList = new List<string>() { employeeId };

                    
                    companyDict.Add(companyName, new Company(companyName, employeeIdsList));
                }
                else
                {
                    if (!companyDict[companyName].EmployeeIds.Contains(employeeId))
                    {
                        companyDict[companyName].EmployeeIds.Add(employeeId);
                    }
                }
            }

            foreach (var company in companyDict.Values)
            {
                Console.WriteLine(company);
            }
        }
    }
}
