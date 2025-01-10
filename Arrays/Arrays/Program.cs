namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays


            //Formas de declaracion.

            int[] array = { 1, 2, 3 };//
            int[] array2 = new int[] { 1, 2,3 };
            int[] array3 = [1,2,3,4];
            int[] array4 = new int[4] {1,2,3,4};
            int[] array5 = new int[5];


            //CARGA DE ARRAY DE ENTEROS
            for (int i = 0; i < array5.Length; i++)
            {
                Console.WriteLine("Ingrese un entero:");

                while (!int.TryParse(Console.ReadLine(), out  array5[i]))
                {
                    Console.WriteLine("No valido");
                }

            }

            for (int i = 0;i < array5.Length; i++)
            {
                Console.WriteLine($"Indice {i}: {array5[i]}");
            }



            //CARGA DE ARRAY DE STRINGS
            string[] arregloCadena = new string[3];

            for (int i = 0;i <arregloCadena.Length;i++)
            {
                Console.WriteLine("Ingresa una palabra:");
                arregloCadena[i]= Console.ReadLine();
            }

            for(int i = 0; i < arregloCadena.Length; i++)
            {
                Console.WriteLine("Cadena: " + i + arregloCadena[i]);
            }

        }
    }
}
