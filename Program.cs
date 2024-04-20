using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
Random random = new Random();
int secretNumber = random.Next(1000, 9999);
int attempts = 0;

while (true)
{
    Console.Write("Enter your guess: ");
     var guess = Console.ReadLine();
     Convert.ToInt32(guess);

    if (guess.Equals(secretNumber))
        
    {
        Console.WriteLine("Congratulations! You guessed the secret number. Attempts = 1");
        break;
    }

    int cows = 0;
    int bulls = 0;


for (int i = 0; i < secretNumber; i++)
    {
        if (secretNumber == guess[i])
        {
            cows++;
        }
        else
        {
            bulls++;
        }
    }

    Console.WriteLine($"Cows: {cows}, Bulls: {bulls}");
    attempts++;
}

Console.WriteLine($"You guessed the number in {attempts} attempts.");

        }
    }
}
