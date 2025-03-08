using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Issue #1: Hardcoded sensitive information
        string password = "SuperSecret123";

        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        // Issue #2: Insecure string concatenation (potential for injection attacks)
        string greeting = "Hello, " + name;
        Console.WriteLine(greeting);

        // Issue #3: Insecure file handling (no input validation)
        Console.WriteLine("Enter the file name to read:");
        string fileName = Console.ReadLine();
        string filePath = "C:\\Test\\" + fileName; // Could allow directory traversal
        if (File.Exists(filePath))
        {
            Console.WriteLine(File.ReadAllText(filePath));
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
