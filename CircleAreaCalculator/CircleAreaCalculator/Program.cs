namespace CircleAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Área = π * r²
            const double PI = 3.14;
            string userData;
            double radius;
            double area;
            Console.WriteLine("Ingrese el radio:");
            userData = Console.ReadLine();

            if (double.TryParse(userData, out radius))
            {
                if (radius < 0) // Validación adicional: radio  negativo
                {
                    Console.WriteLine("El radio no puede ser negativo.");
                }
                else
                {
                    area = PI * Math.Pow(radius, 2);
                    Console.WriteLine($"El area del circulo es: {area:F2}"); // Formato a dos decimales
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }


        }
    }
}
