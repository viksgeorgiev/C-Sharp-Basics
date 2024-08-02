namespace _05.TeamworkProjects
{
    public class Teams
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public Teams(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }

        public void AddMember(string member)
        {
            Members.Add(member);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < numberOfTeams; i++)
            {

                string[] createTeams = Console.ReadLine().Split("-").ToArray();

                string creator = createTeams[0];
                string teamName = createTeams[1];


                bool teamExists = teams.Any(t => t.TeamName == teamName);
                bool creatorExists = teams.Any(t => t.Creator == creator);

                if (teamExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if(creatorExists)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Teams team = new Teams(teamName, creator);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string input;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] membersInput = input.Split("->").ToArray();

                string user = membersInput[0];
                string teamName = membersInput[1];

                if(!teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if(teams.Any(team => team.Creator == user) || 
                    teams.Any(team => team.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                teams.Find(team => team.TeamName == teamName).Members.Add(user);
            }


            var validTeams = teams.Where(t => t.Members.Count > 0)
                                    .OrderByDescending(t => t.Members.Count)
                                    .ThenBy(t => t.TeamName);

            var disbandedTeams = teams.Where(t => t.Members.Count == 0)
                                     .OrderBy(t => t.TeamName);


            foreach(var team in validTeams) 
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach(var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
