﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Random dice = new Random();
// Random dice = new();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// using System.Security.Permissions;

// Code Challenge
// int firstValue = 500;
// int secondValue = 600;
// int largerValue = System.Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    if (roll1 == roll2 && roll1 == roll3)
    {
        Console.WriteLine("You rolled tripples! +6 bonus to total!");
        total += 6;
    }
    else
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

Console.WriteLine(total);

// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }

// else
// {
//     Console.WriteLine("Sorry, you lose.");
// }

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}