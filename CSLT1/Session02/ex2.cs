using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CSLT1.Session02
{
    internal class ex2
    {
        static void Bai_1 ()
        {
            // Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit.Request the user the number of degrees celsius to convertthem using the following conversion tables:
            //kelvin = celsius + 273
            //- fahrenheit = celsius x 18 / 10 + 32
            //- Input
            //• 33
            //- Output
            //• kelvin = 306
            //• fahrenheit = 91
            Console.WriteLine("Enter degrees Celsius:");
            int cels = int.Parse(Console.ReadLine());
            int kelvin = cels + 273;
            int fahra = cels * 18 / 10 + 32;
            Console.WriteLine($"Kelvin={kelvin}\nFahrenheit={fahra}");
            //                Create a program in C# for calculate the surface and volume of a sphere, given its
            //radius.
            //-surface = 4 * pi * radius squared
            //- volume = 4 / 3 * pi * radius cubed
            //- Input
            //• 60
            //- Output
            //• Surface: 45238,93
            //• Volume: 678584,1
            Console.WriteLine("Enter radius for sphere:");
            float radius = float.Parse(Console.ReadLine());
            const float pi = MathF.PI;
            float surface = 4 * pi * radius * radius;
            float volume = 4 / 3 * pi * radius * radius * radius;
            Console.WriteLine($"surface={surface}\nvolume={volume}");
            // Write a program in C# that calculates the result of adding, subtracting,
            ////multiplying and dividing two numbers entered by the user.
            //-In addition you should also calculate the rest of the division on the last line.
            //-Input
            //• 12
            //• 3
            //- Output
            //• 12 + 3 = 15
            //• 12 - 3 = 9
            //• 12 x 3 = 36
            //• 12 / 3 = 4
            //• 12 mod 3 = 0
            Console.WriteLine("Enter a :");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter b :");
            float b = float.Parse(Console.ReadLine());
            float sum = a + b;
            float subtract = a - b;
            float multi = a * b;
            float divide = a / b;
            float mod = a % b;
            Console.WriteLine($"{a} + {b} = {sum}\n{a} - {b} = {subtract}\n{a} x {b} = {multi}\n{a} / {b} = {divide}\n{a} mod {b} = {mod}");
        }
        public static void Main(string[] args)
        {
            
            //            Nhập vào chỉ số điện cũ(kWh) và chỉ số điện mới(kWh).Kiểm tra điều kiện chỉ số mới phải lớn hơn hoặc
            //bằng chỉ số cũ.
            //• Tính lượng điện tiêu thụ trong tháng = Chỉ số mới -Chỉ số cũ.
            //• Tính tiền điện theo các bậc giá chưa thuế(Giá giả định năm 2026):
            //• +Bậc 1: Cho 50 kWh đầu tiên(từ 0 - 50 kWh): 1.806 VNĐ / kWh
            //• +Bậc 2: Cho 50 kWh tiếp theo(từ 51 - 100 kWh): 1.866 VNĐ / kWh
            //• +Bậc 3: Cho 100 kWh tiếp theo(từ 101 - 200 kWh): 2.167 VNĐ / kWh
            //• +Bậc 4: Cho 100 kWh tiếp theo(từ 201 - 300 kWh): 2.729 VNĐ / kWh
            //BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
            //Trang 3 / 14
            //• +Bậc 5: Cho toàn bộ kWh từ 301 kWh trở lên: 3.050 VNĐ / kWh
            //• Cộng thêm 8 % Thuế Giá trị gia tăng(VAT).
            //• In hóa đơn chi tiết gồm: Số kWh tiêu thụ, Tiền điện chưa thuế, Tiền thuế VAT và Tổng tiền phải thanh toán
            //(làm tròn đến hàng đơn vị decimal).
            //Ví dụ minh họa Input / Output:
            //---INPUT-- -
            //Nhập chỉ số điện cũ(kWh): 1250
            //Nhập chỉ số điện mới(kWh): 1520
            //-- - OUTPUT-- -
            //Số điện tiêu thụ: 270 kWh
            //Tiền điện chưa thuế: 636,650 VNĐ
            //Thuế VAT(8 %): 50,932 VNĐ
            //Tổng thanh toán: 687,582 VNĐ
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap so dien cu:");
            float d1 = float.Parse(Console.ReadLine());
            float d2;
            do
            {
                Console.WriteLine("Nhap so dien moi");
                d2 = float.Parse(Console.ReadLine());
                if (d2 > d1)
                    break;
                else
                    Console.WriteLine("\t***Chỉ số điên mới phải lớn hơn chỉ số cũ***");
            } while (true);
            Console.WriteLine(d2);
            float tieuthu = d2 - d1;
            float dongia = 1806f;
            decimal tiendien = (decimal)(tieuthu * dongia);
            decimal vat = tiendien * (decimal)(0.08f);
            Console.WriteLine($"Số điện tiêu thụ: {tieuthu} kWh\nTiền điện chưa thuế: {tiendien:C} VNĐ\nThuế VAT(8%):{vat:C} VNĐ\nTổng thanh toán: {tiendien +vat} VNĐ");
            Console.WriteLine("Nhấn bất kì phím nào để out");
            Console.ReadKey();

           
            }
            
        }
    }