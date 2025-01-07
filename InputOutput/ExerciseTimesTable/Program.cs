namespace ExerciseTimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product table
            // Ask the user for a number for the table
            // Write a for loop to print X times table

           

            bool success = true;

            
            while (success)
            {
                Console.WriteLine("Ingresa un numero:");

                string? numero = Console.ReadLine();

               

                Console.WriteLine("Cuantas veces quiere multiplicarlo?");

                string? veces = Console.ReadLine();

                if(int.TryParse(veces, out int cantidad) && int.TryParse(numero, out int multiplicado))
                {
                    
                    if(cantidad <=0 || multiplicado <=0)
                    {
                        success = false;
                        Console.WriteLine("Porfavor ingrese repeticiones mayores a 0.");
                    }
                    

                    for(int i = 1; i <= cantidad; i++)
                    {
                        int resultado = multiplicado * i;
                        Console.WriteLine($"{multiplicado} * {i}: {resultado}");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Error.");

                }



            }
            
           




        }
    }
}
