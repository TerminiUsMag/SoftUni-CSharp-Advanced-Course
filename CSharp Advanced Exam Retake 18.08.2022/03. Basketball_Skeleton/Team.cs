using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Basketball
{
    public class Team
    {
        private Dictionary<string, Player> players;
        private int count;

        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public int Count
        {
            get => players.Count;
        }

        public Team(string name, int openPositions, char Group)
        {
            this.players = new Dictionary<string, Player>();
            this.Name = name;
            this.OpenPositions = openPositions;
            this.Group = Group;
        }

        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
                return "Invalid player's information.";
            else if (this.OpenPositions <= 0)
                return "There are no more open positions.";
            else if (player.Rating < 80)
                return "Invalid player's rating.";
            players.Add(player.Name, player);
            this.OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPositions}.";
        }
        public bool RemovePlayer(string name)
        {
            if (players.ContainsKey(name))
            {
                players.Remove(name);
                this.OpenPositions++;
                return true;
            }
            return false;
        }
        public int RemovePlayerByPosition(string position)
        {
            var listOfPlayerNamesToRemove = new List<string>();
            foreach (var player in players)
            {
                if (player.Value.Position == position)
                {
                    listOfPlayerNamesToRemove.Add(player.Value.Name);
                }
            }
            if (listOfPlayerNamesToRemove.Count > 0)
            {
                foreach (var name in listOfPlayerNamesToRemove)
                {
                    RemovePlayer(name);
                    
                }
                return listOfPlayerNamesToRemove.Count;
            }
            return 0;
        }
        public Player RetirePlayer(string name)
        {
            if (players.ContainsKey(name))
            {
                players[name].Retired = true;
                return players[name];
            }
            return null;
        }
        public List<Player> AwardPlayers(int games)
        {
            var result = new List<Player>();
            foreach (var player in players)
            {
                if (player.Value.Games >= games)
                {
                    result.Add(player.Value);
                }
            }
            return result;
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");
            foreach (var player in players.Where(pl=>!pl.Value.Retired))
            {
                sb.AppendLine(player.Value.ToString());
            }
            return sb.ToString().Trim();
        }


    }
}
