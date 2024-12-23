namespace ManejorDeErroresYDepuracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                divide();

            } catch (Exception ex) {
                throw new Exception("Error al dividir", ex);
            }
            finally
            {
                Console.WriteLine("El programa termino de ejecutarse");
            }



        }

        private static void divide()
        {
            Console.WriteLine("Ingrese un numero para dividir 100");
            string input = Console.ReadLine();
            int divisor;
            bool isValid = int.TryParse(input, out divisor);
            if (!isValid)
            {
                divisor = 0;
            }

            int result = 100 / divisor;
            Console.WriteLine($"Resultado: {result}");
        }
    } 
}
