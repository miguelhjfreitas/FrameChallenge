using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameChallenge.Models
{
    public class NumberDivider
    {
        public NumberDivider(int number)
        {
            this.Number = number;
        }

        public int Number { get; }
        public ISet<int> Dividers { get; } = new SortedSet<int>();
        public ISet<int> PrimeDividers { get; } = new SortedSet<int>();
    }
}
