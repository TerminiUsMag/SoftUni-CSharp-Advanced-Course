using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Iterators_and_Comparators___Lab
{
    class PileOfCash : IComparable<PileOfCash>
    {
        private double value;
        public Dictionary<string, int> Notes { get; set; }
        public int totalNumberOfNotes;

        public PileOfCash()
        {
            Notes = new Dictionary<string, int>();
        }
        public void AddNotes(string typeOfNote, int numberOfNotes)
        {
            totalNumberOfNotes += numberOfNotes;
            if (!Notes.ContainsKey(typeOfNote))
            {
                Notes.Add(typeOfNote, numberOfNotes);
            }
            else
            {
                Notes[typeOfNote]+=numberOfNotes;
            }

            foreach(var note in this.Notes)
            {
                var type = int.Parse(note.Key);
                var number = note.Value;

                this.value += (type * number);
            }
        }
        public void Reset()
        {
            this.Notes.Clear();
            this.value = 0;
        }

        public int CompareTo(PileOfCash other)
        {
            var result = this.value.CompareTo(other.value);
            return result;
        }
    }
}
