using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Step 1: Accept two integers from the user
            Console.Write("Input 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Step 2: Check if numbers are equal
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} is smaller than {num2}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid integer numbers.");
        }
    }
}
