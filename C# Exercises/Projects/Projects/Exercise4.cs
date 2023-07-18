using System;

namespace Projects
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            string symbol = "<>";

            displayOutput(rows(), columns(), symbol);
        }

        static int rows()
        {
            Console.Write("How many rows do you want?: "); ;
            return Convert.ToInt32(Console.ReadLine());
        }

        static int columns()
        {
            Console.Write("How many columns do you want?: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void displayOutput(int rows, int cols, string symb)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(symb);
                }
                Console.WriteLine();
            }
        }
    }
}
