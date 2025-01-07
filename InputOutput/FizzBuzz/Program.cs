namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */



            bool success = true;

            while(success)
            {

                Console.WriteLine("Ingrese un numero:");

                string? numero = Console.ReadLine();

                if(int.TryParse(numero, out int num)){

                    if (num <= 0)
                    {
                        success = false;
                        Console.WriteLine("Error, debe ingresar un numero mayor a 0");
                    }

                    for (int i = 1; i <= num; i++)
                    {

                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else if (i % 3 == 0)
                        {
                            Console.WriteLine("fizz");
                        }
                        else if (i % 5 == 0)
                        {
                            Console.WriteLine("buzz");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                        
                    }

            }
        }
    }
    }
    }
