namespace StringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  String literal or string interpolation

            string path = "C:\\Users\\benit\\Downloads\\PKO";
            Console.WriteLine(path);

            string pathWellDeclared = @"C:\\Users\\benit\\Downloads\\PKO";
            Console.WriteLine(pathWellDeclared);
        }
    }
}
