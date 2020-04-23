using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7N
{
    public class Class1
    {

        Random r = new Random(); 
        protected const int mingen = 0; 
        protected const int maxgen = 255; 

        public void ArrayOut(int[, ,] mass)
        {

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    for (int k = 0; k < mass.GetLength(2); k++)
                    {
                        Console.Write(String.Format("{0,5}", mass[i, j, k]));
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }

        
        public int[, ,] ArrayGen()  //случайный массив
        {
            int[, ,] arrayres = new int[5, 5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        arrayres[i, j, k] = r.Next(Class1.mingen, Class1.maxgen);
                    }
                }
            }
            return arrayres;
        }


        public int[, ,] ArraySum(int[, ,] arr1, int[, ,] arr2)  //сложение массивов
        {
            int[, ,] arrayres = new int[5, 5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        arrayres[i, j, k] = arr1[i, j, k] + arr2[i, j, k];
                    }
                }
            }
            return arrayres;
        }


        public int[, ,] ArrayDif(int[, ,] arr1, int[, ,] arr2)  //вычитание массивов
        {
            int[, ,] arrayres = new int[5, 5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        arrayres[i, j, k] = arr1[i, j, k] - arr2[i, j, k];
                    }
                }
            }
            return arrayres;
        }


        public int[, ,] ArrayMul(int[, ,] arr1, int num)  //умножение массива
        {
            int[, ,] arrayres = new int[5, 5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        arrayres[i, j, k] = arr1[i, j, k] * num;
                    }
                }
            }
            return arrayres;
        }


        public int ArrayFin(int[, ,] arr1)  //суммa массива
        {
            int arr = 0; 

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    for (int k = 0; k < arr1.GetLength(2); k++)
                    {
                        arr += arr1[i, j, k];
                    }
                }
            }
            return arr;
        }
    }
}