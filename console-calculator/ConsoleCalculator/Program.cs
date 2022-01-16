using BowlingBall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            while(true)
            {

                Console.Write("***** WelCome to Bowling Ball Game ****" + Environment.NewLine);               

                Console.Write("***** Please press 'Enter' to Start the Game ****" + Environment.NewLine);


                var key = Console.ReadKey(true);

                if (key.KeyChar == 13)
                {
                    Console.Write("***** Bowling Ball Game started... ****" + Environment.NewLine + Environment.NewLine);


                    int score = calc.SendKeystroke(key.KeyChar);

                    Console.Write("***** Final Score ****" + score + Environment.NewLine );
                    Console.ReadLine(); 
                }
                else
                {
                    //If user enters any other key 'Enter' then exit the program
                    Console.Write(" ***** Thank you ****");
                    System.Threading.Thread.Sleep(5000);
                    Environment.Exit(0);
                }
                
                //Console.Clear();
                //Console.Write(calc.DisplayText);
            }
        }
       
    }
}
