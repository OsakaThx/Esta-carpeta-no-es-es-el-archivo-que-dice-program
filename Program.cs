using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_corregida
{
    internal class Program
    {
        public static void Ejercicio1()
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("Cual es el precio de la camisa");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"Total a pagar: {cantidad * precio}");
            }
            else
            if (cantidad >= 2 && cantidad <= 5)
            {
                total = (cantidad * precio) * 0.15f; //15 por ciento
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar: {total} con descuento del 15%");
            }
            else
            if (cantidad >= 6)
            {
                total = (cantidad * precio) * 0.20f; //15 por ciento
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar: {total} con descuento del 20%");
            }
        }

        public static void Ejercicio2()
        {

            int cantidad = 0;
            float total = 0f;


            Console.WriteLine("Si lleva menos de 10 productos el precio sera de 20 dolares por artiuclo si lleva mas de 10 el precio sera de 15 dolares por producto");
            Console.WriteLine("Digite la cantidad de productos que llevara");
            cantidad = int.Parse(Console.ReadLine());


            if (cantidad >= 10)
            {
                total = cantidad * 20;
                Console.WriteLine($"Total a pagar: {total}");
            }
            else

            if (cantidad < 10)
            {
                total = cantidad * 15;
                Console.WriteLine($"Total a pagar: {total}");
            }


        }

        public static void Ejercicio3()
        {
            // Solicitar el nombre y el carnet del usuario
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su carnet: ");
            string carnet = Console.ReadLine();

            // Inicializar variables para las notas y promedios
            double sumaQuiz = 0;
            double sumaTarea = 0;
            double sumaExamen = 0;

            // Solicitar las notas de los quizzes
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Ingrese la nota del Quiz {i}: ");
                double notaQuiz = Convert.ToDouble(Console.ReadLine());
                sumaQuiz += notaQuiz;
            }

            // Solicitar las notas de las tareas
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Ingrese la nota de la Tarea {i}: ");
                double notaTarea = Convert.ToDouble(Console.ReadLine());
                sumaTarea += notaTarea;
            }

            // Solicitar las notas de los exámenes
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Ingrese la nota del Examen {i}: ");
                double notaExamen = Convert.ToDouble(Console.ReadLine());
                sumaExamen += notaExamen;
            }

            // Calcular promedios
            double promedioQuiz = sumaQuiz / 3;
            double promedioTarea = sumaTarea / 3;
            double promedioExamen = sumaExamen / 3;

            // Mostrar los resultados de los promedios individuales
            Console.WriteLine("\nResultados:");
            Console.WriteLine("--------------");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Carnet: {carnet}");
            Console.WriteLine($"Promedio de Quizzes: {promedioQuiz:F2}");
            Console.WriteLine($"Promedio de Tareas: {promedioTarea:F2}");
            Console.WriteLine($"Promedio de Exámenes: {promedioExamen:F2}");

            // Calcular el promedio total
            double promedioTotal = (promedioQuiz + promedioTarea + promedioExamen) / 3;

            // Mostrar el resultado del promedio total y si aprobó o no
            Console.WriteLine($"\nPromedio Total: {promedioTotal:F2}");
            if (promedioTotal > 70)
            {
                Console.WriteLine("¡Aprobado!");
            }
            else
            {
                Console.WriteLine("Desaprobado");
            }

            Console.ReadLine(); // Esperar a que el usuario presione Enter antes de salir
        }

            public static void Main(string[] args)
            {
                int opcion = 0;

                do
                {
                    Console.WriteLine("1- Ejercicio 1");
                    Console.WriteLine("2- Ejercicio 2");
                    Console.WriteLine("3- Ejercicio 3");
                    Console.WriteLine("4- Salir");
                    Console.WriteLine("Digite una opción:");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Ejercicio1();
                            break;

                        case 2:
                            Console.Clear();
                            Ejercicio2();
                            break;

                        case 3:
                            Console.Clear();
                            Ejercicio3();
                            break;

                        case 4:
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                            break;
                    }
                } while (opcion != 4);
            }
        }
    }

