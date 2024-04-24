using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace operators_and_loops
{
    class Program
    {
        /// <summary>
        /// Day la phep tinh cong
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        
        static void Main(string[] args)
        {
            ////if else

            /*label01:
            /*ADD(5,10);
            Console.WriteLine("Nhap so thu nhat: ");
            int st1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            int st2 = Convert.ToInt32(Console.ReadLine());

            //string a = st1 > 0 && st2 > 0 ? "Hai so khong am" : "Co so am";
            //Console.WriteLine(a); // toan tu ?: Tuong tu cach o duoi

            if (st1 > 0 && st2 > 0)
            {
                Console.WriteLine("Hai so khong am");
            }
            else
            {
                Console.WriteLine("Co so am");
            }*/

            /*
            if (y>0)
            { 
            Console.WriteLine("So khong am")
            }
            else if ()
            { }
            else if ()
            { }
            else
            { }*/

            /*Console.WriteLine("Nhap so: ");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (y)
            {
                case 1:
                    Console.WriteLine("So mot");//y==1
                    break;
                case 2:
                    Console.WriteLine("So hai");//y==2
                    break;
                default:
                    break;
            }

            Console.WriteLine("Nhap so nam: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                Console.WriteLine("Day la nam nhuan");
            else
                Console.WriteLine("Day khong phai la nam nhuan");
            goto label01;
            Console.ReadKey();*/

            //

            //Do while : thuc hien command trong do den khi khong thoa dk trong while nua thi dung 
            //int i = 0;
            /*do
            {
                ++i;
                Console.WriteLine(i);
                Thread.Sleep(20);
            } while (i<5); 
            */ 

            /*while(i < 20)
            {
                ++i;
                Console.WriteLine(i);
                Thread.Sleep(20);
            }
            */
            /*for (int j = 0; j < 20; j++)
            {
                Console.WriteLine(j);
                Thread.Sleep(20);
            }*/

            int[] num = { 23, 45, 123, 12312, 123123 };//ghi mang xuong pLC
            //for (int k=0; k < num.Length; k++)
            //{
            //    Console.WriteLine(num[k]);//lay tung phan tu trong index phan tu [0]=23 nen k chay tu 0 den 4 k=5 se bao loi
            //}

            foreach (var item in num)//
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
