


namespace PracticaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mostrarMensaje();
            int resultado =  sumar(5, 6);
            mostrarMensaje(resultado);
        }

        private static void mostrarMensaje(int resultado)
        {
            Console.WriteLine(resultado);
        }

        private static int sumar(int v1, int v2)
        {
            return v1 + v2;
        }

        private static void mostrarMensaje()
        {
            Console.WriteLine("Hola mundo");
        }
    }
}
