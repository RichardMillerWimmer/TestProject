// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Random dice = new Random();
Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
