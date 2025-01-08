namespace StringIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome";


            Console.WriteLine($"Primer caracter de la cadena {message.First()}");
            
            Console.WriteLine($"Tercer caracter de la cadena {message[2]}");
            Console.WriteLine($"Cuarto caracter de la cadena {message[4]}");

            Console.WriteLine($"Ultimo caracter de la cadena {message.Last()}");


            for ( int i = 0; i < message.Length; i++)
            {
                Console.WriteLine($"Indice: {i} - caracter : {message[i]} ");
                Thread.Sleep(100);
            }

            bool contains = false;
            for ( int i = 0;i < message.Length;i++)
            {
                if( message.Contains("is"))
                {
                    contains = true;
                    
                }
            }
            Console.WriteLine($"Contiene : {contains}");


        }
    }
}
