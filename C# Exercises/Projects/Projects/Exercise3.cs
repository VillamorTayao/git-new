using System;

namespace Projects
{
    internal class Exercise3
    {  
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            int total = 0;

            foreach(int num in numbers)
            {
                total += num;
            }

            Console.WriteLine(total);
        }
    }
}
