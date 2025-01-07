namespace Validacion
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool success = true;


            while (success)
            {
                Console.WriteLine("Que mensaje quieres repetir?");
                string? mensaje = Console.ReadLine();
                Console.WriteLine("Cuantas veces quieres repetirlo?");
                string? repeticiones = Console.ReadLine();



                if (int.TryParse(repeticiones, out int repetic)){
                    
                    if (repetic <= 0)
                    {
                        success = false;
                        Console.WriteLine("Porfavor ingrese repeticiones mayores a 0.");
                    }
                    for (int i = 0; i < repetic; i++)
                    {
                        Console.WriteLine(mensaje);
                    }
                }
                else
                {
                    Console.WriteLine("La entrada no es valida.");
                }

            }

        }
    }
}
