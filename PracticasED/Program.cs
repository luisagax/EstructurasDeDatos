using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticasED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arreglo5();
            #region PARCIAL I
            void Arreglo1()
            {
                int[] A = new int[5];

                A[0] = 1;
                A[1] = 2;
                A[2] = 3;
                A[3] = 4;
                A[4] = 5;

                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine(A[i]);
                }

                Console.ReadKey();
            }
            void Arreglo2()
            {
                string[] C = new string[5];

                C[0] = "1 - uno";
                C[1] = "2 - dos";
                C[2] = "3 - tres";
                C[3] = "4 - cuatro";
                C[4] = "5 - cinco";

                for (int i = 0; i < C.Length; i++)
                    Console.WriteLine(C[i]);

                Console.Read();
            }
            void Arreglo3()
            {
                string[] S = new string[5];
                string res = "";
                int o = 1;

                for(int i = 0; i < S.Length; i++)
                {
                    Console.WriteLine("Ingresa los nombres del {0} alumnos: ", o);
                    res = Console.ReadLine();
                    S[i] = res;
                    o++;
                }
                Console.Clear();
                for (int x = 0; x < S.Length; x++)
                    Console.WriteLine("Los alumnos son: {0}", S[x]);
                Console.ReadLine();
            }
            void Arreglo4()
            {
                string[] ListaCompras = new string[5];
                string Articulo = "";
                int cons = 1;
                Console.WriteLine("Ingresa los articulos a la lista:");
                for (int i = 0; i < ListaCompras.Length; i++)
                {
                    Console.WriteLine("Articulo #{0}", cons);
                    Articulo = Console.ReadLine();
                    ListaCompras[i] = Articulo;
                    cons++;
                }
                Console.Clear();
                for (int o = 0; o < ListaCompras.Length; o++)
                    Console.WriteLine(ListaCompras[o]);
                Console.Read();
            }
            void Arreglo5()
            {
                decimal[] a1 = new decimal[5];
                decimal[] a2 = new decimal[5];
                decimal res = 0;
                Console.WriteLine("-- Suma de números --");
                for(int i = 0; i < a1.Length && i < a2.Length; i++)
                {
                    Console.WriteLine("Vuelta #{0}", i);
                    //Arreglo 1
                    Console.WriteLine("Ingresa el valor del #1: ");
                    res = decimal.Parse(Console.ReadLine());
                    a1[i] = res;
                    //Arreglo 2
                    Console.WriteLine("Ingresa el valor del #2: ");
                    res = decimal.Parse(Console.ReadLine());
                    a2[i] = res;
                    Console.Clear();
                }
                for(int i = 0; i < a1.Length && i < a2.Length; i++)
                {
                    decimal suma = a1[i] + a2[i];
                    Console.WriteLine("{0} + {1} = {2}",a1[i], a2[i], suma);
                }
                Console.ReadLine();
            }
            #endregion
        }
    }
}
