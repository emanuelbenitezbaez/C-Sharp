namespace IsNullOrEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IsNullOrEmpty method

            string? str;
            bool isValid;

            str = "dato";
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
