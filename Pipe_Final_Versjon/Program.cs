// See https://aka.ms/new-console-template for more information

using Pipe_Final_Versjon;

Console.WriteLine("Hello, World!");

Console.OutputEncoding = System.Text.Encoding.UTF8;

var board = new Brett();

while (true)
{
    Console.WriteLine("Skriv inn index");
    var inputIndex = Console.ReadLine();
    Console.WriteLine("Skriv inn rettning");
    var inputDirection = Console.ReadLine();
    board.userInput(inputIndex,inputDirection);


}