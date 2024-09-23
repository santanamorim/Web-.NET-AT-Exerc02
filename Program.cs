using System;

class Program
{
    delegate void ProcessString(string input);

    static void Main(string[] args)
    {
        ProcessString toUpperCase = delegate (string input)
        {
            Console.WriteLine(input.ToUpper());
        };

        ProcessString toLowerCase = delegate (string input)
        {
            Console.WriteLine(input.ToLower());
        };

        Console.Write("Digite uma frase: ");
        string input = Console.ReadLine();

        toUpperCase(input);
        toLowerCase(input);
    }
}