namespace SquareAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Área = lado * lado
            string userData;
            double side;
            double areaSquare;
            

            Console.WriteLine("Ingrese el lado: ");
            userData = Console.ReadLine();

           


            if (double.TryParse(userData, out side))
            {
                if (side < 0) // Validación adicional: lado  negativo
                {
                    Console.WriteLine("El lado no puede ser negativo.");
                }
                else
                {
                    areaSquare = side * side;
                    Console.WriteLine($"El area del cuadrado es: {areaSquare:F2}"); // Formato a dos decimales
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }



        }
    }
}
