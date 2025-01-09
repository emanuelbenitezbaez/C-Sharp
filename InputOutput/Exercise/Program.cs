namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user to imput a message
            //Print in order
            //Print in reverse

            Console.WriteLine("Ingresa una palabra o mensaje:");
            string? message = Console.ReadLine();

            Console.WriteLine("Mensaje en orden:");
            for (int i = 0;i < message.Length; i++)
            {
                Console.Write(message[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Mensaje en reversa:");

            //i = message.Length indica donde comienza el  bucle. En este caso es indice - 1 lo cual lo posiciona al final.
            for(int i = message.Length - 1; i >= 0; i--)// mientras el indice sea mayor a 0 hago el decremento i--.
            {
                Console.Write(message[i]);
            }

        }
    }
}
