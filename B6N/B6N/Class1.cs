using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6N
{
    public class Class1
    {
        static List<int> ages = new List<int> { };
        protected int age;
        protected int pos; //число посетителей
        protected const int MIN_AGE = 14;
        protected const int MAX_AGE = 80;
        protected int minAgeClient = 0;
        protected int maxAgeClient = 0;
        protected int sumage; //сумма возрастов
        protected double srpos = 0.0; //средний возраст


        public Class1(int ages)
        {
            this.Age = ages;
            this.AddAge();
            this.Main();
        }

        public int Age
        {
            set
            {
                if (value >= Class1.MIN_AGE && value <= Class1.MAX_AGE)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age is out of range");
                }
            }
            get { return age; }
        }

        protected void AddAge()
        {
            Class1.ages.Add(this.Age);
        }

        //getter&setter

        public int MinAgeClient { get { return minAgeClient; } set { minAgeClient = value; } }
        public int MaxAgeClient { get { return maxAgeClient; } set { maxAgeClient = value; } }
        public double Srpos { get { return srpos; } set { srpos = value; } }

        public void Main()
        {
            this.AgeMax(Class1.ages);
            this.AgeMin(Class1.ages);
            int sumage = this.AgeSum(Class1.ages);
            int pos = this.PosAges(Class1.ages);
            this.AgeSr(sumage, pos);
        }

        protected int PosAges(List<int> age) //количество значений
        {
            this.pos = age.Count();
            return this.pos;
        }

        protected void AgeMax(List<int> age)
        {
            this.MaxAgeClient = age.Max();
        }
        protected void AgeMin(List<int> age)
        {
            this.MinAgeClient = age.Min();
        }
        protected int AgeSum(List<int> age) //сумма возрастов
        {
            this.sumage = age.Sum();
            return this.sumage;
        }
        protected void AgeSr(int sumage, int pos) //средний возраст
        {
            double sr = Math.Round(((double)sumage / pos), 1);
            this.Srpos = sr;
        }
    }
}
