using System;

namespace PremierNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter a Number");
            int number;
            int temp = 0;
            int i;
            int.TryParse(Console.ReadLine(), out number);
            
            for (i = 1; i <= number; i++)
            {
                
                if (number % i == 0)
                    temp = temp + 1;
            }
            if (temp == 2)
                Console.WriteLine("The number you enter is premier");
            else
                Console.WriteLine("The number you enter is not premier");

            Console.ReadKey();

        }
    }
}
