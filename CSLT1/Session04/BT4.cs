using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT1.Session04
{
    internal class BT4
    {

        public static void Main149(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //BangCuuChuong();
            //GameRandom();
            //Bai_1();
            //Bai_2();
            Bai_4();
            Bai_5();
            Bai_6();

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
            Random rnd = new Random();
            int con_num = rnd.Next(10) + 1;
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("Bạn đoán số mấy?: ");
                int user_num = int.Parse(Console.ReadLine());
                if (con_num == user_num)
                {
                    Console.WriteLine("Yayy!Bạn đoán đúng rồi!");
                    break;
                }
                else if (user_num < con_num)
                    Console.WriteLine("Bạn đoán số NHỎ hơn máy nghĩ");
                else
                    Console.WriteLine("Bạn đoán số LỚN hơn máy nghĩ");
            }
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
        static void Bai_7()
        {

        }
        }
        }
    

