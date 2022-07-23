using System;
using System.Collections.Generic;

namespace clase
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int op1 = 1;
            MainClass clase = new MainClass();
            List<string> nombres = new List<string>();
            do
            {
                Console.WriteLine("Elige una opción: ");
                Console.WriteLine("1. Ingresar nombres: ");
                Console.WriteLine("2. Ingresa un nombre y te digo si existe: ");
                Console.WriteLine("3. Cambiar un nombre por una X: ");
                Console.WriteLine("4. Imrimir los nombres en una linea: ");
                Console.WriteLine("5. Salir, terminar programa: ");
                int op2 = int.Parse(Console.ReadLine());
                switch (op2)
                {
                    case 1:
                        Console.Clear();
                        clase.ingresarNombres(nombres);
                        break;
                    case 2:
                        Console.Clear();
                        clase.buscarNombre(nombres);
                        break;
                    case 3:
                        Console.Clear();
                        clase.reemplazarNombre(nombres);
                        break;
                    case 4:
                        Console.Clear();
                        clase.imprimirNombres(nombres);
                        break;
                    default:
                        Console.WriteLine("Cerrando programa... ADIOS!!");
                        System.Environment.Exit(0);
                        break;
                }

                Console.WriteLine("¿Quieres hacer otra cosa? ");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No, terminar programa");
                op1 = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (op1 == 1);
        }

        public void ingresarNombres(List<string> nombres)
        {
            Console.WriteLine("Cuantos nombres vamos a ingresar: ");
            int numNombres = int.Parse(Console.ReadLine());

            for (int i = 0; i < numNombres; i++)
            {
                Console.WriteLine("Ingresa el nombre " + (i+1) + ": ");
                nombres.Add(Console.ReadLine());
            }
        }

        public void buscarNombre(List<string> nombres)
        {
            Console.WriteLine("Ingresa el nombre a buscar: ");
            string nombreABuscar = Console.ReadLine();

            bool isExist = nombres.Contains(nombreABuscar);
            if(isExist)
            {
                Console.WriteLine("Nombre " + nombreABuscar + " encontrado");
            } else
            {
                Console.WriteLine("Nombre " + nombreABuscar + " NO encontrado");
            }
        }

        public void reemplazarNombre(List<string> nombres)
        {
            Console.WriteLine("Ingresa el nombre a buscar: ");
            string nombreAReemplazar = Console.ReadLine();

            int index = nombres.FindIndex(nombre => nombre == nombreAReemplazar);

            if (index != -1)
            {
                nombres[index] = "X";
            } else
            {
                Console.WriteLine("Nombre " + nombreAReemplazar + " NO encontrado");
            }
        }

        public void imprimirNombres(List<string> nombres)
        {
            string[] nombresArray = nombres.ToArray();
            string nombresAImprimir = string.Join(", ", nombresArray);
            Console.WriteLine("Nombres: " + nombresAImprimir);
        }
    }
}
