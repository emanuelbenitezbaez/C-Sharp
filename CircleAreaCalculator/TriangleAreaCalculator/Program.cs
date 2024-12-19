namespace TriangleAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Área = (base * altura) / 2
            string baseData, heightData;
            double triangleBase, triangleHeight;
            double triangleArea;

            Console.WriteLine("Ingrese la base del triángulo: ");
            baseData = Console.ReadLine();

            Console.WriteLine("Ingrese la altura del triángulo: ");
            heightData = Console.ReadLine();

            if (double.TryParse(baseData, out triangleBase) && double.TryParse(heightData, out triangleHeight))
            {
                if (triangleBase < 0 || triangleHeight < 0) // Validación: base o altura negativas
                {
                    Console.WriteLine("La base y la altura deben ser valores no negativos.");
                }
                else
                {
                    triangleArea = (triangleBase * triangleHeight) / 2;
                    Console.WriteLine($"El área del triángulo es: {triangleArea:F2}"); // Formato a dos decimales
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese números válidos para la base y la altura.");
            }
            Console.ReadKey(); //Esto mantiene la consola abierta hasta que se presiona una tecla

        }
    }
}
