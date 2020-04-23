using System;
using B6N;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B6N
{
    [TestClass]
    public class Class1Tests
    {
        
        [TestMethod]
        public void GetterSetter()
        {
            // arrange
            var age = 14; 
            var expected = 14;
            Class1 gym = new Class1(age); 
            // act
            int actual = gym.Age; 
            // assert
            Assert.AreEqual(expected, actual); 
        }


        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Age is out of range")]
        public void TestGetterAndSetterThrows()
        {
            int age = 71;
            Class1 gym = new Class1(age);

        }
        
        [TestMethod]
        public void TestMain()
        {
            // arrange
            int age1 = 20;
            int age2 = 25;

            Class1 gym = new Class1(age1);
            gym = new Class1(age2);

            var otv1 = 14; //мин возраст ответ
            var otv2 = 25; //макс возраст ответ
            var otv3 = 19.7; //средний возраст ответ
            // act
            gym.Main();
            var res1 = gym.MinAgeClient; //мин возраст результат
            var res2 = gym.MaxAgeClient; //макс возраст результат
            var res3 = gym.Srpos;  //средний возраст результат
            // assert
            Assert.AreEqual(otv1, res1); // Сравнение
            Assert.AreEqual(otv2, res2); // Сравнение
            Assert.AreEqual(otv3, res3); // Сравнение
        }
    }
}
