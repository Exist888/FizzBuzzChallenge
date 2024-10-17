using System;

public class Program
{
    public static void Main(string[] args)
    {
        FizzBuzz(9);
        FizzBuzz(15);
        FizzBuzz(7);
        FizzBuzz(3);
        FizzBuzz(10);
        FizzBuzz(8);
        FizzBuzz(30);
    }

    public static string FizzBuzz(int number)
    {
        if (number % 5 == 0 && number % 3 == 0)
        {
            Console.WriteLine("FizzBuzz");
            return "FizzBuzz";
        }
        else if (number % 3 == 0 && number % 5 != 0)
        {
            Console.WriteLine("Fizz");
            return "Fizz";
        }
        else if (number % 5 == 0 && number % 3 != 0)
        {
            Console.WriteLine("Buzz");
            return "Buzz";
        }
        else
        {
            Console.WriteLine("Try again");
            return "Try Again";
        }
    }
}