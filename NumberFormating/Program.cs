namespace NumberFormating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el precio del producto:");
            string? precio = Console.ReadLine();


            if(int.TryParse(precio, out var prec))
            {
                Console.WriteLine($"Precio del producto: {prec.ToString("N")}");
            }
            else
            {
                Console.WriteLine("Error, precio incorrecto. Intente de nuevo.");
            }

            double precio1 = 12345.6789;
            Console.WriteLine(precio1.ToString("C")); // Salida: $12,345.68 (dependiendo de la configuración regional)

            double porcentaje = 0.1234;
            Console.WriteLine(porcentaje.ToString("P")); // Salida: 12.34%

            int valor = 255;
            Console.WriteLine(valor.ToString("X")); // Salida: FF

            //Formateadores personalizados.

            double numero = 12345.6789;
            Console.WriteLine(numero.ToString("0.00")); // Salida: 12345.68

            double numero1 = 12345.6789;
            Console.WriteLine(numero1.ToString("#,##0.00")); // Salida: 12,345.68

            int numero2 = 5;
            Console.WriteLine(numero2.ToString("D5")); // Salida: 00005

            

        }
    }
}
