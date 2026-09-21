using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT1.Session06
{
    internal class BT6
    {

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("Nhập vào số phần tử của mảng:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            nhapMangNgaunhien(a);

            //        to calculate the average value of array elements.
            Console.WriteLine("\nGía trị trung bình của mảng");
            float sum = Average(a);
            Console.WriteLine($"{sum}");
            //2. to test if an array contains a specific value.
            Console.WriteLine("Bạn muốn tìm giá trị nào:");
            int p = int.Parse(Console.ReadLine());
            bool find = TestIfHave(a, p);
            if(find==true)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            //3. to find the index of an array element.
            Console.WriteLine("Tìm index ở mấy:");
            int k = int.Parse(Console.ReadLine());
            int g = searchIndex(a, k);
            Console.WriteLine(g);




            //4. to remove a specific element from an array.
            Console.WriteLine("Bạn muốn xóa kí tự nào");

            //5. to find the maximum and minimum value of an array.
            //6. to reverse an array of integer values.
            //7. to find duplicate values in an array of values.
            //8. to remove duplicate elements from an array.
        }

        static void nhapMangNgaunhien(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(3, 100);
            }
            foreach (int x in a)
                Console.Write(x+" ");
        }
        static float Average(int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;

            }
            return (float)sum / a.Length;
            Console.WriteLine();

        }
        
        static bool TestIfHave(int[] a, int i)
        {
            foreach (int v in a)
            
                if (v == i)
                    return true;
                return false;
            
        }
        static int searchIndex(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        static void RemoveElement(int[] a, int x)
        {
            for (int i = 0;i<a.Length; i++)
            {
                if (a[i] == x)
                {
                   RemoveElement(a,x);
                   Console.WriteLine(a);
                }    
            }   
        }
    }
    }

