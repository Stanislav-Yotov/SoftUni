using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] newTeam = Console.ReadLine()
                                          .Split("-");
                string creatorName = newTeam[0];
                string teamName = newTeam[1];

                Team team = new Team(teamName, creatorName);
                bool isTeamNameExisting = teams.Select(a => a.TeamName).Contains(teamName);
                bool isCreatorNameExisting = teams.Select(a => a.CreatorName).Contains(creatorName);

                if (!isTeamNameExisting)
                {
                    if (!isCreatorNameExisting)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string teamMembers = Console.ReadLine();

            while (teamMembers != "end of assignment")
            {
                string[] cmdArgs = teamMembers.Split(new char[] {'-','>'}).ToArray();
                string newUser = cmdArgs[0];
                string teamName = cmdArgs[2];

                bool isTeamExisting = teams.Select(a => a.TeamName).Contains(teamName);
                bool isCreatorExisting = teams.Select(a => a.CreatorName).Contains(newUser);
                bool isMemberExisitng = teams.Select(a => a.Members).Any(a => a.Contains(newUser));

                if (!isTeamExisting)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isCreatorExisting || isMemberExisitng)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(a => a.TeamName == teamName);
                    teams[index].Members.Add(newUser);
                }

                teamMembers = Console.ReadLine();
            }

            Team[] teamsToDisband = teams.OrderBy(a => a.TeamName)
                                         .Where(a => a.Members.Count == 0)
                                         .ToArray();

            Team[] fullTeams = teams.OrderByDescending(a => a.Members.Count)
                                    .ThenBy(a => a.TeamName)
                                    .Where(a => a.Members.Count > 0)
                                    .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team team in fullTeams)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"- {team.CreatorName}");

                foreach (var member in team.Members.OrderBy(a => a))
                {
                    sb.AppendLine($"-- {member}");
                }

            }

            sb.AppendLine("Teams to disband:");
            foreach (Team item in teamsToDisband)
            {
                sb.AppendLine(item.TeamName);
            }

            Console.WriteLine(sb.ToString());
        }
    }

    class Team
    {
        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
}
