﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE TO DO APP.");

            List<string> tasks = new List<string>();

            bool isValid = true;

            while (isValid)
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - Agregar tarea.");
                Console.WriteLine("2 - Borrar tarea.");
                Console.WriteLine("3 - Ver tarea.");
                Console.WriteLine("0 - Salir.");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        isValid = false;
                        break;
                    case 1:
                        Console.WriteLine("Ingrese la tarea a agregar:");
                        string? task = Console.ReadLine();
                        if (!string.IsNullOrEmpty(task))
                        {
                            tasks.Add(task);
                            Console.WriteLine("Tarea agregada!");
                        }
                        else
                        {
                            Console.WriteLine("La tarea no puede estar vacía.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la tarea a borrar:");
                        string? taskToDelete = Console.ReadLine();
                        if (!string.IsNullOrEmpty(taskToDelete))
                        {
                            tasks.Remove(taskToDelete);
                            Console.WriteLine("Tarea borrada!");
                        }
                        else
                        {
                            Console.WriteLine("La tarea no puede estar vacía.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Tareas:");
                       
                        for(int i = 0;i < tasks.Count; i++)
                        {
                            Console.WriteLine(i + " - " + tasks[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}