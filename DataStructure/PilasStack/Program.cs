using System.Collections;
namespace PilasStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int count;

            Stack greeting = new Stack();

            greeting.Push("1 elemento en entrar");
            greeting.Push("2 elemento en entrar");
            greeting.Push("3 elemento en entrar");
            greeting.Push("4 elemento en entrar");
            greeting.Push("5 elemento en entrar");
            greeting.Push("6 elemento en entrar");

            count = greeting.Count;

            Console.WriteLine("Hay " + count + " elementos en la lista.");

            for (int i = 0; i < count; i++)
            {
                // Pop() elimina el último elemento de la pila y lo devuelve.
                word = (string)greeting.Pop();

                // Muestra el último elemento de la pila.
                Console.WriteLine(word);

            }

            Console.WriteLine("PEEK:");


            greeting.Push("1 elemento en entrar");
            greeting.Push("2 elemento en entrar");
            greeting.Push("3 elemento en entrar");
            greeting.Push("4 elemento en entrar");
            greeting.Push("5 elemento en entrar");
            greeting.Push("6 elemento en entrar");

            for (int i = 0; i < count; i++)
            {
                // PEEK() devuelve el último elemento de la pila sin eliminarlo.
                word = (string)greeting.Peek();
                Console.WriteLine("Siguiente palabra en la fila:"+ word);

                word = (string)greeting.Pop();

                // Muestra el último elemento de la pila.
                Console.WriteLine("Palabra eliminada: " + word);

            }

            //CONTAINS() devuelve true si el elemento está en la pila.

            Console.WriteLine("CONTAINS:");


            greeting.Push("1 elemento ");
            greeting.Push("2 elemento ");
            greeting.Push("3");
            greeting.Push("4 elemento ");
            greeting.Push("5 elemento ");
            greeting.Push("6 elemento ");

            if (greeting.Contains("3"))
            {
               
                greeting.Clear();
            }


            Console.WriteLine("Elementos en la pila: " + greeting.Count);

        }
    }
}
