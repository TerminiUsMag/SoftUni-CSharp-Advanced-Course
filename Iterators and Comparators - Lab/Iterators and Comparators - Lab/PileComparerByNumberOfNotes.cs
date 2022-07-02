using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Iterators_and_Comparators___Lab
{
    internal class PileComparerByNumberOfNotes : IComparer<PileOfCash>
    {
        public int Compare(PileOfCash x, PileOfCash y)
        {
            return x.totalNumberOfNotes.CompareTo(y.totalNumberOfNotes);
        }
    }
}
