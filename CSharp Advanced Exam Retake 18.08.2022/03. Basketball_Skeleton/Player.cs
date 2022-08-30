using System;
using System.Text;
using System.Xml.Linq;

namespace Basketball
{
    public class Player
    {
        private bool retired;
        public string Name { get; set; }
        public string Position { get; set; }
        public double Rating { get; set; }
        public int Games { get; set; }
        public bool Retired
        {
            get => retired;
            set => retired = value;
        }
        public Player(string name, string position, double rating, int games)
        {
            this.Name = name;
            this.Position = position;
            this.Rating = rating;
            this.Games = games;
            this.Retired = false;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"-Player: {this.Name}");
            sb.AppendLine($"--Position: {this.Position}");
            sb.AppendLine($"--Rating: {this.Rating}");
            sb.AppendLine($"--Games played: {this.Games}");

            return sb.ToString().Trim();
        }
    }
}
