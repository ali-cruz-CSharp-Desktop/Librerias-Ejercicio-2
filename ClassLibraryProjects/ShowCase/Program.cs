using System;

// Fue agregada como DLL
using ExampleClassLibrary01;

// Fue agregada como Add Project References
using UtilityLibraries;

    class Program
    {
        static void Main(string[] args)
        {
        // Haciendo uso del DLL (Library) ExampleClassLibrary01
        Functions algebra = new Functions();

        Console.WriteLine("Llamada a libreria externa");
        Console.WriteLine(algebra.Addition(5.5, 3.3));

        Console.Write(typeof(string).Assembly.ImageRuntimeVersion);

        string mensajeNull = null;
        Console.WriteLine($"\nThe length of the message is" +
                    $" { (mensajeNull != null ? mensajeNull.Length : "es null")}");

        int row = 0;

        do
        {
            //if (row == 0 || row >= 25)
            //    ResetConsole();

            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                break;

            Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
              $"{(input.StartsWithUpper() ? "Yes" : "No")}{Environment.NewLine}");
            row += 3;
        } while (true);
        return;


        // Local Method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, " +
                $"enter a string and press <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}
