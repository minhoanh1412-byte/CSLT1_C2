using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT1.session03
{
    internal class BT_3
    {
        static void Bai_1() //Giải phương trình hai ẩn
        {
            Console.Write("Nhập số a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số c:");
            int c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
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
                    if (c == 0) //bx = 0
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
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                    Console.WriteLine($"Phương trình có hai nghiệm phân biệt x1 = {(-b + Math.Sqrt(delta)) / 2 * a}; x2 = {(-b - Math.Sqrt(delta)) / 2 * a}");
                else if (delta < 0)
                    Console.WriteLine("Phương trình vô nghiệm");
                else
                    Console.WriteLine($"Phương trình có một nghiệm kép x = {-b / 2 * a}");
            }
        }
        static void Bai_2()// Nhập số, cho biết lẻ hay chẵn
        {
            int number;
            bool ok;
            do
            {
                Console.WriteLine("Nhập một số nguyên bất kì:");
                ok= int.TryParse(Console.ReadLine(), out number);
                if (!ok)
                    Console.WriteLine("Dữ liệu không hợp lệ! Vui lòng nhập lại:");
            }    while (!ok);
            if (number % 2 == 0)
                Console.WriteLine($" Số {number} là số chẵn");
            else
                Console.WriteLine($"Số {number} là số lẻ");

        }
        static void Bai_3()// find the largest of three numbers
        {
            Console.Write("Nhập số a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập số c:");
            double c = double.Parse(Console.ReadLine());
            if (a>b&&a>c)
                Console.WriteLine($"{a} là số lớn nhất trong 3 số {a};{b},{c}");
            else if(b>a && b>c)
                Console.WriteLine($"{b} là số lớn nhất trong 3 số {a};{b},{c}");
            else
                Console.WriteLine($"{c} là số lớn nhất trong 3 số {a};{b},{c}");
        }
        static void Bai_4() // check tam giác có cân, đều, hay tam giác thường
        {
            Console.Write("Nhập độ dài cạnh a: ");
            double a = double.Parse(Console.ReadLine()) ;
            Console.Write("Nhập độ dài cạnh b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài cạnh c: ");
            double c = double.Parse(Console.ReadLine());
            if (a + b <= c || b + c <= a || a + c <= b)
                Console.WriteLine("Ba cạnh này không tạo thành tam giác hợp lệ");
            else
            {
                if(a==b&&b==c)
                    Console.WriteLine("Ba cạnh tạo thành tam giác đều");
                else if(a==b||b==c||a==c)
                    Console.WriteLine("Ba cạnh tạo thàn tam giác cân");
                else
                    Console.WriteLine("Ba cạnh tạo thành tam giác thường");
            }    
        }
        static void Bai_5()// Nhập x,y và xem toạ độ này nằm ở góc phần tư bao nhiêu
        {
            int x, y;
            bool ok;
            do
            {
                Console.Write("Input the value for X coordinate: ");
                ok = int.TryParse(Console.ReadLine(), out x);
                if (!ok)
                    Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại X:");
            } while (!ok);
            do
            {
                Console.Write("Input the value for Y coordinate: ");
                ok = int.TryParse(Console.ReadLine(), out y);
                if (!ok)
                    Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại Y:");
            } while (!ok);
            if (x>0&&y>0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            else if (x<0&&y>0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            else if (x<0&&y<0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            else if (x>0&&y<0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            else if (x==0&&y==0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the origin.");
            else
                Console.WriteLine($"The coordinate point ({x},{y}) lies on an axis.");
        }
            
        public static void Main234(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int luachon;
            do
            {
                Console.WriteLine("======MENU BÀI TẬP #3======");
                Console.WriteLine("1 - Giải ptrinh 2 ẩn");
                Console.WriteLine("2 - Nhập số lẻ hay chẵn");
                Console.WriteLine("3 - Tìm số lớn nhất trong 3 số");
                Console.WriteLine("4 - Xác định loại tam giác");
                Console.WriteLine("5 - Xác định góc phần tư của toạ độ x,y");
                Console.WriteLine("0 - EXIT");
                Console.WriteLine("Chọn bài muốn chạy:");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                    {
                    case 1:Bai_1();break;
                    case 2:Bai_2();break;
                    case 3:Bai_3();break;
                    case 4: Bai_4();break;
                    case 5: Bai_5();break;
                    case 0: Console.WriteLine("Tạm biệt!"); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }

            } while (luachon != 0);

            Console.WriteLine("------PRESS ANY KEY TO EXIT-----");

        }
    

        }
    }

