using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7N
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 tda = new Class1();
            int[,,] arr1 = tda.ArrayGen(); 
            int[,,] arr2 = tda.ArrayGen(); 
            int[,,] resArr; 
            tda.ArrayOut(arr1);
            Console.WriteLine("______________________________");
            tda.ArrayOut(arr2);
            Console.WriteLine("______________________________");
            Console.WriteLine("Choose deystviye (cifry)\n1) Slozhit massivy\n2) Vychest massivy\n3) Ymnozhit massiv na chislo\n4) Sravnit summy dvyh massivov");
            int value = Convert.ToInt16(Console.ReadLine());
            switch(value)
            {
                case 1:
                    resArr = tda.ArraySum(arr1, arr2);
                    tda.ArrayOut(resArr);
                    break;
                case 2:
                    Console.WriteLine("Choose massiv iz kotorogo budem vychitat\n 1) 1 - 2\n 2) 2 - 1");
                    value = Convert.ToInt16(Console.ReadLine());
                    if (value == 1)
                    {
                        resArr = tda.ArrayDif(arr1, arr2);
                        tda.ArrayOut(resArr);
                    }                  
                    else if (value == 2)
                    {
                        resArr = tda.ArrayDif(arr2, arr1);
                        tda.ArrayOut(resArr);
                    }
                    else
                    {
                        Console.WriteLine("Eto ne cifra");
                    }                       
                    break;
                case 3:
                    Console.WriteLine("Choose massiv kotoryi budet ymnozhatsya\n 1) 1 \n 2) 2 ");
                    value = Convert.ToInt16(Console.ReadLine());
                    if (value == 1)
                    {
                        Console.WriteLine("Input chislo dlya ymnozheniya");
                        int num = Convert.ToInt16(Console.ReadLine());
                        resArr = tda.ArrayMul(arr1, num);
                        tda.ArrayOut(resArr);
                    }
                    else if (value == 2)
                    {
                        Console.WriteLine("Input chislo dlya ymnozheniya");
                        int num = Convert.ToInt16(Console.ReadLine());
                        resArr = tda.ArrayMul(arr2, num);
                        tda.ArrayOut(resArr);
                    }
                    else
                    {
                        Console.WriteLine("Eto ne cifra");
                    }
                    break;
                case 4:
                    int res1 = tda.ArrayFin(arr1);
                    int res2 = tda.ArrayFin(arr2);
                    if(res1 > res2) Console.WriteLine("Summa 1 massiva "+res1+" bolshe, chem 2 massiva "+res2);
                    else if (res2 < res1) Console.WriteLine("Summa 2 massiva "+res2+" bolshe, chem 1 massiva "+res1);
                    else if (res1 == res2) Console.WriteLine("Summa arrayev ravna ("+res1+" = "+res2);
                    else Console.WriteLine("Error!");
                    break;
                default :
                    Console.WriteLine("Chislo ne sootvetstvuet usloviyam!");
                    break;
            }
            Console.ReadLine();
        }
    }
}