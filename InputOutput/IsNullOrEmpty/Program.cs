namespace IsNullOrEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IsNullOrEmpty method

            Console.WriteLine($"Ingrese un dato o no:");
            string? str = Console.ReadLine();
            bool isValid;

            //if the strings is null or empty this method returns true else false.

            isValid = string.IsNullOrEmpty(str);

            if (isValid )
            {
                Console.WriteLine($"null or empty string.");
            }else
            {
                Console.WriteLine($"valid string.");
            }
        }
    }
}
