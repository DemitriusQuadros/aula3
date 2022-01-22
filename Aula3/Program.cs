using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int[] arrayDeInteiros = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };

            //for (int i = 0; i < arrayDeInteiros.Length; i++)
            //{
            //    Console.WriteLine(arrayDeInteiros[i]);
            //}

            SortearLotofacil();

            //int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //Console.WriteLine(array2D[1, 1]);

            //int[,,] array3D = new int[,,] { { { 1, 2, 3 } }, { { 4, 5, 6 } } };

            //Console.WriteLine(array3D[0, 0, 1]);
        }
        //01,03, 05, 06, ,10, 11, 13, 16
        //18,19,20,21,22,24,25
        public static void SortearLotofacil()
        {

            List<int> numeros = new List<int>();

            for (int i = 0; i <= 14; i++)
            {
                var numeroSorteado = new Random().Next(1, 25);
                while (VerificaExiste(numeroSorteado, numeros))
                {
                    numeroSorteado = new Random().Next(1, 25);
                }
                numeros.Add(numeroSorteado);
            }

            foreach (var numero in numeros.OrderBy(numero => numero))
            {
                Console.WriteLine(numero);
            }
        }

        private static bool VerificaExiste(int numeroSorteado, List<int> numeros)
        {
            foreach (var numero in numeros)
            {
                if (numero == numeroSorteado)
                    return true;
            }
            return false;
        }
    }
}
