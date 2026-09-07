using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT1.Session02
{
    internal class BTTTE

    {
       
        static void Bai_1()
        {
            //            Kiểu decimal, ép kiểu dữ liệu, định dạng tiền tệ({ 0:C}
            //        hoặc #,##0 VNĐ), tính toán toán
            //học.
            //Yêu cầu bài toán:
            //• Nhập vào chỉ số điện cũ (kWh) và chỉ số điện mới (kWh). Kiểm tra điều kiện chỉ số mới phải lớn hơn hoặc
            //bằng chỉ số cũ.
            //• Tính lượng điện tiêu thụ trong tháng = Chỉ số mới - Chỉ số cũ.
            //• Tính tiền điện theo các bậc giá chưa thuế (Giá giả định năm 2026):
            //• + Bậc 1: Cho 50 kWh đầu tiên(từ 0 - 50 kWh) : 1.806 VNĐ/kWh
            //• + Bậc 2: Cho 50 kWh tiếp theo(từ 51 - 100 kWh) : 1.866 VNĐ/kWh
            //• + Bậc 3: Cho 100 kWh tiếp theo(từ 101 - 200 kWh) : 2.167 VNĐ/kWh
            //• + Bậc 4: Cho 100 kWh tiếp theo(từ 201 - 300 kWh) : 2.729 VNĐ/kWh
            //BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
            //Trang 3 / 14
            //• + Bậc 5: Cho toàn bộ kWh từ 301 kWh trở lên: 3.050 VNĐ/kWh
            //• Cộng thêm 8 % Thuế Giá trị gia tăng(VAT).
            //• In hóa đơn chi tiết gồm: Số kWh tiêu thụ, Tiền điện chưa thuế, Tiền thuế VAT và Tổng tiền phải thanh toán
            //(làm tròn đến hàng đơn vị decimal).
            //            ---INPUT-- -
            //            Nhập chỉ số điện cũ(kWh): 1250
            //Nhập chỉ số điện mới(kWh): 1520
            //-- - OUTPUT-- -
            //Số điện tiêu thụ: 270 kWh
            //Tiền điện chưa thuế: 636,650 VNĐ
            //Thuế VAT(8 %): 50,932 VNĐ
            //Tổng thanh toán: 687,582 VNĐ
            Console.WriteLine("-----INPUT-----");
            decimal diencu;
            decimal dienmoi;
            do
            {
                Console.WriteLine("Nhập chỉ số điện cũ:");
                bool ok = decimal.TryParse(Console.ReadLine(), out diencu);   //  2 tham số, trả về bool

                if (!ok)
                {
                    Console.WriteLine("Dữ liệu không hợp lệ! Vui lòng nhập lại một số.");
                    continue;
                }
                if (diencu > 0)
                    break;
                else
                    Console.WriteLine("Chỉ số điện cũ phải lớn hơn 0! Vui lòng nhập lại:");
            } while (true);
            do
            {
                Console.WriteLine("Nhập chỉ số điện mới: ");
                bool ok = decimal.TryParse(Console.ReadLine(), out dienmoi);   //  tương tự

                if (!ok)
                {
                    Console.WriteLine("Dữ liệu không hợp lệ! Vui lòng nhập lại một số.");
                    continue;
                }
                    if (dienmoi >= diencu)
                    break;
                else
                    Console.WriteLine("Chỉ số điện mới phải lớn hơn hoặc bằng chỉ số điện cũ! \n Nhập lại chỉ số điện mới:");

            }while (true);
            decimal tieuthu = dienmoi - diencu;
            decimal tiendien;
            if (tieuthu <= 50)
                tiendien = 1.806m * tieuthu;
            else if (tieuthu >= 51 && tieuthu <= 100)
                tiendien = 1.806m * 50 + (tieuthu - 50) * 1.866m;
            else if (tieuthu >= 101 && tieuthu <= 200)
                tiendien = 1.806m * 50m + 1.866m * 50 + (tieuthu - 100) * 2.167m;
            else if (tieuthu >= 201 && tieuthu <= 300)
                tiendien = 1.806m * 50m + 1.866m * 50 + 100 * 2.167m + (tieuthu - 200) * 2.729m;
            else
                tiendien = 1.806m * 50m + 1.866m * 50 + 100 * 2.167m + 100 * 2.729m + (tieuthu - 300) * 3.050m;
            decimal thue = tiendien*0.08m;
            decimal tiensauthue = tiendien + thue;
            Console.WriteLine("-----OUTPUT-----");
            Console.WriteLine($"Số điện tiêu thụ:{tieuthu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế:{tiendien:F3} VNĐ");
            Console.WriteLine($"Thuế VAT 8%:{thue:F3} VNĐ");
            Console.WriteLine($"Tổng thanh toán:{tiensauthue:F3} VNĐ");

        }
       
        static void Bai_2()
        {
            //Kiến thức trọng tâm: Kiểu double, ép kiểu, Math.Pow(), định dạng số thập phân({ 0:F2}), cấu trúc rẽ nhánh.
            //Yêu cầu bài toán:
            //• Nhập vào chiều cao(tính bằng mét, ví dụ 1.72) và cân nặng(tính bằng kg, ví dụ 68.5).
            //• Tính chỉ số BMI theo công thức: BMI = Cân nặng / (Chiều cao ^ 2).
            //• Phân loại tình trạng sức khỏe theo chuẩn WHO dành cho người châu Á:
            //• +BMI < 18.5: Gầy(Thiếu cân)
            //• +18.5 <= BMI < 23.0: Bình thường(Lý tưởng)
            //• +23.0 <= BMI < 25.0: Thừa cân(Tiền béo phì)
            //• +BMI >= 25.0: Béo phì
            //• Tính dải cân nặng lý tưởng cho chiều cao đó(Cân nặng tối thiểu = 18.5 * Chiều cao^2; Cân nặng tối đa =
            //22.9 * Chiều cao ^ 2).
            //• Xuất ra chỉ số BMI(lấy 2 chữ số thập phân), phân loại và khoảng cân nặng lý tưởng.
            Console.WriteLine("-----INPUT-----");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chiều cao (m):");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng (kg):");
            double w = double.Parse(Console.ReadLine());
            double BMI = w / (h * h);
            Console.WriteLine("------OUTPUT-----");
            if (BMI < 18.6)
                Console.WriteLine("Gầy(Thiếu cân)");
            else if (18.5 <= BMI && BMI < 23.0)
                Console.WriteLine("Bình thường (Lý tưởng)");
            else if (23.0 <= BMI && BMI < 25.0)
                Console.WriteLine("Thừa cân(Tiền béo phì)");
            else if (BMI >= 25.0)
                Console.WriteLine("Béo phì");
            double wmin = 18.5 * h*h;
            double wmax = 22.9 * h*h;
            Console.WriteLine($"Cân nặng lý tưởng của bạn từ:{wmin:F2} kg đến {wmax:F2} kg");

        }
        static void Bai_3()
        {
            //            Kiểu decimal, enum (CurrencyType), switch-case, định dạng tiền tệ quốc tế.
            //Yêu cầu bài toán:
            //• Tạo một enum tên CurrencyType gồm: USD, EUR, JPY, GBP.
            //• Khai báo tỷ giá cố định(Ví dụ: 1 USD = 25,400 VNĐ; 1 EUR = 27,200 VNĐ; 1 JPY = 165 VNĐ; 1 GBP =
            //32,100 VNĐ).
            //• Nhập vào số tiền VNĐ cần đổi(decimal) và chọn loại ngoại tệ muốn đổi.
            //• Phí dịch vụ quy đổi là 0.5 % trên tổng số tiền VNĐ.
            //• Tính số tiền VNĐ thực tế sau khi trừ phí, sau đó quy đổi ra ngoại tệ tương ứng.
            //• In kết quả chính xác đến 2 chữ số thập phân kèm ký hiệu tiền tệ

            CultureInfo us = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("--- INPUT ---");
            decimal vnd;
            do
            {
                Console.WriteLine("Nhập số tiền VNĐ cần đổi:");
                vnd = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//tham số thứ 2, parse hiểu dấu . là thập phân theo chuẩn qte
                if (vnd > 0)
                    break;
                else
                    Console.WriteLine("Số tiền nhập phải lớn hơn 0");
            } while (true);
            CurrencyType loai;
            decimal tygia = 0;
            string kihieu = ""; 
            while (true) 
            {
                Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
                int luaChon = int.Parse(Console.ReadLine());
                bool HopLe = true;
                switch (luaChon)
                {

                    case 1: loai = CurrencyType.USD; tygia = 25400; kihieu = "USD"; break;
                    case 2: loai = CurrencyType.EUR; tygia = 27200; kihieu = "EUR"; break;
                    case 3: loai = CurrencyType.JPY; tygia = 165; kihieu = "JPY"; break;
                    case 4: loai = CurrencyType.GBP; tygia = 32100; kihieu = "GBP"; break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                    HopLe = false;
                        break;

            }
                if (HopLe)
                    break;
            }
            decimal phi = vnd * 0.5m/100;
            decimal Sotiensauphi = vnd - phi;
            decimal sotienngoaite = Sotiensauphi / tygia;
            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Phí dịch vụ (0.5%): {phi.ToString("N0", us)} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {Sotiensauphi.ToString("N0", us)} VNĐ");
            Console.WriteLine($"Số tiền {kihieu} nhận được: {sotienngoaite.ToString("N2", us)} {kihieu}");

        }
        enum CurrencyType
        {
            USD, EUR, JPY, GBP
        }
        static void Bai_4()
        {
            //            • Nhập ngày tháng năm sinh của người dùng dưới dạng chuỗi 'dd/MM/yyyy'(ví dụ: '25/10/2002').
            //• Chuyển đổi chuỗi thành DateTime sử dụng DateTime.TryParseExact để đảm bảo không bị lỗi định dạng.
            //• Lấy ngày hiện tại hệ thống(DateTime.Now.Date).
            //• Tính tuổi chính xác tính theo số năm.
            //• Xác định ngày sinh nhật tiếp theo trong năm nay hoặc năm sau.Tính số ngày còn lại đến sinh nhật đó.
            //• Hiển thị: Tuổi hiện tại, Tổng số ngày đã sống từ lúc sinh ra, và Số ngày còn lại đến sinh nhật kế tiếp.
            //Ví dụ minh họa Input / Output:
            //---INPUT-- -
            //Nhập ngày sinh(dd/ MM / yyyy): 15 / 09 / 2003
            //-- - OUTPUT-- -
            //Tuổi hiện tại: 22 tuổi
            //Bạn đã sống tổng cộng: 8,376 ngày
            //Sinh nhật tiếp theo còn: 25 ngày nữa
            CultureInfo us = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("------INPUT-----");
            DateTime ngaysinh;
            do
            {
                Console.WriteLine("Nhập ngày tháng năm sinh của bạn");
                string input = Console.ReadLine();
                bool ok = DateTime.TryParseExact(
                    input,
                    "dd/MM/yyyy",  //xem chuỗi text gõ vào
                    CultureInfo.InvariantCulture, //bỏ qua locate mỗi máy, thiết lập theo chuẩn cố định
                    DateTimeStyles.None,// thêm tuỳ chọn xử lý đặc biệt, none là k áp dụng tuỳ chọn nào thêm
                    out ngaysinh //nếu parse thành công, giá trị datetime dc trả về vào ngaysinh
);
                if (ok)
                    break;
                else
                    Console.WriteLine("Ngày không hợp lệ! Vui lòng nhập lại:");
            } while (true);
            Console.WriteLine("-----OUTPUT-----");
            DateTime homnay = DateTime.Now;
            int tuoi = homnay.Year - ngaysinh.Year;
            if (homnay.Month < ngaysinh.Month || homnay.Month == ngaysinh.Month && homnay.Day < ngaysinh.Day)
                tuoi--;
            TimeSpan songaysong = homnay - ngaysinh;
            int tongNgay = songaysong.Days;
            DateTime sinhnhat = new DateTime(homnay.Year, ngaysinh.Month, ngaysinh.Day);//Tạo object mới trong bộ nhớ
            if (sinhnhat < homnay)
                sinhnhat = sinhnhat.AddYears(1);
            int ngayconlai = (sinhnhat - homnay).Days;
            Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng:{tongNgay} ngày") ;
            Console.WriteLine($"Sinh nhật tiếp theo còn {ngayconlai} ngày");

        }
        static void Bai_5()
        {
            //            Kiểu float hoặc double, char, enum, ép kiểu điểm số, định dạng bảng xuất.
            //Yêu cầu bài toán:
            //• Nhập điểm số(thang 10, kiểu double) và số tín chỉ(int) của 3 môn học: Lập trình C#, Toán rời rạc, Tiếng
            //Anh.
            //• Tính điểm trung bình trọng số (Weighted Average Score):
            // Score_Avg = (Điểm1* TC1 + Điểm2* TC2 +Điểm3 * TC3) / (TC1 + TC2 + TC3).
            //• Quy đổi Score_Avg sang Điểm chữ(char/string) và Thang điểm 4 (double):
            //• + [8.5 - 10.0]: Điểm A | Thang 4: 4.0 | Xếp loại: Xuất sắc / Giỏi
            //BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
            //Trang 6 / 14
            //• + [7.0 - 8.4] : Điểm B | Thang 4: 3.0 | Xếp loại: Khá
            //• + [5.5 - 6.9] : Điểm C | Thang 4: 2.0 | Xếp loại: Trung bình
            //• + [4.0 - 5.4] : Điểm D | Thang 4: 1.0 | Xếp loại: Yếu
            //• + [< 4.0] : Điểm F | Thang 4: 0.0 | Xếp loại: Kém(Trượt)
            //• Xuất bảng điểm chi tiết và GPA làm tròn 2 chữ số thập phân.
            //Ví dụ minh họa Input / Output:
            //--- INPUT ---
            //C# (4 TC): 8.8
            //Toán (3 TC): 7.2
            //            Tiếng Anh(2 TC): 6.5
            //            -- - OUTPUT-- -
            //            Điểm TB Thang 10: 7.76
            //Điểm Chữ Quy Đổi: B
            //Điểm GPA Thang 4: 3.0
            //Xếp Loại Học Lực: Khá

            void Nhapmon(string tenMon, out double diemso, out int tinChi)
            {
                do
                {
                    Console.WriteLine($"Nhập điểm số môn {tenMon}:");
                    diemso = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Nhập số tín chỉ môn {tenMon}:");
                    tinChi = int.Parse(Console.ReadLine());
                    if (diemso > 0 && diemso <= 10 && tinChi > 0)
                        break;
                    else
                        Console.WriteLine("Bạn đã nhập sai! Thang điểm từ 0->10 và tín chỉ phải lớn hơn 0 Vui lòng nhập lại:");

                } while (true);
            }
                void Quydoi(double scoreAvg, out char diemchu, out double thangdiem, out string Xeploai)
                {
                    if (scoreAvg >= 8.5 && scoreAvg <= 10)
                    {
                        diemchu = 'A'; thangdiem = 4.0; Xeploai = "Xuất sắc/giỏi";
                    }

                    else if (scoreAvg >= 7 && scoreAvg <= 8.4)
                    {
                        diemchu = 'B'; thangdiem = 3.0; Xeploai = "Khá";
                    }

                    else if (scoreAvg >= 5.5 && scoreAvg <= 6.9)
                    {
                        diemchu = 'C'; thangdiem = 2.0; Xeploai = "Trung bình";
                    }

                    else if (scoreAvg >= 4 && scoreAvg <= 5.4)
                    {
                        diemchu = 'D'; thangdiem = 1.0; Xeploai = "Yếu";
                    }

                    else
                    {
                        diemchu = 'F'; thangdiem = 0.0; Xeploai = "Trượt";
                    }

                }

                Nhapmon("Lập trình C#", out double diemso1, out int tinChi1);
                Nhapmon("Toán rời rạc", out double diemso2, out int tinChi2);
                Nhapmon("Tiếng Anh", out double diemso3, out int tinChi3);
                double scoreAvg = (diemso1 * tinChi1 + diemso2 * tinChi2 + diemso3 * tinChi3) / (tinChi3 + tinChi2 + tinChi1);
                Quydoi(scoreAvg, out char diemchu, out double thangdiem, out string Xeploai);
            Console.WriteLine("-----OUTPUT-----");
            Console.WriteLine($"Điểm TB thang 10:{scoreAvg:F2}"); 
            Console.WriteLine($"Điểm chữ quy đổi:{diemchu}");
            Console.WriteLine($"Điểm GPA thang 4:{thangdiem}");
            Console.WriteLine($"Xếp loại học lực:{Xeploai}");
            }
        //hàm phụ trợ giúp bỏ dấu tiếng việt
        
        static void Bai_6()

        {
            //            Kiến thức trọng tâm: Kiểu string, các phương thức Trim(), Split(), Substring(), ToLower(), ToUpper(),
            //string.Join().
            //Yêu cầu bài toán:
            //• Nhập vào một chuỗi họ tên thô từ bàn phím(Ví dụ: " ngUYỄN vĂn aN ").
            //• Loại bỏ khoảng trắng thừa ở đầu, cuối và giữa các từ(chỉ giữ lại 1 khoảng trắng giữa các từ).
            //• Chuyển đổi chuỗi thành dạng Viết Hoa Chữ Cái Đầu Mỗi Từ(Title Case): "Nguyễn Văn An".
            //• Tách thành Họ, Tên Đệm và Tên chính.
            //• Tạo Username không dấu theo quy tắc: ten.hovatenm. (Ví dụ: an.nguyenvan).
            //• Tạo Email công ty: username + "@company.edu.vn"
            static string BoDauTiengViet(string s)
            {
                //tách rời chữ cái gốc và dấu thanh điệu thành 2 phần vd: â dc tách thành a +[dấu] ( 2 ký tự riêng )
                string ChuanHoa = s.Normalize(NormalizationForm.FormD);
                //tạo stringbuilder để ghép chuỗi kq
                StringBuilder sb = new StringBuilder();
                //duyệt qua từng ký tự trong chuỗi đã tách
                foreach (char c in ChuanHoa)
                {
                    //kiểm tra c có phải dấu hay k
                    //unicode....: loại danh mục dành cho các dấu k chiếm chỗ riêng
                    if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    {
                        sb.Append(c);
                    }
                    //Nếu là dấu thì k thêm vào sb
                }
                //chuyển stringbuildẻr về kiểu string bình thg
                //normalize về dạng C dạng chuẩn 1 chuỗi.
                string ketQua = sb.ToString().Normalize(NormalizationForm.FormC);
                ketQua = ketQua.Replace('đ', 'd').Replace('Đ', 'D');
                return ketQua;
            }

            Console.WriteLine("------INPUT-----");
            Console.WriteLine("Nhập họ và tên thô:");
            string input=Console.ReadLine();
            //Bước 1: Trim()+chuẩn hoá khoảng trắng giữa các từ/xoá khoảng trắng đầu cuối
            string buoc1 = input.Trim();
            string[] tachTam = buoc1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            buoc1 = string.Join(" ", tachTam);// ghép các phần tử trong mảng lại, chèn dấu " " giữa mỗi phần tử
            Console.WriteLine($"[Bước 1] Sau khi chuẩn hoá khoảng trắng: {buoc1}");
            //Bước 2: Viết hoa chữ đầu mỗi từ
            string[] tuList = buoc1.Split(' ');//tách chuỗi thành từng mảng từ riêng lẻ
            //Vòng lặp for chạy qua từng phân tử
            for (int i = 0; i < tuList.Length; i++)
            {
                string tuThuong = tuList[i].ToLower();// lấy từ vị trí i, bién tất cả thành in thường
                string kytuDau = tuThuong.Substring(0, 1).ToUpper();// lấy đúng kí tự đầu: t viết hoa T
                string phanConLai = tuThuong.Substring(1);// lấy phần còn lại của từ bắt đầu từ vị trí 1 tới hết
                tuList[i] = kytuDau + phanConLai; //  ghép lại r gắn lại đúng vị trí i trong mảng tuList
           
            }
            string buoc2 = string.Join (" ", tuList);// ghép lại thành chuỗi hoàn chỉnh, cách nhau bởi dấu cách
            Console.WriteLine($"[Bước 2] Sau khi chuyển Title case:\"{buoc2}\"");
            string[] parts = buoc2.Split(" "); // tách chuỗi bươc 2 thành từng từ
            string ho = parts[0];
            string tenChinh = parts[parts.Length - 1];
            string tenDem = string.Join(" ", parts, 1, parts.Length - 2);
            Console.WriteLine($"[Bước 3] Họ = {ho}, Tên đệm: {tenDem}, Tên Chính: {tenChinh}");
            //Bước 4: Bỏ dấu tiếng Việt, ghép username/email
            string tenChinhKhongDau = BoDauTiengViet(tenChinh).ToLower();
            string hoKhongDau = BoDauTiengViet(ho).ToLower();
            string TenDemKoDau = BoDauTiengViet(tenDem).ToLower().Replace(" ","");
            string username = $"{tenChinhKhongDau}.{hoKhongDau}{TenDemKoDau}{tenChinhKhongDau}";
            string email = $"{username}@company.edu.vn";
            Console.WriteLine($"[Bước 4] Username: {username}, email:{email}");
            Console.WriteLine();
            Console.WriteLine("-----OUTPUT------");
            Console.WriteLine($"Họ và tên chuẩn hoá: {buoc2}");
            Console.WriteLine($"Họ:{ho} | Tên đệm: {tenDem} | Tên: {tenChinh}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {email}");

        }
        
        public static void Main2344(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            //Bai_6();
            int luaChon;
            do
            {
                Console.WriteLine("===== MENU BÀI TẬP =====");
                Console.WriteLine("1. Bài 1 - Tính tiền điện");
                Console.WriteLine("2. Bài 2 - Tính BMI");
                Console.WriteLine("3. Bài 3 - Đổi ngoại tệ");
                Console.WriteLine("4. Bài 4 - Tính tuổi");
                Console.WriteLine("5. Bài 5 - Điểm trung bình");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn bài muốn chạy: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1: Bai_1(); break;
                    case 2: Bai_2(); break;
                    case 3: Bai_3(); break;
                    case 4: Bai_4(); break;
                    case 5: Bai_5(); break;
                    case 6: Bai_6(); break;
                    case 0: Console.WriteLine("Tạm biệt!"); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }

            } while (luaChon != 0);
            Console.WriteLine("*****PRESS ANY KEY TO EXIT*****");
        }
        
    }
}
