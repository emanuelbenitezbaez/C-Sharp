using System;
namespace StructuredProgrammingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||-----------CALCULADORA--------------||");

            int numero1;
            int numero2;
            int operation;
            int result;
            Console.WriteLine("Ingrese la operacion que desea realizar: (1 - Suma 2 - Resta)");
            if (int.TryParse(Console.ReadLine(), out operation))
            {
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Usted ingreso la operacion suma.");
                        Console.WriteLine("Ingrese el primer numero: ");
                        if (int.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Ingrese el segundo numero : ");
                            if (int.TryParse(Console.ReadLine(), out numero2))
                            {
                                result = numero1 + numero2;
                                Console.WriteLine("Resultado de la suma: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Error, el segundo número no es válido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error, el primer número no es válido.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Usted ingreso la operacion resta.");
                        Console.WriteLine("Ingrese el primer numero: ");
                        if (int.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Ingrese el segundo numero : ");
                            if (int.TryParse(Console.ReadLine(), out numero2))
                            {
                                result = numero1 - numero2;
                                Console.WriteLine("Resultado de la resta: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Error, el segundo número no es válido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error, el primer número no es válido.");
                        }
                        break;
                    default:
                        Console.WriteLine("Error, intente de nuevo..");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error, la operación no es válida.");
            }
        }
    }
}
