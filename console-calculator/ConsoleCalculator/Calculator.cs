using System;
using BowlingBall;
using System.Configuration;
using System.Collections.Generic;

namespace ConsoleCalculator
{
    public class Calculator
    {
        
        IGame _game;
        Iframe _frame;

        public Calculator()
        {
            
        }
        public Calculator(IGame game,Iframe frame)
        {
            this._game = game;
            this._frame = frame;
        }

        public string DisplayText { get; private set; } = string.Empty;

        public int SendKeystroke()
        {
            Game game = new Game();

            int totalFrames = 10;

            int.TryParse(ConfigurationManager.AppSettings["TotalFrames"], out totalFrames);
            List<int> lstpins = new List<int> { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

           
            //Frames are Configurable 
            Frame frame = new Frame()
            {
                
                 totalFrames = (totalFrames != 0) ? totalFrames : 10,
                 listpins = lstpins
            };

            int finalScore =  game.GetScore(frame);

            return finalScore;

        }
       
    }
}
