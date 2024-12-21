
namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un array de 5 números enteros y mostrar sus elementos en consola.
            //DECLARACION DE UN ARRAY 1 FORMA
            Console.ForegroundColor = ConsoleColor.Red;
            int[] array = new int[3];
            array[0] = 100;
            array[1] = 200;
            array[2] = 300;
            Console.WriteLine($"\narray[0]:{array[0]} \narray[1]{array[1]} \narray[2]:{array[2]}");



            //DECLARACION DE UN ARRAY 2 FORMA
            Console.ForegroundColor = ConsoleColor.Blue;
            int[] array1 = { 1, 2, 3, 4, 5 };
            string[] arrayString = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };


            foreach (int item in array1)
            {
                Console.WriteLine(item);
            }


            foreach (string item in arrayString)
            {
                Console.WriteLine(item);
            }



            //DECLARACION DE UN ARRAY 3 FORMA
            Console.ForegroundColor = ConsoleColor.Green;
            double[] array2;
            array2 = new double[] { 101.040, 201.066, 311.016, 411.026, 544.450 };

            Console.WriteLine($"\narray[0]: {array2[0]:F2} \narray[1]: {array2[1]:F2} \narray[2]: {array2[2]:F2}\narray[3]: {array2[3]:F2} \narray[4]: {array2[4]:F2}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (double item in array2)
            {
                Console.WriteLine(item);
            }

            //MATRICES: ARRAY CUYO CONTENIDO O ELEMENTOS ES OTRO ARRAY.

            //MATRIZ DECLARACION COMUN .
            Console.ForegroundColor = ConsoleColor.Yellow;

            int[,] matriz = new int[3,3];
            int likes = 1;

            for (int i = 0;i < 3; i++)
            {
                for(int j =0; j<3; j++)
                {
                    matriz[i, j] = likes;
                    likes++;
                    Console.WriteLine("X: " + matriz[i, j] );

                }
            }



            // MATRIZ DECLARACION JAGGED(DENTADAS)EN CADA FILA PUEDE VARIAR EL VALOR DE LAS COLUMNAS.

            int[][] matrizJagged = new int[4][];
            matrizJagged[0] = new int[] {1};
            matrizJagged[1] = new int[] {2,3,4 };
            matrizJagged[2] = new int[] { 5, 6, 7, 8, 9 };
            matrizJagged[3] = new int[] { 10, 11, 12, 13, 14, 15 };

            foreach (int[] item in matrizJagged)
            {
                foreach (int item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }


            Console.ForegroundColor = ConsoleColor.Magenta;
            int[][] matrizJagged1 = new int[4][];
            int contador = 1; // Iniciamos el contador en 1

            // Inicializamos cada fila y asignamos valores autoincrementados
            for (int i = 0; i < matrizJagged1.Length; i++)
            {
                // Supongamos que queremos que cada fila tenga un tamaño aleatorio
                int tamañoFila = new Random().Next(1, 5);
                matrizJagged1[i] = new int[tamañoFila];

                for (int j = 0; j < matrizJagged1[i].Length; j++)
                {
                    matrizJagged1[i][j] = contador++;
                }
            }

            // Imprimimos la matriz para verificar los valores
            foreach (int[] fila in matrizJagged1)
            {
                foreach (int valor in fila)
                {
                    Console.Write(valor + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
