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
            Bai2();
        }

        static void Bai1()// in mảng ngẫu nhiên
        {
            int n;
            do
            {
                Console.WriteLine("Nhập số phần tử:");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            int[] a = new int[n];
            Ramdom1(a);
            InMang(a);
            Console.WriteLine();
            Console.WriteLine("Gía trị trung bình của dãy");
            Console.WriteLine(TrungBinh(a));
            Console.WriteLine("Bạn muốn tìm giá trị nào:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(CoChua(a, i));
            Console.WriteLine("Bạn muốn xóa phần tử nào:");
            int j = int.Parse(Console.ReadLine());
            InMang(Xoaphantu(a, j));
            int min;
            int max;
            MaxMin(a,out max, out min);
            Console.WriteLine($"Gía trị min {min}, Gía trị max {max}");
            int[] kq = Daomang(a);
            InMang(kq);
            TimTrungLap(a);
            int[] xoa = XoatrungLap(a);
            InMang(xoa);


        }
        static void Ramdom1(int[] a)//do chỉ sửa lại mảng trong này nên ko cần return
        {
            int[] b = new int[a.Length];
            Random rnd = new Random();
            //cho ra số ngẫu nhiên từ 1->19
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 20);
            }
        }
        static void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        static double TrungBinh(int[] a)
        {
            double tong = 0;
            foreach (int i in a)
                tong += i;
            return tong / a.Length;

        }
        static bool CoChua(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x) return true;
            return false;
        }
        static int Timchiso(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x) return i;
            return -1;
        }
        static int[] Xoaphantu(int[] a, int x)
        {
            int dem = 0;
            foreach (int i in a)
                if (i != x) dem++;
            int[] kq = new int[dem];
            int vt = 0;
            foreach (int i in a)
            {
                if (i != x)
                {
                    kq[vt] = i;
                    vt++;
                }
            }
            return kq;
        }
        static void MaxMin(int[] a, out int max, out int min)
        {
            max = a[0];
            min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }


        }
        static int[] Daomang(int[] a)
        {
            int[] kq = new int[a.Length];
            for(int i = 0;i < a.Length;i++)
            {
                kq[i] = a[a.Length-1-i];
            }
            return kq;
        }
        static void TimTrungLap(int[]a)
        {
            bool co = false;
            for (int i = 0; i < a.Length; i++)
            {
                bool daIn = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] == a[i]) { daIn = true; break; }
                }
                    if (daIn) continue;
                    for (int k = i + 1; k < a.Length; k++)
                    {
                        if (a[i] == a[k])
                        {
                            Console.Write(a[i] + " ");
                            co = true;
                            break;
                        }
                    }
            }
                if(!co) Console.Write("Không có giá trị trùng");
                Console.WriteLine();
            } 
        
        static int[] XoatrungLap(int[]a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool trung = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] == a[i])
                        trung = true; break;
                    if (!trung) dem++;
                }
            }
                int[] kq = new int[dem];
                int vt = 0;
                for (int i =  0; i < a.Length;i++)
                {
                    bool lap = false;
                    for (int j = 0; j < i; j++)
                    {
                        if( a[j] == a[i])
                        {  lap = true; break;}
                        if( !lap)
                        {
                            kq[vt] = a[i];
                            vt++;
                        }    
                    } 
                        
                }
                return kq;
            }
        static void Bai2()
        {
            int[] a = new int[10];
            for(int i = 0;i < a.Length;i++)
            {
                int x;
                do
                {
                    Console.Write($"Nhập số thứ {i+1}:");

                }   while (!int.TryParse( Console.ReadLine(),out x ));
                a[i] = x;

            }
            BubbleSort(a);
            Console.Write(" Sau khi sắp xếp: ");
            InMang(a);
        }
        static void BubbleSort(int[]a)
        {
            for(int luot = 0; luot < a.Length-1;luot++)
            {
                for(int i = 0; i < a.Length; i++)
                {
                    if (a[i] > a[i+1])
                    {
                        int tam = a[i];
                        a[i] = a[i+1];
                        a[i+1] = tam;
                    }    
                } 
                    
            }    
        }
        static int TimKiemTuyenTinh(string[] cacTu, string Tu)
        {
            for (int i = 0; i < cacTu.Length; i++)
            {
                if (cacTu[i].ToLower() == Tu.ToLower()) return i;

            }
            return -1;
        }

    }
    }

