using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> data;
        public string Project { get; set; }
        public int NeededRenovators { get; set; }
        public string Name { get; set; }
        public int Count
        {
            get
            {
                return this.data.Count;
            }

        }
        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
            this.data = new List<Renovator>();
        }
        public string AddRenovator(Renovator renovator)
        {
            if (renovator.Name == null || renovator.Type == null || renovator.Name.Length == 0 || renovator.Type.Length == 0)
                return "Invalid renovator's information.";
            if (renovator.Rate > 350)
                return "Invalid renovator's rate.";
            if (this.Count >= this.NeededRenovators)
                return "Renovators are no more needed.";
            this.data.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }
        public bool RemoveRenovator(string name)
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                var renovatorName = this.data[i].Name;
                if (renovatorName == name)
                {
                    this.data.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            var counter = 0;
            for (int i = 0; i < this.data.Count; i++)
            {
                var renovatorType = this.data[i].Type;
                if (renovatorType == type)
                {
                    this.data.RemoveAt(i);
                    counter++;
                }
            }
            if (counter > 0)
                return counter;
            return 0;
        }
        public Renovator HireRenovator(string name)
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                var renovatorName = this.data[i].Name;
                if (renovatorName == name)
                {
                    this.data[i].Hired = true;
                    return this.data[i];
                }
            }
            return null;
        }
        public List<Renovator> PayRenovators(int days)
        {
            var result = new List<Renovator>();
            for (int i = 0; i < this.data.Count; i++)
            {
                var renovatorDays = this.data[i].Days;
                if (renovatorDays >= days)
                {
                    result.Add(this.data[i]);
                }
            }
            return result;
        }

        public string Report()
        {
            var result = string.Empty;
            result += $"Renovators available for Project {this.Project}:{Environment.NewLine}";
            for (int i = 0; i < this.data.Count; i++)
            {
                if (!this.data[i].Hired)
                {
                    result += (this.data[i].ToString());
                }
            }
            return result;
        }
    }
}
