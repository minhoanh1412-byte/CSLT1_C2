using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CSLT1.Session05
{
    internal class BT5
    {
        public static void Main1314(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bai1(); //Tìm max 3 tham số
            //Bai2();
            //Bai3();
            //Bai4();
            Bai5();
            Console.WriteLine("======PRESS ANY KEY TO EXIT======");
        }

        static void Bai1()
        {
            Console.WriteLine("Dùng hàm ba tham số");
            int max3 = TimMax(10, 25, 7);
            Console.WriteLine($"Max của (10,25,7) là {max3} ");
            int max1 = TimMax(42);
            Console.WriteLine($"Max của số 42 là {max1}");
            int max4 = TimMax(5, 12, 99, 3);
            Console.WriteLine($"Max của 4 số (5,12,99,3) là {max4}");
        }
        static int TimMax(int soDauTien, params int[] cacSoConLai)
        {
            int max = soDauTien;

            // Duyệt qua các số còn lại (nếu có)
            foreach (int so in cacSoConLai)
            {
                if (so > max)
                {
                    max = so;
                }
            }

            return max;
        }
        static void Bai2()
        {
            int n;
            bool ok;
            do
            {
                Console.WriteLine("Nhập một số nguyên không âm:");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("Vui lòng nhập lại một số nguyên!");
                else if (n < 0)
                    Console.WriteLine("Số phải không âm (>=0)! Vui lòng nhập lại");
            } while (!ok || n < 0);
            long ketQua = TinhGiaiThua(n);
            Console.WriteLine($"{n}!={ketQua}");
        }
        static long TinhGiaiThua(int n)
        {
            long ketQua = 1; //Bắt đầu nhận từ 1
            for (int i = 1;  i <= n; i++)
            {
                ketQua = ketQua * i;
            }    
            return ketQua;
        }
        static void Bai3()//check xem số đó có phải số nguyên tố không
        {
            Console.WriteLine("Nhập số cần kiểm tra: ");
            int so = int.Parse(Console.ReadLine());
            if (IsPrime(so))
                Console.WriteLine($"{so} là số nguyên tố");
            else
                Console.WriteLine($"{so} KHÔNG là số nguyên tố");
           
        }
        static bool IsPrime (int number)
        {
            if (number < 2) return false;
            for ( int i = 2; i < number; i++)
            {
                if (number%i==0)
                    return false;
            }    return true;
        }
        static void Bai4()//in ra N số nguyên tố đầu tiên
        {
            Console.WriteLine("Bạn muốn in bao nhiêu số");
            int so1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Các số nguyên tố nhỏ hơn {so1}:");
            PrintNumberUNderSNT( so1 );
            Console.WriteLine($"{so1} số nguyên tố đầu tiên là:");
            printfirstSNT( so1 );
        }
        static void PrintNumberUNderSNT(int n)
        {
            for (int g=2;g<n;g++)
            {
                if(IsPrime(g))
                    Console.WriteLine($"{g}, ");
            }    
        }
        static void printfirstSNT(int n1)
        {
            int dem = 0;
            int so2 = 2;
            while (dem<n1)
            {
                if (IsPrime(so2))
                {
                    Console.WriteLine($"{so2}, ");
                    dem++;
                } so2++;   
            }    
        }
        static void Bai5()// đảo ngược chuỗi ký tự
        {
            Console.WriteLine("Nhập chuỗi: ");
            string input = Console.ReadLine(); 
            string KetQua = DaoNguocChuoi(input);
            Console.WriteLine($"Chuỗi đảo ngược:{KetQua}");
        }
        static string DaoNguocChuoi(string input)
        {
            char[]char_array= input.ToCharArray(); // chuyển chuỗi thành mảng ký tự hello -> [h,e,l,l,o]
            Array.Reverse(char_array); // đảo ngược mảng [h,e,l,l,o] -> [o,l,l,e,h] 
            return new string (char_array); // ghép mảng ký tự lại thành chuỗi
        }

    } 
}
    
