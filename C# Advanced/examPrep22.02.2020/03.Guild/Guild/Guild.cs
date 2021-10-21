using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
   public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => roster.Count;

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = roster.Find(x => x.Name == name);
            if (player == null)
            {
                return false;
            }
            else
            {
                roster.Remove(player);
                return true;
            }
        }

        public void PromotePlayer(string name)
        {
            if (roster.Find(x => x.Name == name) == null || roster.Find(x => x.Name == name).Rank == "Member")
                return;
            else
            {
                roster.Find(x => x.Name == name).Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            if (roster.Find(x => x.Name == name) == null || roster.Find(x => x.Name == name).Rank == "Trial")
            {
                return;
            }
            else
            {
                roster.Find(x => x.Name == name).Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            Player[] arr;
            arr = roster.Where(x => x.Class == @class).ToArray();
            roster = roster.Where(x => x.Class != @class).ToList();
            return arr;
        } 

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in roster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
