// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello 👋,");
Console.WriteLine("This is a simple example of how to containerize DotNet 6 Console Application 😎");
var counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Counter: {++counter}");
    await Task.Delay(1000);
}
Console.ReadLine();

