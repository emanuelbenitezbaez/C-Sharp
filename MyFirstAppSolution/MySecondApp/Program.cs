using System;
namespace MySecondApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string message = string.Empty;
            Console.WriteLine("Ingrese un mensaje:");
            message = Console.ReadLine();
            Console.WriteLine("Resultado: " +message);
            Console.Read();

        }
    }
}
