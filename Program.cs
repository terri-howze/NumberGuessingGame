using System;
using System.Numerics;
namespace numberguessinggame
{
    internal class Program
    {
        static void Main(string[] args)
        {
        var rand = new Random();
        int answer = rand.Next(1,11);
        int guessAnswer;
        bool correctAnswer = false;


        Console.WriteLine("Welcome to the number guessing game!\nA Number between 1 and 10 will be generated.");
        Console.WriteLine("If you guess the correct number, you win!\nPlease enter your guess");
 
        guessAnswer = Int32.Parse(Console.ReadLine());
            while (!correctAnswer)
            {
                if(guessAnswer > answer)
                {
                    Console.WriteLine("Your guess is too high!\nPlease enter your guess.");
                    guessAnswer = Int32.Parse(Console.ReadLine());
                }
                else if(guessAnswer < answer)
                {
                    Console.WriteLine("Your guess is too low!\nPlease enter your guess.");
                    guessAnswer = Int32.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Correct!\nCongratulations, you have won the game!");
                    correctAnswer = true;
                }
            }

        }
    }
}
