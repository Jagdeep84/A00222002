using System;
using System.ComponentModel;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("       CALCULATOR     \r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                string NInput1 = "";
                string NInput2 = "";
                double result = 0;

                Console.Write("Enter a number please, and then press Enter: ");
                NInput1 = Console.ReadLine();
                double cleanN1 = 0;
                while (!double.TryParse(NInput1, out cleanN1))
                {
                    Console.Write("Please enter valid input: ");
                    NInput1 = Console.ReadLine();
                }
                Console.Write("Enter another number please, and then press Enter: ");
                NInput2 = Console.ReadLine();

                double cleanN2 = 0;
                while (!double.TryParse(NInput2, out cleanN2))
                {
                    Console.Write("Please enter valid input: ");
                    NInput2 = Console.ReadLine();
                }
                Console.WriteLine("Choose an operator:");
                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Subtract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divide");
                Console.Write("operator: ");

                  string op = Console.ReadLine();
                try
                {
                    result = calculator.DoOperation(cleanN1, cleanN2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

              
                Console.Write("Press 'E' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "E") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
        
    }
}
