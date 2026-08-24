using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT1.session03
{
    internal class Ex3
    {
        static void Bai_1()
        {
            //Write a C# Sharp program that takes two numbers as input and
            //performs an operation(+,-,*, x,/) on them and displays the result of that
            //operation.
            Console.WriteLine("Nhap so a:"); int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b:"); int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a+b}");
            Console.WriteLine($"{a}-{b}={a-b}");
            Console.WriteLine($"{a}*{b}={a*b}");
            Console.WriteLine($"{a}/{b}={a/b}");
            Console.WriteLine($"{a}mod{b}={a%b}");
        }
        static void Bai_2()
        {
            //            Write a C# Sharp program to display certain values of the function x = y2
            //+ 2y + 1(using integer numbers for y, ranging from - 5 to + 5).
            int y;
            do
            {
                Console.WriteLine("Nhap so nguyen y:");
                y = int.Parse(Console.ReadLine());
                if (y > -5 && y < 5)
                    break;
                else
                    Console.WriteLine("So nguyen y nam trong khoang -5 den 5");


            }while (true);
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"Gia tri của x = y2 +2y +1 ={x}");

        }
        static void Bai_3()
        {
            //Hãy viết một chương trình C# nhận dữ liệu đầu vào là quãng đường và thời gian (giờ, phút, giây), 
            //    sau đó hiển thị vận tốc theo đơn vị kilômét/giờ (km/h) và dặm/giờ (miles/h).
            Console.WriteLine("Nhập quãng đường (km):");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập giờ:");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phút:");
            int minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giây:");
            int second = int.Parse(Console.ReadLine());
            // km/h
            double totalhours = (double)(hour + minute / 60 + second / 3600);
            Console.WriteLine($"{totalhours}");
            double speedkm = s / totalhours;
            // dặm/giờ
            double miles = speedkm * 0.621371;
            double speedMph = miles/ totalhours;
            Console.WriteLine($"Vận tốc theo km/h:{speedkm:F2}");
            Console.WriteLine($"Vận tốc theo dặm:{speedMph:F2}");

        }
        static void Bai_4()
        {
            double r;
            do
            {
                Console.WriteLine("Nhap bán kính hình cầu:");
               r = double.Parse(Console.ReadLine());
                if (r > 0)
                    break;
                else
                    Console.WriteLine("Bán kính phải lớn hơn 0");


            } while (true);
         double dientich = 4 * Math.PI * r * r;
         double thetich = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"Diện tích bề mặt hình cầu:{dientich}");
            Console.WriteLine($"Thể tích bề mặt hình cầu:{thetich}");
        }
        static void Ptbac2(int a, int b, int c)
        {
            // Giai pt bậc 2
            if (a==0)
            {
                if (b==0)
                {
                    if(c==0)
                    {
                        Console.WriteLine("Phương trình vô số nghiệm, x tùy ý");
                    }   
                    else
                    {
                        Console.WriteLine("Vô lý");
                    }   
                }
                else //a=0, b!=0
                {
                    if(c==0) //bx = 0
                    {
                        Console.WriteLine("x=0");
                    }
                    else
                    {
                        Console.WriteLine($"Phương trình có một nghiệm x={-c / b}");
                    }

                        
                }
                    
            }
            else //a!=0
            {
                double a = 
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                    Console.WriteLine($"Phương trình có hai nghiệm phân biệt x1={Math.Sqrt(delta)
            }
                


        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bai_1();
            //Bai_2();
            //Bai_3();
            //Bai_4();
            Ptbac2();
        }

    }
    }
