namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Por favor, introduce tu edad: ");
            string input = Console.ReadLine();
            

            

            // Intentamos convertir la entrada a un entero

            if (int.TryParse(input, out int edad)) {

                Console.WriteLine("La variable 'edad' es del tipo: " + edad.GetType());

            } else {

                Console.WriteLine("La entrada no es un entero válido.");

            }

            Console.WriteLine("Que mensaje quieres repetir?");
            string mensaje = Console.ReadLine();
            Console.WriteLine("Cuantas veces quieres repetirlo?");
            string repeticiones = Console.ReadLine();


            if(int.TryParse(repeticiones, out int repetic))
            {
                for (int i = 0;i < repetic; i++)
                {
                    Console.WriteLine(mensaje);
                }
            }else
            {
                Console.WriteLine("La entrada no es valida.");
            }


        }
    }
}
