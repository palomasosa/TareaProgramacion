using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPrgrm2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Primer ejercicio
            //string palabra;

            //Queue<string> colaPalabras = new Queue<string>();
            //palabra = Console.ReadLine();

            //while (palabra != "")
            //{
            //    colaPalabras.Enqueue(palabra);
            //    Console.WriteLine("Ingrese la proxima palabra");
            //    palabra = Console.ReadLine();
            //}
            //while (colaPalabras.Count > 0)
            //{ 
            //    Console.WriteLine(colaPalabras.Dequeue());
            //}

            //Console.ReadKey();
            #endregion

            #region Segundo ejercicio 
            //string palabra;

            //Stack<string> colaPalabras = new Stack<string>();
            //palabra = Console.ReadLine();

            //while (palabra != "")
            //{
            //    colaPalabras.Push(palabra);
            //    Console.WriteLine("Ingrese la proxima palabra");
            //    palabra = Console.ReadLine();
            //}
            //while (colaPalabras.Count > 0)
            //{
            //    Console.WriteLine(colaPalabras.Pop());
            //}

            //Console.ReadKey();

            #endregion

            #region Tercer ejercicio

            string palabra;
            int numero;
            List<string> Lista = new List<string>();
            palabra = Console.ReadLine();


            while (palabra != "")
            {
                Lista.Add(palabra);
                Console.WriteLine("Ingrese la proxima palabra");
                palabra = Console.ReadLine();
            }
            Console.WriteLine("Ingrese la posición de la palabra que desea");

            numero = Convert.ToInt32(Console.ReadLine());
            while (numero != 0)
            {
                if (numero > Lista.Count())
                {
                    Console.WriteLine("No hay datos en esta posicion, ingrese otra posicion");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                numero--;
                Console.WriteLine(Lista[numero]);
                numero = Convert.ToInt32(Console.ReadLine());
                }

            }

            #endregion
        }
    }
}
