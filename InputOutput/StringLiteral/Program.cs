namespace StringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  String literal , string interpolation

            string path = "C:\\Users\\benit\\Downloads\\PKO";
            Console.WriteLine(path);

            string pathWellDeclared = @"C:\\Users\\benit\\Downloads\\PKO";
            Console.WriteLine(pathWellDeclared);

            string name = "Emanuel";

            int age = 35;

            Console.WriteLine("Your name is " + name + ", and you are " + age);
            Console.WriteLine("Your name is {0}, and you are {1}" , name , age);

            Console.WriteLine($"Your name is {name}, and you are {age}.");

        }
    }
}
