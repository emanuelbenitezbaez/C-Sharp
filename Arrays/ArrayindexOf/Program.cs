namespace ArrayindexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[] { 19, 28, 37, 46, 55, 64, 73, 82, 91 };
            Console.WriteLine("Cual es el numero que busca?");

            int search = Convert.ToInt32(Console.ReadLine());


            //Array.IndexOf devuelve 1 si el numero se encuentra en el array y -1 si no se encuentra.

            int position = Array.IndexOf(numeros, search);


            if (position > -1) // si el numero se encuentra en el array
            {
                Console.WriteLine("El numero se encuentra en la posicion: " + position);
            }
            else
            {
                Console.WriteLine("El numero no se encuentra en el array");

            }
        }
    }
}