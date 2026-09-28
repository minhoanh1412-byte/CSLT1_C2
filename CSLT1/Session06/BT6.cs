using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
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
            //Bai1to8();
            Bai9to10();
            Bai11toend();

        }

        static void Bai1to8()
        {
            Console.WriteLine("Nhập vào số phần tử của mảng:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            nhapMangNgaunhien(a);

            //to calculate the average value of array elements.
            Console.WriteLine("\nGía trị trung bình của mảng");
            float sum = Average(a);
            Console.WriteLine($"{sum}");

            //2. to test if an array contains a specific value.
            Console.WriteLine("Bạn muốn tìm giá trị nào:");
            int p = int.Parse(Console.ReadLine());
            bool find = TestIfHave(a, p);
            if (find == true)
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
            int x = int.Parse(Console.ReadLine());
            int[] KetQua = RemoveElement(a, x);
            Console.WriteLine("Mảng sau khi xoá: ");
            foreach (int phanTu in KetQua)
            {
                Console.Write(phanTu + " ");
            }
            Console.WriteLine();
            //5. to find the maximum and minimum value of an array.
            MaxMin(a, out int Max, out int Min);
            Console.WriteLine($"Giá trị lớn nhất:{Max}");
            Console.WriteLine($"Giá trị nhỏ nhất:{Min}");
            //6. to reverse an array of integer values.
            Console.WriteLine("Mảng sau khi đảo ngược: ");
            ReverseArray(a);
            Console.WriteLine();
            //7. to find duplicate values in an array of values.
            Console.WriteLine("Các giá trị bị trùng lặp: ");
            DuplicatedValue(a);


            //8. to remove duplicate elements from an array.
            int[] ketQua = RemoveDuplicated(a);
            Console.WriteLine("Mảng sau khi xoá trùng lặp");
            foreach (int i in ketQua)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Bai9to10()
        {
            //Nhập vào 10 số nguyên, sắp xếp bằng thuật toán bubble sort
            int[] a = { 5, 8, 9, 1, 2 };
            Console.WriteLine("Mảng trước khi nhập: ");
            foreach (int i in a)
                Console.Write(i + " ");
            Console.WriteLine("\nMảng sau khi sắp xếp: ");
            int[] ketqua = SapXepBubble(a);
            foreach (int i in ketqua)
                Console.Write(i + " ");
            Console.WriteLine();
            //tìm từ trong câu
            Console.Write("Nhập một câu: ");
            string cau = Console.ReadLine();

            Console.Write("Nhập từ cần tìm: ");
            string tuCanTim = Console.ReadLine();
            string[] cacTu = cau.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int viTri = TimKiemTuyenTinh(cacTu, tuCanTim);
            if (viTri != -1)
                Console.WriteLine($"Tìm thấy từ \"{tuCanTim}\" ở vị trí {viTri} trong câu.");
            else
                Console.WriteLine($"Không tìm thấy từ \"{tuCanTim}\" trong câu.");


        }
        static void Bai11toend()
        {
            Console.Write("Nhập số hàng N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Nhập số cột M: ");
            int M = int.Parse(Console.ReadLine());

            int[,] a = new int[N, M];

            //1. Create an integer matrix N x M randomly
            khoitaomang_random(a);

            //2. Print the matrix
            Console.WriteLine("Ma trận vừa tạo:");
            in_mang(a);

            //3. Print the ith row/column
            Console.Write("Nhập chỉ số hàng cần in (0 đến " + (N - 1) + "): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write($"Hàng {row}: ");
            in_dong(a, row);

            Console.Write("Nhập chỉ số cột cần in (0 đến " + (M - 1) + "): ");
            int col = int.Parse(Console.ReadLine());
            Console.Write($"Cột {col}: ");
            in_cot(a, col);

            //4. Find the max value of the matrix
            Console.WriteLine($"Giá trị lớn nhất của cả ma trận: {maxValue(a)}");

            //5. Find the min value of ith row/col of the matrix
            Console.WriteLine($"Giá trị nhỏ nhất của hàng {row}: {min_dong(a, row)}");
            Console.WriteLine($"Giá trị nhỏ nhất của cột {col}: {min_cot(a, col)}");

            //6. Transpose the matrix
            int[,] ma_chuyen_vi = transpose(a);
            Console.WriteLine("Ma trận sau khi chuyển vị:");
            in_mang(ma_chuyen_vi);

            //7. Print the main/secondary diagonal values of the matrix (square matrix)
            if (N == M)
            {
                duongCheo(a);
            }
            else
            {
                Console.WriteLine("Ma trận không vuông, không có đường chéo.");
            }
        }
    



        static void nhapMangNgaunhien(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(3, 100);
            }
            foreach (int x in a)
                Console.Write(x + " ");
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
        static int[] RemoveElement(int[] a, int x)
        {
            int PhanTuGiuLai = 0;
            foreach (int PhanTu in a)
            {
                if (PhanTu != x)
                    PhanTuGiuLai++;
            }
            int[] Ketqua = new int[PhanTuGiuLai];
            int Vitri = 0;
            foreach (int phanTu in a)
            {
                if (phanTu != x)
                {
                    Ketqua[Vitri] = phanTu;
                    Vitri++;
                }

            }
            return Ketqua;
        }
        static void MaxMin(int[] a, out int Max, out int Min)
        {
            Max = a[0];
            Min = a[0];
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] > Max)
                    Max = a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] < Min)
                    Min = a[i];
            }

        }
        static int[] ReverseArray(int[] a)
        {
            int[] KetQua = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                KetQua[i] = a[a.Length - 1 - i];
            }
            foreach (int i in KetQua)
            {
                Console.Write(i + " ");
            }
            return KetQua;
        }
        static void DuplicatedValue(int[] a)
        {
            bool coTrung = false;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j] == a[i])
                    {
                        Console.Write(a[i] + " ");
                        coTrung = true;
                        break;
                    }
            }
            if (!coTrung)
                Console.WriteLine("Mảng này không trùng");
            Console.WriteLine();
        }
        static int[] RemoveDuplicated(int[] a)
        {
            int[] ketQua = a;
            for (int i = 0; i < a.Length; i++)
            {
                int giaTri = a[i];
                int SoLanXuatHien = 0;
                foreach (int x in ketQua)
                {
                    if (x == giaTri)
                        SoLanXuatHien++;
                }
                if (SoLanXuatHien > 1)
                {
                    ketQua = RemoveElement(ketQua, giaTri);
                    ketQua = ThemVaoCuoi(ketQua, giaTri);

                }
            }
            return ketQua;
        }
        static int[] ThemVaoCuoi(int[] a, int GiaTri)
        {
            int[] ketqua = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                ketqua[i] = a[i];
            }
            ketqua[a.Length] = GiaTri;
            return ketqua;
        }
        static int[] SapXepBubble(int[] a)
        {
            int n =a.Length;
            for (int i = 0;i < n-1;i++)
            {
                for (int y = 0; y < n-1-i; y++)
                {
                    if (a[y] > a[y+1])
                    {
                        int tam = a[y];
                        a[y] = a[y+1];
                        a[y+1] = tam;
                    }    
                     
                }
            } return a;
        }
        static int TimKiemTuyenTinh(string[] cacTu, string tuCanTim)
        {
            for (int i = 0; i < cacTu.Length; i++)
            {
                if (cacTu[i].ToLower() == tuCanTim.ToLower())
                    return i;   
            }
            return -1;   
        }

        static void khoitaomang_random(int[,] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    a[i, j] = rnd.Next(1, 10);
        }

        static void in_mang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write($" {a[i, j]}\t");
                Console.WriteLine();
            }
        }

        static int maxValue(int[,] a)
        {
            int max = a[0, 0];
            foreach (int item in a)
                if (item > max)
                    max = item;
            return max;
        }

        static void in_dong(int[,] a, int row)
        {
            for (int j = 0; j < a.GetLength(1); j++)
                Console.Write(a[row, j] + " ");
            Console.WriteLine();
        }

        static void in_cot(int[,] a, int col)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                Console.Write(a[i, col] + " ");
            Console.WriteLine();
        }

        static int min_dong(int[,] a, int row)
        {
            int min = a[row, 0];
            for (int j = 1; j < a.GetLength(1); j++)
                if (a[row, j] < min)
                    min = a[row, j];
            return min;
        }

        static int min_cot(int[,] a, int col)
        {
            int min = a[0, col];
            for (int i = 1; i < a.GetLength(0); i++)
                if (a[i, col] < min)
                    min = a[i, col];
            return min;
        }

        static int[,] transpose(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            int[,] ketQua = new int[m, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    ketQua[j, i] = a[i, j];

            return ketQua;
        }

        static void duongCheo(int[,] a)
        {
            int n = a.GetLength(0);

            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i, i] + " ");
            Console.WriteLine();

            Console.Write("Đường chéo phụ: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i, n - 1 - i] + " ");
            Console.WriteLine();
        }
    }
}


