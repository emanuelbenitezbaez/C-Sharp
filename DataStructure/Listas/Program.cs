using System.Collections;
namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            //INICIALIZACION DE UNA LISTA DE CADENAS VACIA
            List<string> lista = new List<string>();

            lista.Add("Hola");
            lista.Add("Mundo");
            lista.Add("!");

            Console.WriteLine("Cantidad de elementos actuales en la lista: " + lista.Count);

            showListContain(lista);

            //VALIDAMOS SI EXISTE UN ELEMENTO EN LA LISTA
            if (lista.Contains("Hola"))
            {
                lista.Remove("Hola");
                Console.WriteLine("Se removio el elemento ´Hola´");
            }
            Console.WriteLine("Elementos restantes en la lista: " + lista.Count);

            //VALIDAMOS SI EXISTE UN ELEMENTO EN LA LISTA Y LO AGREGAMOS
            if (!lista.Contains("Hola"))
            {
                lista.Insert(0,"Hola");
                Console.WriteLine("Se agrego el elemento ´Hola´");
            }

            Console.WriteLine("Elementos restantes en la lista: "+lista.Count);

            //INSERTAR UNA LISTA DENTRO DE OTRA

            //INICIALIZACION DE UNA LISTA DE ENTEROS
            List<int> list1 = new List<int>() { 123, 124, 345, 566, 789 };
            List<int> list2 = new List<int>() { 1123, 1124, 1345, 1566, 1789 };

            //INSERTAMOS LA LISTA DE ENTEROS DENTRO DE LA LISTA DE CADENAS
            list1.InsertRange(0,list2);
            showIntListContain(list1);

            //
            Console.WriteLine("Elementos restantes en la lista: " + list1.Count);


        }

        private static void showIntListContain(List<int> list1)
        {
            foreach (int item in list1)
            {
                Console.WriteLine(item);
            }
        }

        private static void showListContain(List<string> lista)
        {
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

           
        }
    }
}
