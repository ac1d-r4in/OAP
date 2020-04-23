using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6N
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int age;
            int minAge = 0;
            int maxAge = 0;
            double avgAge = 0.00;
            Console.WriteLine("Skolko klientov posetilo zal?");
            count = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input vozrast klientov:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Input vozrast {i + 1} klienta:");
                age = Convert.ToInt16(Console.ReadLine());
                Class1 gym = new Class1(age);
                minAge = gym.MinAgeClient;
                maxAge = gym.MaxAgeClient;
                avgAge = gym.Srpos;
            }

            Console.WriteLine("\nMin vozrast: "+minAge+"\nMax vozrast: "+maxAge+"\nSredniy vozrast: "+avgAge+"\n");
            Console.ReadLine();
        }
    }
}
