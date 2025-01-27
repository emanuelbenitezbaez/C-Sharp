



namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----CALCULATOR----");

            bool isValid = true;

            while (isValid)
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - Suma.");
                Console.WriteLine("2 - Resta.");
                Console.WriteLine("3 - Multiplicacion.");
                Console.WriteLine("4 - Division.");
                Console.WriteLine("0 - Salir.");

                int option = leerNumero("Seleccione una opción: ");
                switch (option)
                {

                    case 0:
                        Console.WriteLine("Fin del programa..");
                        isValid = false;
                        break;

                    case 1:
                        int num1 =  leerNumero("Ingrese el primer numero:");
                        int num2 = leerNumero("Ingrese el segundo numero:");
                        int res = suma(num1,num2);
                        Console.WriteLine("El resultado de la suma es: " + res);
                        break;

                    case 2:
                        int numResta1 = leerNumero("Ingrese el primer numero:");
                        int numResta2 = leerNumero("Ingrese el segundo numero:");
                        int resResta = resta(numResta1, numResta2);
                        Console.WriteLine("El resultado de la resta es: " + resResta);
                        break;

                    case 3:
                        int numeroMulti1 = leerNumero("Ingrese el primer numero:");
                        int numeroMulti2 = leerNumero("Ingrese el segundo numero:");
                        int resMulti = multiplicacion(numeroMulti1, numeroMulti2);
                        Console.WriteLine("El resultado de la resta es: " + resMulti);
                        break;

                    case 4:
                        int numDiv1 = leerNumero("Ingrese el primer numero:");
                        int numDiv2 = leerNumero("Ingrese el primer numero:");

                        if (numDiv2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por 0.");
                            break;
                        }
                        else
                        {
                            float resDivi = division(numDiv1, numDiv2);
                            Console.WriteLine("El resultado de la resta es: " + resDivi);
                        }
                        
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }
            }
        }

        private static int resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        private static float division(float numeroDivi1, float numeroDivi2)
        {
            return numeroDivi1 / numeroDivi2;
        }

        private static int multiplicacion(int num1,int num2)
        {
            return num1 * num2;
        }


        private static int suma(int num1, int num2)
        {
            return num1 + num2;
        }

       

        private static int leerNumero(string mensaje)
        {
            int numero;
            while (true)
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }
            }
        }
    }
}
