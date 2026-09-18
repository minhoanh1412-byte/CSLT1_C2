using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CSLT1.Session05
{
    internal class BT_5
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai1();//Tổng 2 số
            Bai2(); // Xét số chẵn lẻ
            Bai3();
            Bai4();
            Bai5();
            Bai6();
            Bai7();
            Bai8();
            Bai9();
            Bai10();
            Bai11();
            Bai12();
            Bai13();
            Bai14();
            Bai15();
            Bai16();
            Bai17();
            Bai18();
            Bai19();
            Bai20();
            Console.WriteLine("\n======PRESS ANY KEY TO EXIT======");
        }


        static void Bai1()//Tổng 2 số
        {
            Console.WriteLine("Bài 1: Tính tổng 2 số");
            Console.WriteLine("Nhập vào số a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số b:");
            int b = int.Parse(Console.ReadLine());
            int c = TinhTong(a, b);
            Console.WriteLine($"{a} + {b} = {c}");

        }
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static void Bai2()
        {
            Console.WriteLine("Bài 2: Kiểm tra chẵn lẻ");
            Console.WriteLine("Nhập số cần kiểm tra:");
            int d = int.Parse(Console.ReadLine());
            if (KiemTraChan(d) == true)
                Console.WriteLine($"{d} là số chẵn");
            else
                Console.WriteLine($"{d} là số lẻ");
        }
        static bool KiemTraChan(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
        static void Bai3()
        {
            Console.WriteLine("Bài 3: Tìm số lớn nhất trong 3 số");
            Console.WriteLine("Nhập số a: ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhập số b: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số c: ");
            int g = int.Parse(Console.ReadLine());
            int h = TimMax(e, f, g);
            Console.WriteLine($"Số lớn nhất trong 3 số trên là: {h}");
        }
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        static void Bai4()
        {
            Console.WriteLine("Bài 4: Tính giai thừa của 1 số:");
            int n;
            bool ok;
            do
            {
                Console.WriteLine("Nhập một số nguyên không âm:");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("Vui lòng nhập lại số nguyên!");
                else if (n < 0)
                    Console.WriteLine("Vui lòng nhập lại số nguyên không âm!");

            } while (!ok || n < 0);
            long ketqua = TinhGiaiThua(n);
            Console.WriteLine($"{n}! = {ketqua}");

        }
        static long TinhGiaiThua(int n)
        {
            long ketqua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketqua = ketqua * i;
            }
            return ketqua;
        }
        static void Bai5()// đảo ngược chuỗi ký tự
        {
            Console.WriteLine("Bài 5: Đảo ngược chuỗi kí tự");
            Console.WriteLine("Nhập chuỗi: ");
            string input = Console.ReadLine();
            string KetQua = DaoNguocChuoi(input);
            Console.WriteLine($"Chuỗi đảo ngược:{KetQua}");
        }
        static string DaoNguocChuoi(string input)
        {
            char[] char_array = input.ToCharArray(); // chuyển chuỗi thành mảng ký tự hello -> [h,e,l,l,o]
            Array.Reverse(char_array); // đảo ngược mảng [h,e,l,l,o] -> [o,l,l,e,h] 
            return new string(char_array); // ghép mảng ký tự lại thành chuỗi
        }
        static void Bai6()
        {
            Console.WriteLine("Bài 6: Kiểm tra số nguyên tố");
            Console.WriteLine("Nhập số cần kiểm tra:");
            int n = int.Parse(Console.ReadLine());
            bool Ketqua = KiemTraNguyenTo(n);
            if (Ketqua == true)
                Console.WriteLine($"{n} là số nguyên tố");
            else
                Console.WriteLine($"{n} KHÔNG là số nguyên tố");

        }
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;

            }
            return true;
        }
        static void Bai7()
        {
            Console.WriteLine("Bài 7: Chuyển sô sang InFibonacci");
            Console.WriteLine("Nhập n:");
            int n = int.Parse(Console.ReadLine());
            InFibonacci(n);

        }
        static void InFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int c = a + b;
                a = b;
                b = c;
            }
        }
        static void Bai8() // đếm số nguyên âm trong chuỗi
        {
            Console.WriteLine("Bài 8: Đếm số nguyên âm trong chuỗi");
            Console.WriteLine("Input: ");
            string s = Console.ReadLine();
            int dem = DemNguyenAm(s);
            Console.WriteLine($"Output:{dem}");
        }
        static int DemNguyenAm(string s)
        {
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'i' || s[i] == 'u' || s[i] == 'e' || s[i] == 'o')
                    dem++;
            }
            return dem;

        }
        static void Bai9()
        {
            Console.WriteLine("Bài 9: Tính lũy thừa");
            Console.WriteLine("Input x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Input y:");
            int y = int.Parse(Console.ReadLine());
            double ketqua1 = TinhLuyThua(x, y);
            Console.WriteLine($"Ouput x^y: {ketqua1}");

        }
        static double TinhLuyThua(double x, int y)
        {
            double ketqua = 1;
            for (int i = 0; i < y; i++)
            {
                ketqua = ketqua * x;
            }
            return ketqua;

        }
        static void Bai10()
        {
            Console.WriteLine("Bài 10: Tính trung bình dãy số");
            Console.WriteLine("Nhập vào 1 hàm: ");
            string input1 = Console.ReadLine();
            input1 = input1.Replace("]", ",").Replace("]", "");
            input1 = input1.Replace(" ", ",").Replace(" ", ",");
            string[] tach = input1.Split(',');//tách chuỗi thành từng phần
            int[] arr = new int[tach.Length];//tính số phần tử của chuỗi
            for (int i = 0; i < tach.Length; i++)
            {
                arr[i] = int.Parse(tach[i].Trim());//xóa khoảng trống trước từng kí tự, chuyển chúng sang dạng int
            }
            double ketqua2 = TinhTrungBinh(arr);
            Console.WriteLine($"Output:{ketqua2}");

        }
        static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tong = tong + arr[i];
            }
            return (double)tong / arr.Length;
        }
        static void Bai11()
        {
            Console.WriteLine("Bài 11: Kiểm tra đối xứng");
            Console.WriteLine("Input chuỗi: ");
            string s = Console.ReadLine();
            if (KiemTraDoiXung(s) == true)
                Console.WriteLine("Output: True");
            else
                Console.WriteLine("Output: False");
        }
        static bool KiemTraDoiXung(string s)
        {
            if (s == DaoNguocChuoi(s))
                return true;
            return false;
        }
        static void Bai12()
        {
            Console.WriteLine("Bài 12: Đổi độ sang F");
            Console.WriteLine("Nhập độ C:");
            double c = double.Parse(Console.ReadLine());
            double d = CelsiusToFahrenheit(c);
            Console.WriteLine($"Output độ F: {d} ");
        }
        static double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }
        static void Bai13()
        {
            Console.WriteLine("Bài 13: Tìm số nhỏ nhất trong chuỗi");
            bool ok = false;
            string[] tach1 = null;

            do
            {
                Console.WriteLine("Input: ");
                string input2 = Console.ReadLine();
                input2 = input2.Replace(" ", ","); 
                tach1 = input2.Split(',');
                ok = true;
                for (int i = 0; i < tach1.Length; i++)
                {
                    if (!int.TryParse(tach1[i].Trim(), out int x))
                    {
                        ok = false;
                        break;
                    }
                }
                if (!ok)
                    Console.WriteLine("Vui lòng chỉ nhập số: ");
            } while (!ok);

            int[] arr1 = new int[tach1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(tach1[i].Trim());
            }
            int KetQua2 = TimMin(arr1);
            Console.WriteLine($"Số nhỏ nhất trong chuỗi:{KetQua2} ");

        }
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        static void Bai14()//Tổng các chữ số của 1 số nguyên 
        {
            Console.WriteLine("Bài 14: Tìm tổng các chữ số của 1 số nguyên");
            Console.WriteLine("Nhập một số bất kì: ");
            int n = int.Parse(Console.ReadLine());
            int ketqa = TinhTongCacChuSo(n);
            Console.WriteLine($"Tổng chữ số trong n:{ketqa}");
        }
        static int TinhTongCacChuSo(int n)
        {
            string chuoi = n.ToString();
            char[] tachchuoi = chuoi.ToCharArray();
            int[] arr = new int[tachchuoi.Length];
            int tong = 0;
            for (int i = 0; i < tachchuoi.Length; i++)
            {
                arr[i] = int.Parse((tachchuoi[i].ToString()).Trim());
                tong = tong + arr[i];
            }
            return tong;


        }
        static void Bai15()// sắp xếp và in ra mảng tăng dần.
        {
            Console.WriteLine("Bài 15: Sắp xếp và in ra mảng tăng dần");
            Console.WriteLine("Nhập vào một dãy số:");
            string chuoi = Console.ReadLine();
            string input = chuoi.Replace("[", ",").Replace("]", ",");
            input = chuoi.Replace(" ", ",").Replace(" ", ",");
            string[] tach2 = input.Split(',');
            int[] arr = new int[tach2.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse((tach2[i].Trim()));

            }

            SapXepMang(arr);
        }
        static void SapXepMang(int[] arr)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int i = 0; i < arr.Length - 1; i++)
                    {

                        if (arr[i] > arr[i + 1])//nếu số đầu lớn hơn số sau
                        {
                            int temp = arr[i];//gán temp vị trí đầu
                            arr[i] = arr[i + 1];// vị trí số đầu sẽ là số sau
                            arr[i + 1] = temp;//đưa số sau vào temp

                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]},");
                }
            }

        static void Bai16()
        {
            Console.WriteLine("Bài 16: Xóa trùng lặp");
            Console.WriteLine("Nhập một dãy: ");
            string s = Console.ReadLine();
            string ketqua = XoaTrungLap(s);
            Console.WriteLine(ketqua);
        }
                static string XoaTrungLap(string s)
                {
                    string ketqua = "";

                    for (int i = 0; i < s.Length; i++)
                    {
                        if (ketqua.Contains(s[i].ToString()) == false)
                        {
                            ketqua += s[i];

                        }
                    }
                    return ketqua;

                }
        static void Bai17()
        {
            Console.WriteLine("Bài 17: Tìm UCLN của a và b");
            Console.WriteLine("Nhập số a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số b:");
            int b = int.Parse(Console.ReadLine());
            int c = UCLN(a, b);
            Console.WriteLine($"UCLN({a},{b})={c}");
        }
        static int UCLN(int a, int b)
        {
            while (b!=0)
            {
                int du = a % b;
                    a = b;
                    b = du;
              
            }  return a;  
        }
        static void Bai18()
        {
            Console.WriteLine("Bài 18: Mã nhị phân của n");
            Console.WriteLine("Nhập vào số n:");
            int n = int.Parse(Console.ReadLine());
            string ketqua = DecimalToBinary(n);
            Console.WriteLine($"Mã nhị phân: {ketqua}");
        }
        static string DecimalToBinary(int n)
        {
            string ketqua = "";
            while(n>0)
            {
                int du = n % 2;
                n = n / 2;
                ketqua = du + ketqua;
            } return ketqua;
        }
        static void Bai19()
        {
            Console.WriteLine("Bài 19: Kiểm tra năm nhuận");
            Console.WriteLine("Nhập vào một năm: ");
            int year = int.Parse(Console.ReadLine());
            bool nam = KiemTraNamNhuan(year);
            if (nam == true)
                Console.WriteLine("True");
            else
            Console.WriteLine("False");
              
        }
        static bool KiemTraNamNhuan(int year)
        {
            if (year % 4 == 0 || year % 4  == 0&&year%100!=0)
                return true;
            
                return false;
        }
        static void Bai20()
        {
            Console.WriteLine("Bài 20: Số lượng từ trong 1 chuỗi");
            Console.WriteLine("Input:");
            string sentence = Console.ReadLine();
            DemSoTu(sentence);
        }
        static int DemSoTu(string sentence)
        {
            sentence = sentence.Replace(" ", ",").Replace(" ", ",");
            string[] tach = sentence.Split(",");
            Console.WriteLine($"INPUT: {tach.Length}");
            return tach.Length;
        }
        }
    }


