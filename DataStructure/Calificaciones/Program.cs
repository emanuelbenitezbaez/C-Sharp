

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una aplicación de consola que solicite las calificaciones de una lista predefinida de estudiantes
            //y posteriormente muestre dicha lista ordenada ascendentemente por nombre de estudiante.

            string[] studentNames = { "Juan", "Pedro", "María", "José", "Ana" };

            SortedList<string, int> calificaciones = new SortedList<string, int>();

           
            getCals(studentNames, calificaciones);

            orderedCals(calificaciones);

            showCals(calificaciones);


        }

        private static void getCals(string[] studentNames, SortedList<string, int> calificaciones)
        {
            int score = 0;

            foreach (var item in studentNames)
            {
                score = 0;
                while (score == 0)
                {
                    Console.WriteLine($"\nProporciona la calificación de {item}");
                    GetInteger(Console.ReadLine(), out score);
                    calificaciones.Add(item, score);
                }


            }
        }

        private static void showCals(SortedList<string, int> calificaciones)
        {
            foreach (var item in calificaciones)
            {
                Console.WriteLine($"Nombre: {item.Key} Calificación: {item.Value}");
            }
        }

        private static void orderedCals(SortedList<string, int> calificaciones)
        {
            var calificacionesOrdenadas = calificaciones.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        private static void GetInteger(string? data, out int score)
        {
            if (!int.TryParse(data, out score))
            {
                Console.WriteLine("El dato debe ser entero");
            }
        }
    }
    }

