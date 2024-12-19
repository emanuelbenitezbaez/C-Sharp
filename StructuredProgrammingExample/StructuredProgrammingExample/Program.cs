using System;
namespace StructuredProgrammingExample
{
    internal class Program
    {



        private static int getIntegerDataFromUser(string message)
        {
            String? userData;
            int data = 0;
            bool isDataValid = false;
            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();
                if (userData==null || !int.TryParse(userData, out data))
                {
                    Console.WriteLine("Error, el dato ingresado no es válido.");

                }
                else
                {
                    isDataValid = true;
                }
            }
            return data;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("||-----------CALCULADORA--------------||");

            int operation;

            operation = getIntegerDataFromUser("Ingrese la operacion que desea realizar: (1 - Suma 2 - Resta)");

            switch(operation)
            {
                case 1:
                    int number1 = getIntegerDataFromUser("Ingrese el primer número");
                    int number2 = getIntegerDataFromUser("Ingrese el segundo número");
                    Console.WriteLine("El resultado de la suma es: " + (number1 + number2));
                    break;
                case 2:
                    int number3 = getIntegerDataFromUser("Ingrese el primer número");
                    int number4 = getIntegerDataFromUser("Ingrese el segundo número");
                    Console.WriteLine("El resultado de la resta es: " + (number3 - number4));
                    break;
                default:
                    Console.WriteLine("Error, la operación ingresada no es válida.");
                    break;


            }


        }
    }




}



