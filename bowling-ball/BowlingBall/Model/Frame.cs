using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
   public class Frame : Iframe
    {       
              
        public int totalFrames { get; set; }

        public List<int> listpins { get; set; }

        public Dictionary<int, int> pinsPerRole { get; set; }
       
        public Dictionary<int, int> GetpinsPerRole(List <int> lstpins)
        {
            int rollsCounter = 0 ;
            pinsPerRole = new Dictionary<int, int>();

            for (int i = 0; i < lstpins.Count; i++)
            {
                pinsPerRole.Add(rollsCounter, lstpins[i]);
                rollsCounter++;
            }          

            return pinsPerRole;
        }
    }
}
