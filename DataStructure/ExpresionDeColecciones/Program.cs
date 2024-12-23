using System;
namespace ExpresionDeColecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Expresion de colecciones
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("--------------------------------------");

            List<int> nums = [134, 2097, 3675, 4944, 5984, 6557, 7787, 8224, 9566];

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("--------------------------------------");
            string[] cadena = { "hola", "mundo", "cruel" };

            foreach (string cad in cadena)
            {
                Console.WriteLine(cad);
            }


        }

      
    }

}
  



