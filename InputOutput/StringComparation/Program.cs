namespace StringComparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "Hello";


            if (str1.Equals(str2))
            {
                Console.WriteLine("Strings are the same.");
            }else
            {
                Console.WriteLine("Strings are diferent.");
            }

           

        }
    }
}
