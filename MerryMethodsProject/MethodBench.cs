using System;
using System.Collections.Generic;
using System.Text;

namespace MerryMethodsProject
{
    class MethodBench
    {
        public void FirstMethod()
        {
            Console.WriteLine("Merry Methods");
        }

        public void SecondMethod(string msg)
        {
            Console.WriteLine(msg);
        }

        public void ThirdMethod(string input, bool uppercase)
        {
            if (uppercase)
            {
                input = input.ToUpper();
            }
            else
            {
                input = input.ToLower();
            }
            SecondMethod(input);
        }

        public bool FourthMethod()
        {
            Console.WriteLine("Would you like to shout or whisper? Press S to shout or W to whisper.");
           
            
            var keyInput = Console.ReadKey(true);

            if (keyInput.Key == ConsoleKey.S)
            {
                return true;
            }
            else if (keyInput.Key == ConsoleKey.W)
            {
                return false;
            }
            else
                return false;
                
        }
    }
}
