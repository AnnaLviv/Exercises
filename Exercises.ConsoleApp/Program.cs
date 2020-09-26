using Exercises.StackExercise;
using System;

namespace Exercises.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Exercise output:");
            Console.WriteLine();

            var stack = new Stack<string>(4);
            stack.Push("Netheralnds");
            stack.Push("The");
            stack.Push("From");
            stack.Push("Greetings");

            do
            {
                Console.WriteLine(stack.Pop());
            }
            while (stack.Size > 0);

            Console.ReadLine();

        }
    }
}
