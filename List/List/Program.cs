namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("World");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

           

            List<int> list2 = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Agrega un numero:");
                list2.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine($"Numeros agregados:");

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

        }

      
    }
}
