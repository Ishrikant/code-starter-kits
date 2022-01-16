using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public interface Iframe
    {
       

        Dictionary<int, int> GetpinsPerRole( List<int> lstpins);
    }
}
