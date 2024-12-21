using System.Collections;
namespace OtrasEstructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


            //HashSet es una estructura de datos que no permite duplicados.
            HashSet<int> hashSetInt = new HashSet<int>();
            hashSetInt.Add(1);
            hashSetInt.Add(2);
            hashSetInt.Add(3);

            //No se agrega porque ya existe
            hashSetInt.Add(1);

            HashSet<string> hashSetString = new HashSet<string>();

            hashSetString.Add("cadena1");
            hashSetString.Add("cadena2");
            hashSetString.Add("cadena3");
            hashSetString.Add("cadena4");
            //No se agrega porque ya existe
            hashSetString.Add("cadena1");


            //Recorrer un HashSet e imprimir sus elementos
            foreach (string item in hashSetString)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
            }

            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(3);
            sortedSet.Add(1);
            sortedSet.Add(2);
            sortedSet.Add(4);
            sortedSet.Add(5);

            //Recorrer un SortedSet e imprimir sus elementos
            foreach (int item in sortedSet)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item);
            }


            //Dictionary es una estructura de datos que permite almacenar pares de clave-valor
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "uno");
            diccionario.Add(2, "dos");
            diccionario.Add(3, "tres");




        }
    }
}
