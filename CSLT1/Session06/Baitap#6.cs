using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CSLT1.Session06
{
    internal class Baitap_6
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai1();
        }

        static void Bai1()// in mảng ngẫu nhiên
        {
            int n;
            do
            {
                Console.WriteLine("Nhập số phần tử:");
            } while(!int.TryParse(Console.ReadLine(), out n)||n<=0);   
            int[] a = new int[n];
            Ramdom1(a);
            Console.WriteLine("Gía trị trung bình của dãy");
            Console.WriteLine (TrungBinh(a));
            Console.WriteLine("Bạn muốn tìm giá trị nào:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(CoChua(a,i);
            
        }
        static void Ramdom1(int[] a)//do chỉ sửa lại mảng trong này nên ko cần return
        {
            Random rnd  = new Random();
            //cho ra số ngẫu nhiên từ 1->19
            for (int i = 0; i<a.Length;i++)
            {
                a[i] = rnd.Next(1, 20);
                Console.Write(a[i]+" ");
            }    
        }
        static double TrungBinh(int[]a)
        {
            double tong = 0;
            foreach (int i in a)
                tong +=i;
            return tong/a.Length;
               
        }
        static bool CoChua(int[] a,int x)
        {
            for (int i = 0; i < a.Length; i++)
                if(a[i] == x) return true;
            return false;
        }
        
    }
}
