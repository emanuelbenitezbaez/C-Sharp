namespace ConversionDeTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversiones implicitas
            /*
             La conversión implícita ocurre automáticamente cuando no hay riesgo de pérdida de información,
            y el compilador puede realizar la conversión de manera segura.
            Esto suele suceder con conversiones entre tipos que son compatibles y
            donde el rango del tipo de destino puede contener el rango del tipo de origen.
             */
            int numInt = 123;
            double numDouble = numInt; // Conversión implícita de int a double
            Console.WriteLine($"Conversión implícita de int a double{numDouble}");

            //Conversiones explícitas

            /*
             La conversión explícita requiere que el programador indique de manera directa que desea realizar la conversión.
            Esto es necesario cuando puede haber una pérdida de información o cuando el compilador no puede garantizar que
            la conversión sea segura. Para hacer una conversión explícita, se utiliza la sintaxis de casting (tipo).
             */

            double numDoble = 123.45;
            int numInteger = (int)numDoble; // Conversión explícita de double a int

            Console.WriteLine($"Conversión explícita de double a int{numInteger}");


            string strNum = "123";
            int num;
            bool success = int.TryParse(strNum, out num);

            if (success)
            {
                Console.WriteLine("Conversión exitosa: " + num);
            }
            else
            {
                Console.WriteLine("Conversión fallida");
            }

            


        }
    }
}
