using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarea
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
            cantidad=int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"Total a pagar: {cantidad * precio}");
            } else
            if (cantidad >= 2 && cantidad <=5)
            {
                total = (cantidad *precio) * 0.15f; //15 por ciento
                total = (cantidad * precio) - total; 
                Console.WriteLine($"Total a pagar: {total} con descuento del 15%");
            } else
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


            Console.WriteLine("Si lleva menos de 10 productos el precio sera de 20 dolares por artiuclo si lleva mas de 10 el precio serade 15 dolares por producto");
            Console.WriteLine("Digite la cantidad de productos que llevara");
            cantidad = int.Parse(Console.ReadLine());
            

            if (cantidad >= 10)
            {
                total = cantidad * 20;
                Console.WriteLine($"Total a pagar: {total}");
            }else
            
            if (cantidad <10)
            {
                total = cantidad * 15;
                Console.WriteLine($"Total a pagar: {total}");
            }
            
      
        }
    }
        public static void Ejercicio3()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            while (true)
            {
                string nombre = "";
                int carnet = 0;
                float[] quiz = new float[3];
                float[] tarea = new float[3];
                float[] examen = new float[3];
                float notaFinal = 0f;

                Console.WriteLine("Digite el carnet del estudiante (o -1 para salir):");
                carnet = int.Parse(Console.ReadLine());

            if (carnet == -1)
            {
                break; // Salir del bucle si se ingresa -1
            }

                Console.WriteLine("Digite el nombre del estudiante:");
                nombre = Console.ReadLine();

            for (int i = 0; i < quiz.Length; i++)
            {
                Console.WriteLine($"Digite la nota del Quiz {i + 1}:");
                quiz[i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tarea.Length; i++)
            {
                Console.WriteLine($"Digite la nota de la Tarea {i + 1}:");
                tarea[i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < examen.Length; i++)
            {
                Console.WriteLine($"Digite la nota del Examen {i + 1}:");
                examen[i] = float.Parse(Console.ReadLine());
            }

            // Calculamos la nota final del estudiante
            float notaQuices = quiz.Sum();
            float notaTareas = tarea.Sum();
            float notaExamenes = examen.Sum();
            notaFinal = (notaQuices * 0.25f) + (notaTareas * 0.30f) + (notaExamenes * 0.45f);

            // Verificamos si el estudiante aprobó o reprobó
            string estado = (notaFinal >= 70) ? "Aprobó" : "Reprobó";

            // Imprimimos las notas obtenidas y el porcentaje
            Console.WriteLine($"Notas obtenidas:\nQuices: {notaQuices}\nTareas: {notaTareas}\nExamenes: {notaExamenes}");
            Console.WriteLine($"Porcentaje obtenido: {notaFinal}%");
            Console.WriteLine($"Resultado: {estado}");

            // Agregamos el estudiante a la lista
            estudiantes.Add(new Estudiante(carnet, nombre, quiz, tarea, examen, notaFinal, estado));
        }

        // Mostramos los datos de todos los estudiantes ingresados
        Console.WriteLine("Datos de los estudiantes ingresados:");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Carnet: {estudiante.Carnet}");
            Console.WriteLine($"Nombre: {estudiante.Nombre}");
            Console.WriteLine($"Nota Final: {estudiante.NotaFinal}");
            Console.WriteLine($"Resultado: {estudiante.Estado}\n");
        }
    }




    static void Main(string[] args)
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
    }while (opcion != 4);

