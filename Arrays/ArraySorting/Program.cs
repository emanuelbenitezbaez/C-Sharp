namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 3, 8, 2, 1, 4, 6, 7 };


            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            foreach (int number in numbers)
            {
                System.Console.Write(number + " ");
            }


            Console.WriteLine();

            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Array.Sort(arr);
            Console.WriteLine("Arreglo ordenado:");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
            Array.Reverse(arr);
            Console.WriteLine("Arreglo reverse:");

            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}
