



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

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 0:
                        Console.WriteLine("Fin del programa..");
                        isValid = false;
                        break;

                    case 1:
                        Console.WriteLine("Ingrese el primer numero:");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        int num2 = int.Parse(Console.ReadLine());
                         int res = suma(num1,num2);
                        Console.WriteLine("El resultado de la suma es: " + res);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el primer numero:");
                        int numero1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        int numero2 = int.Parse(Console.ReadLine());
                        int resResta = resta(numero1,numero2);
                        Console.WriteLine("El resultado de la resta es: " + resResta);
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el primer numero:");
                        int numeroMulti1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        int numeroMulti2 = int.Parse(Console.ReadLine());
                        int resMulti = multiplicacion(numeroMulti1, numeroMulti2);
                        Console.WriteLine("El resultado de la resta es: " + resMulti);
                        break;

                    case 4:
                        Console.WriteLine("Ingrese el primer numero:");
                        int numeroDivi1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        int numeroDivi2 = int.Parse(Console.ReadLine());

                        if (numeroDivi2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por 0.");
                            break;
                        }
                        else
                        {
                            float resDivi = division(numeroDivi1, numeroDivi2);
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

        //Funciones

        private static int suma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
