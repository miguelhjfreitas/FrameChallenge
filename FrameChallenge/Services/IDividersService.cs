using FrameChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameChallenge.Services
{
    public interface IDividersService
    {
        NumberDivider GetDividers(int integer);

    }
}
