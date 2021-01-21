using System;

namespace MerryMethodsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodBench methodBench = new MethodBench();
            int i = 0;
            do
            {
                methodBench.FirstMethod();
                i++;
            } while (i < 3);


            methodBench.SecondMethod("C# Now and Forever!");
            Console.WriteLine("Input a string: ");
            string input = Console.ReadLine();
            methodBench.SecondMethod(input);


            methodBench.ThirdMethod(input, Shout());

            
        }

        private static bool Shout()
        {
            Console.WriteLine("Do you want to whisper or shout?");
            ConsoleKeyInfo keyinfo = Console.ReadKey(true);
            bool shout = keyinfo.Key == ConsoleKey.S;
            return shout;
        }
    }
}
