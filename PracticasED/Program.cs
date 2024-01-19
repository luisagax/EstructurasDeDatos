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
            Arreglo3();
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
            #endregion
        }
    }
}
