using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using B7N;

namespace B7NTests
{
    [TestClass]
    public class Class1Tests
    {
        //Проверка на успешное создание массива случайных числел
        [TestMethod]
        public void ArrayGenTest()
        {
            var otv = false;
            Class1 t = new Class1();
            var res = t.ArrayGen();
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    for (int k = 0; k < res.GetLength(2); k++)
                    {
                        otv = true;
                    }
                }
            }
            Assert.IsTrue(otv);
        }

        //Проверка на правильность сложения массивов случайных числел
        [TestMethod]
        public void ArraySumTest()
        {
            Class1 t = new Class1();
            int[, ,] arr1 = t.ArrayGen();
            int[, ,] arr2 = t.ArrayGen();
            var otv = false;
            int[, ,] actual = t.ArraySum(arr1, arr2);

            for (int i = 0; i < actual.GetLength(0); i++)
            {
                for (int j = 0; j < actual.GetLength(1); j++)
                {
                    for (int k = 0; k < actual.GetLength(2); k++)
                    {
                        if (actual[i, j, k] == arr1[i, j, k] + arr2[i, j, k])
                        {
                            otv = true;
                        }
                    }
                }
            }

            Assert.IsTrue(otv);
        }

        
        [TestMethod]
        public void TestMultiplicationArrays()  //проверка умножения массива на число
        {
            Class1 t = new Class1();
            var num = 3;
            int[, ,] arr1 = t.ArrayGen();
            var otv = false;
            int[, ,] res = t.ArrayMul(arr1, num);

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    for (int k = 0; k < res.GetLength(2); k++)
                    {
                        if (res[i, j, k] == arr1[i, j, k] * num)
                        {
                            otv = true;
                        }
                    }
                }
            }
            Assert.IsTrue(otv);
        }
        
        [TestMethod]
        public void ArrayDifTest()  //проверка вычитания массивов
        {
            Class1 t = new Class1();
            var otv = false;
            int[, ,] arr1 = t.ArrayGen();
            int[, ,] arr2 = t.ArrayGen();

            int[, ,] res = t.ArrayDif(arr1, arr2);

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    for (int k = 0; k < res.GetLength(2); k++)
                    {
                        if (res[i, j, k] == arr1[i, j, k] - arr2[i, j, k])
                        {
                            otv = true;
                        }
                    }
                }
            }
            Assert.IsTrue(otv);
        }

        
        [TestMethod]
        public void ArrayFinTest()  //проверка сравнения суммы массивов
        {
            Class1 t = new Class1();
            var num = 0;

            int[, ,] arr1 = t.ArrayGen();

            var res = t.ArrayFin(arr1);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        num += arr1[i, j, k];
                    }
                }
            }
            Assert.AreEqual(num, res);

        }
    }
}
