

using System.Runtime.CompilerServices;

namespace StructuredProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar una calculadora que reciba 2 numeros y realice las operaciones basicas.

            int resultado = 0;
            int number1;
            int number2;
            int operation;


            

            operation = GetIntegerDataUser ("Ingrese la operacion a realizar: 1. Suma 2. Resta 3. Multiplicacion 4. Division");

            switch (operation)
            {
                case 1:
                    number1 = GetIntegerDataUser("Ingrese el primer numero");
                    number2 = GetIntegerDataUser("Ingrese el segundo numero");
                    resultado = number1 + number2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;
                case 2:
                    number1 = GetIntegerDataUser("Ingrese el primer numero");
                    number2 = GetIntegerDataUser("Ingrese el segundo numero");
                    resultado = number1 - number2;
                    break;
                case 3:
                    number1 = GetIntegerDataUser("Ingrese el primer numero");
                    number2 = GetIntegerDataUser("Ingrese el segundo numero");
                    resultado = number1 * number2;
                    break;
                case 4:
                    number1 = GetIntegerDataUser("Ingrese el primer numero");
                    number2 = GetIntegerDataUser("Ingrese el segundo numero");
                    if (number2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por 0");
                    }
                    else
                    {
                        resultado = number1 / number2;
                        Console.WriteLine("El resultado de la division es: " + resultado);
                    }
                    break;
                default:
                    Console.WriteLine("Operacion no valida");
                    break;
            }





        }


        //Funcion que valida y obtiene un numero entero ingresado por el usuario
        private static int GetIntegerDataUser(string operation)
        {
            bool IsValid = false;
            string userData;
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
