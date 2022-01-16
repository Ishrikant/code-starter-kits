using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{   

    public class Game : IGame
    {
        Iframe _frame;

        public Game()
        {

        }
        public Game(Iframe frame)
        {
            _frame = frame;
        }

        public int GetScore(Frame frm)
        {
            int score = 0;
            int i = 0;
            int frame = 0;
            Iframe _frame = new Frame();

           Dictionary<int, int> pinsPerRole = _frame.GetpinsPerRole(frm.listpins);
                      
            for (frame = 0; frame < frm.totalFrames; frame++)
            {
                if (pinsPerRole[i] == 10)       // strike  
                {
                    score += 10 + pinsPerRole[i + 1] + pinsPerRole[i + 2];

                    i = i + 1;
                }
                else if (pinsPerRole[i] + pinsPerRole[i + 1] == 10)  // spare 
                {
                    score += 10 + pinsPerRole[i + 2];
                    i = i + 2;
                }
                else
                {
                    score += pinsPerRole[i] + pinsPerRole[i + 1];
                    i = i + 2;

                }
            }
                     

            return score;
        }

           

        
    }




}
