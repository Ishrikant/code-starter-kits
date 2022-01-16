using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public interface IGame
    {
        //Dictionary<int, int> Roll(List<int> lstpins);
        int GetScore(Frame frm);
    }
}
