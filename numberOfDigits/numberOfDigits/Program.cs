
namespace numberOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numberOfDigits(11);
        }

        private static void numberOfDigits(int number)
        {

            int numer;


           


            if (number > 0 && number < 10)
            {
                Console.WriteLine("Numero de un digito");
            }
            else if (number >= 10 && number < 100)
            {
                Console.WriteLine("Numero de dos digitos");

            }
            else
            {
                Console.WriteLine("Numero tiene 3 digitos");
            }

        }
    }
}
