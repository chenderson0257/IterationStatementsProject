using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var i = 0;

            //Create a List called "numbers"
            var numbers = new List<int>();
            //Create a variable of type int with an initializer of 0


            // Create a do-while loop
            do
            {
                i++;
                // Increment your variable by 1
                numbers.Add(i);
                // Then add your variable to "numbers"
            } while (i < 100);
            // While your variable is less than 100
            
            



            // Create a while loop
            // While your variable is less than 200
            while (i < 200)
            {
                i++;
                // Increment your variable by 1
                numbers.Add(i);
                // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }



            Console.WriteLine("Decrease:");



            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
                // Write to the console "numbers" at index i
            }
        }
    }
}
