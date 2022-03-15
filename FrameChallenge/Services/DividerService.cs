using FrameChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameChallenge.Services
{
    public class DividerService : IDividersService
    {
        public NumberDivider GetDividers(int number)
        {
            NumberDivider numberDivider = new NumberDivider(number);

            if (number <= 0)
            {
                return null;
            }
            for (int i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (IsPrimeDivider(i))
                    {
                        numberDivider.PrimeDividers.Add(i);
                    }
                    numberDivider.Dividers.Add(i);
                    int multiplier = number / i;
                    if (i != multiplier)
                    {
                        if (IsPrimeDivider(multiplier))
                        {
                            numberDivider.PrimeDividers.Add(multiplier);
                        }
                        numberDivider.Dividers.Add(multiplier);
                    }
                }
            }
            return numberDivider;
        }

        private bool IsPrimeDivider(int divider)
        {
            if (divider < 2) return false;
            if (divider % 2 == 0) return (divider == 2);
            int root = (int)Math.Sqrt((double)divider);
            for (int i = 3; i <= root; i += 2)
            {
                if (divider % i == 0) return false;
            }
            return true;
        }
    }
}
