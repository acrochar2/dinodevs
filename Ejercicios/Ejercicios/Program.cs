using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ClaseMetodos = new Class1();

            Console.Write("Elija una opcion\n");
            Paint(ListaOpciones());

            string opcion = Console.ReadLine();
            switch (opcion)
            {

                case "1":
                    {
                        Paint(ClaseMetodos.EjercicioUno());
                        break;
                    }
                case "2":
                    {
                        Paint(ClaseMetodos.EjercicioDos());
                        break;
                    }
                case "3":
                    {
                        Paint(ClaseMetodos.EjercicioTres());
                        break;
                    }
                case "4":
                    {
                        Paint(ClaseMetodos.EjercicioCuatro());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opcion No valida");
                        Console.Read();
                        break;
                    }
                    

        }
        }

        public static IEnumerable<string> ListaOpciones()
        {
            yield return "1 - Devuelve lista infinita de numeros";
            yield return "2 - Devuelve lista infinita de numeros pares";
            yield return "3 - Devuelve lista infinita de numeros multiplos de 3 o 5";
            yield return "4 - Devuelve lista infinita de strings";
        }
        
        public static void Paint(IEnumerable<string> ui)
        {
            foreach (var line in ui)
            {
                Console.WriteLine(line);
            }
        }

        public static void Paint(IEnumerable<int> ui)
        {
            foreach (var line in ui)
            {
                Console.WriteLine(line);
            }
        }
    }
}

