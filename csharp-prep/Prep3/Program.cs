using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
{
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1,101);

    int guess = -1;

    while (guess != magicNumber)
    {
        Console.Write("What is the magic number? ");
        guess = int.Parse(Console.ReadLine());
        
        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }

        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            System.Console.WriteLine("You guessed it!");
        }
}
}
}