using System.Collections;
namespace ColasQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int count;
            Console.ForegroundColor = ConsoleColor.Red;
            Queue myQueue = new Queue();
            myQueue.Enqueue("uno");
            myQueue.Enqueue("dos");
            myQueue.Enqueue("tres");

            count = myQueue.Count;
            Console.WriteLine($"La cola tiene {count} elementos");



            for (int i = 0; i < count; i++)
            {
                word = (string)myQueue.Peek();
                Console.WriteLine("Siguiente palabra en la fila:" + word);
                word = (string)myQueue.Dequeue();
                Console.WriteLine($"Elemento {i}: {word}");
            }


            if (myQueue.Contains("tres"))
            {

                myQueue.Clear();
            }


            Console.WriteLine("Elementos en la pila: " + myQueue.Count);

        }
    }
    }
