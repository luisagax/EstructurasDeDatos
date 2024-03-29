﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace PracticasED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PARCIAL I
            ArregloBidimensional2();
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
                decimal[] resultado = new decimal[5];
                decimal res = 0;
                string respuesta = "";
                Console.WriteLine("-- Suma de números --");
                //INSERTAR DATOS
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
                void sumatoria(decimal[] Ar1, decimal[] Ar2)
                {
                    int cons = 1;
                    for (int i = 0; i < Ar1.Length && i < Ar2.Length; i++)
                    {
                        decimal suma = Ar1[i] + Ar2[i];
                        resultado[i] = suma;
                        Console.WriteLine("{0}. {1} + {2} = {3}",cons, Ar1[i], Ar2[i], resultado[i]);
                        cons++;
                    }
                }
                sumatoria(a1, a2);
                //MODIFICA Y BUSCA DATOS
                decimal[] modificararreglos(decimal[] m, int index)
                {
                    Console.WriteLine("Ingrese la cantidad: ");
                    res = decimal.Parse(Console.ReadLine());
                    m[index] = res;
                    return m;
                }
                Console.WriteLine("Modificar cantidades. \n 1 = Si / 2 = No");
                respuesta = Console.ReadLine();
                if (respuesta == "1")
                {
                    Console.WriteLine("¿Qué dato quiere modificar?");
                    res = decimal.Parse(Console.ReadLine());
                    int posi = Array.IndexOf(a1, res);
                    int pos = Array.IndexOf(a2, res);
                    Console.Clear();
                    if (posi > -1)
                    {
                        a1 = modificararreglos(a1, posi);
                        sumatoria(a1, a2);
                    }
                    if (pos > -1)
                    {
                        sumatoria(a1, modificararreglos(a2, pos));
                    }
                }
                else
                    eliminararreglo();
                //ELIMINAR
                void eliminararreglo()
                {
                    //a1[0] = 0;
                    //ELIMINAR TODOS LOS DATOS DE UN ARREGLO
                    Array.Clear(a1, 0, 5);
                    Array.Clear(a2, 0, 5);
                }
                Console.ReadLine();
            }
            void ArregloBidimensional1()
            {
                int[,] Arreglo = new int[3, 4];
                //FILA 0
                Arreglo[0, 0] = 1; //COLUMNA 0
                Arreglo[0, 1] = 2; //COLUMNA 1
                Arreglo[0, 2] = 3; //COLUMNA 2
                Arreglo[0, 3] = 4; //COLUMNA 3
                //FILA 1
                Arreglo[1, 0] = 5;
                Arreglo[1, 1] = 6;
                Arreglo[1, 2] = 7;
                Arreglo[1, 3] = 8;
                //FILA 2
                Arreglo[2, 0] = 9;
                Arreglo[2, 1] = 10;
                Arreglo[2, 2] = 11;
                Arreglo[2, 3] = 12;

                for (int i = 0; i < 3; i++)
                {
                    for(int x = 0; x < 4; x++)
                    {
                        Console.WriteLine(Arreglo[i,x]);
                    }
                }
                Console.Read();
            }
            void ArregloBidimensional2()
            {
                string[,] Mandado = new string[4, 4];

                Mandado[0, 0] = "Lechuga";
                Mandado[0, 1] = "Leche";
                Mandado[0, 2] = "Tomate";
                Mandado[0, 3] = "Cebolla";

                Mandado[1, 0] = "10";
                Mandado[1, 1] = "15";
                Mandado[1, 2] = "20";
                Mandado[1, 3] = "22";

                Mandado[2, 0] = "2";
                Mandado[2, 1] = "3";
                Mandado[2, 2] = "3";
                Mandado[2, 3] = "3";

                for(int i = 0; i < 4; i++)
                {
                    if (i == 0)
                        Console.WriteLine("--- ARTICULOS ---");
                    else if (i == 1)
                        Console.WriteLine("--- PRECIO ---");
                    else if (i == 2)
                        Console.WriteLine("--- CANTIDAD ---");
                    else
                        Console.WriteLine("--- TOTAL ---");
                    for (int x = 0; x < 4; x++)
                    {
                        Console.WriteLine(Mandado[i, x]);
                    }
                }
                Console.Read();
            }
            #endregion
        }
    }
}
