using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSLT1.Session04
{
    internal class BT4
    {

        public static void Main123(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //BangCuuChuong();
            GameRandom();
            //Bai_1();
            //Bai_2();
            //Bai_4();
            //Bai_5();
            //Bai_6();
            //Bai_7();
            //Bai_8();//in n số nguyên tố đầu tiên
            //Bai_9();//check xem có phải số hoàn hảo k

        }
        static void BangCuuChuong()
        {

            for (int i = 2; i <= 15; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }

        }
        static void GameRandom()
        {
            bool continue_play = true;
            int demthang = 0, tong = 0;
            int level = 1;
            int so_lan_doan = 0;
            int demthua = 0;
            int tien = 0;
            Random rnd = new Random();

            do
            {

                int con_num = rnd.Next(10) + 1;
                Console.WriteLine(" Bạn chọn level mấy: <1-Dễ>, <2-Trung Bình>, <3-Khó>:");
                level = int.Parse(Console.ReadLine());
                if (level == 1)
                    so_lan_doan = 15;
                else if (level == 2)
                    so_lan_doan = 10;
                else
                    so_lan_doan = 2;
                tong++;
                bool thang = false;
                for (int l = 1; l <= so_lan_doan; l++)
                {


                    Console.Write("Bạn đoán số mấy?: ");
                    int user_num = int.Parse(Console.ReadLine());
                    if (con_num == user_num)
                    {
                        Console.WriteLine("Yayy!Bạn đoán đúng rồi!");
                        Console.WriteLine($"Bạn đã đoán đúng sau {l} lần đoán");
                        demthang++;
                        tien += 10;
                        thang = true;
                        break;
                    }
                    else if (user_num < con_num)
                    {
                        Console.WriteLine("Bạn đoán số NHỎ hơn máy nghĩ");

                    }
                    else
                    {
                        Console.WriteLine("Bạn đoán số LỚN hơn máy nghĩ");

                    }
                }
                if (thang==false)
                {
                    demthua++;
                    tien -= 10;
                    Console.WriteLine("Bạn đã hết số lần đoán!");
                }    
                Console.WriteLine($"Số máy nghĩ ra là {con_num}");
                

                Console.Write("Bạn dám chơi nữa không <c/k>:");
                string tl = Console.ReadLine();
                if (tl.ToLower() == "k")
                {
                    continue_play = false;
                    Console.WriteLine("=====THỐNG KÊ=====");
                    Console.WriteLine($"Tổng số lượt chơi: {tong} ");
                    Console.WriteLine($"Số lượt thắng: {demthang}");
                    Console.WriteLine($"Số lượt thua :{demthua}");
                    Console.WriteLine($"Số tiền kiếm được: {tien} $");
                    break;
                }

            } while (continue_play);
        }    
        
        static void Bai_1()
        {
            //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene

            do
            {
                Console.Write("Nhập cạnh a:");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Nhập cạnh b:");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Nhập cạnh c:");
                double c = double.Parse(Console.ReadLine());
                if (a + b > c && b + c > a && c + a > b)
                {
                    if (a == b && a == c)
                        Console.WriteLine($"Tam giác có cạnh {a},{b},{c} là tam giác đều");
                    else if (a == b || b == c || a == c)
                        Console.WriteLine($"Tam giác có cạnh {a},{b},{c} là tam giác cân");
                    else
                        Console.WriteLine($"Tam giác đã cho là tam giác thường");
                    break;
                }
                else
                    Console.WriteLine("Đây không phải tam giác! Vui lòng nhập lại các cạnh");

            } while (true);
        }
        static void Bai_2()
        {
            //Write a program to read 10 numbers and find their average and sum
            double[] numbers = new double[10];
            for (int k = 0; k < 10; k++)
            {
                Console.Write($"Nhập số thứ {k + 1}:");
                numbers[k] = Convert.ToDouble(Console.ReadLine());
            }
            double sum = numbers.Sum();
            double average = numbers.Average();
            Console.WriteLine($"Tổng:{sum}");
            Console.WriteLine($"Trung bình cộng:{average}");
        }
        static void Bai_4()
        {
            //Write a program to display a pattern like triangles with a number.
            int n = 10;
            for (int l = 1; l <= n; l++)
            {
                for (int h = 1; h <= l; h++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
        static void Bai_5()
        {
            //Hình 1
            int n2 = 4;
            for (int i1 = 1; i1 <= n2; i1++)
            {
                for (int i2 = 1; i2 <= i1; i2++)
                {
                    Console.Write(i2);
                }
                Console.WriteLine();
            }
            //Hình 2
            int val = 1;
            int n3 = 4;
            for (int i3 = 1; i3 <= n3; i3++)
            {
                for (int i4 = 1; i4 <= i3; i4++)
                {
                    Console.Write(val + " ");
                    val++;
                }
                Console.WriteLine();
            }
            //Hình 3
            int val2 = 1;

            for (int i3 = 1; i3 <= n3; i3++)
            {
                Console.Write(new string(' ', n3 - i3));
                for (int i4 = 1; i4 <= i3; i4++)
                {
                    Console.Write(val2 + " ");
                    val2++;
                }
                Console.WriteLine();
            }
        }
        static void Bai_6()
        {
            //Write a program to display the n terms of harmonic series and their
            //sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms

            Console.Write("Enter the number of terms (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0.0;

            Console.Write("\nHarmonic Series: ");

            for (int i = 1; i <= n; i++)
            {
                // Print term
                if (i < n)
                {
                    Console.Write($"1/{i} + ");
                }
                else
                {
                    Console.Write($"1/{i}");
                }
                // Calculate sum using 1.0/i to ensure double division
                sum += 1.0 / i;
            }
            Console.WriteLine($"\nSum of {n} terms = {sum:F4}");
        }
        static void Bai_7()//Kiem tra so nguyen to
        {
            Console.WriteLine("Nhập số cần kiểm tra:");
            int so = int.Parse(Console.ReadLine());
            bool kt = true; //giả sử số cần kiểm tra là số nguyên tố
            for (int i = 2; i <= so / 2; i++)
            {
                if (so % i == 0)
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
                Console.WriteLine($"Số {so} là số nguyên tố");
            else
                Console.WriteLine($"Số {so} KHÔNG là số nguyên tố");

        }
        static void Bai_8()
        {
            Console.WriteLine("Bạn muốn in bao nhiêu số nguyên tố: ");
            int N = int.Parse(Console.ReadLine());
            int dem = 0;
            int so1 = 2;
            while (dem < N)
            {
                bool kt1 = true;
                for (int j = 2; j <= so1 / 2; j++)
                {
                    if (so1 % j == 0)
                    {
                        kt1 = false;
                        break;
                    }
                }
                if (kt1)
                {
                    dem++;
                    Console.Write($"{so1}, ");
                    if (dem % 10 == 0)
                        Console.WriteLine();
                }
                so1++;
            }

        }
        static void Bai_9()
        {
            Console.WriteLine("Nhập số cần kiểm tra:");
            int num = int.Parse(Console.ReadLine());
            bool ktra = true;
            int tong = 0;
            for(int k = 1; k<=num/2; k++)
            {
                if (num % k == 0)
                    tong += k;

            }    
            if(tong == num)
                Console.WriteLine($"{num} là số hoàn thiện");
            else
                Console.WriteLine($"{num} KHÔNG là số hoàn thiện");
        }
    }
}
    

