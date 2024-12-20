

using System.Runtime.CompilerServices;

namespace StructuredProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar una calculadora que reciba 2 numeros y realice las operaciones basicas.

            double resultado = 0;
            double number1;
            double number2;
            int operation;


           


            do
            {
                
                operation = GetIntegerDataUser("Ingrese la operacion a realizar:  1. Suma 2. Resta 3. Multiplicacion 4. Division  0. Para salir ");
                
                switch (operation)
                {
                    case 1:
                        number1 = GetDoubleDataFromUser("Ingrese el primer numero");
                        number2 = GetDoubleDataFromUser("Ingrese el segundo numero");
                        resultado = number1 + number2;
                        Console.WriteLine($"El resultado de sumar {number1} + {number2} es: {resultado}");
                        break;
                    case 2:
                        number1 = GetDoubleDataFromUser("Ingrese el primer numero");
                        number2 = GetDoubleDataFromUser("Ingrese el segundo numero");
                        resultado = number1 - number2;
                        Console.WriteLine($"El resultado de restar {number1} - {number2} es: {resultado}");
                        break;
                    case 3:
                        number1 = GetDoubleDataFromUser("Ingrese el primer numero");
                        number2 = GetDoubleDataFromUser("Ingrese el segundo numero");
                        resultado = number1 * number2;
                        Console.WriteLine($"El resultado de multiplicar {number1 * number2} es: {resultado}");
                        break;
                    case 4:
                        number1 = GetDoubleDataFromUser("Ingrese el primer numero");
                        number2 = GetDoubleDataFromUser("Ingrese el segundo numero");
                        if (number2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por 0");
                        }
                        else
                        {
                            resultado = number1 / number2;
                            Console.WriteLine($"El resultado de dividir {number1} / {number2} es: {resultado}");
                        }
                        break;
                    default:
                        Console.WriteLine("Operacion no valida");
                        break;

                       
                }
                
            } while (operation != 0);

            Console.Clear();








        }

        private static double GetDoubleDataFromUser(string operation)
        {
            bool IsValid = false;
            //El signo de interrogacion indica que la variable puede recibir un valor nulo.(TryParse puede devovler nulo)
            string? userData;
            double data = 0;
            while (!IsValid)
            {
                Console.WriteLine(operation);
                userData = Console.ReadLine();

                if (!double.TryParse(userData, out data))
                {
                    Console.WriteLine("El valor ingresado no es un numero");
                }
                else
                {
                    IsValid = true;
                }

            }
            return data;
        }


        //Funcion que valida y obtiene un numero entero ingresado por el usuario
        private static int GetIntegerDataUser(string operation)
        {
            bool IsValid = false;
            //El signo de interrogacion indica que la variable puede recibir un valor nulo.(TryParse puede devovler nulo)
            string? userData;
            int data = 0;
            while (!IsValid)
            {
                Console.WriteLine(operation);
                userData = Console.ReadLine();

                if (!int.TryParse(userData, out data))
                {
                    Console.WriteLine("El valor ingresado no es un numero");
                }
                else
                {
                    IsValid = true;
                }
                
            }
            return data;

        }
    }
}
