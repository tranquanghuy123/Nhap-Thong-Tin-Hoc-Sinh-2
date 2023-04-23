using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapThongTinSinhVien
{
    public class Hocsinh
    {
        public string Hoten;
        public double DiemToan;
        public double DiemVan;
        public double DiemAnhVan;
        public double DiemTrungbinh;
    }
    internal class Program
    {
        
            public static void NhapThongTinHocSinh()
            {
                Hocsinh hs = new Hocsinh();
                Console.Write("Nhap ho ten hoc sinh: ");
                hs.Hoten = Console.ReadLine();
                Console.Write("Nhap diem toan: ");
                hs.DiemToan = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem van: ");
                hs.DiemVan = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem anh van: ");
                hs.DiemAnhVan = double.Parse(Console.ReadLine());
                hs.DiemTrungbinh = (hs.DiemToan + hs.DiemVan + hs.DiemAnhVan) / 3;
                Console.WriteLine("Diem trung binh cua hoc sinh la: " + hs.DiemTrungbinh);
                Console.WriteLine("======================");
            }
            public static void XuatThongTinHocSinh()
            {
            Hocsinh hs = new Hocsinh();
                Console.WriteLine("Thong tin hoc sinh:");
                Console.WriteLine("Ho ten: " + hs.Hoten);
                Console.WriteLine("Diem Toan: " + hs.DiemToan);
                Console.WriteLine("Diem Van: " + hs.DiemVan);
                Console.WriteLine("Diem Anh Van: " + hs.DiemAnhVan);
                Console.WriteLine("Diem Trung Binh: " + hs.DiemTrungbinh);
            }
            //public void DiemTrungBinhCaoNhat()
            //{
            //    Console.WriteLine("Hoc sinh co Diem Trung Binh cao nhat: ");
            //    //int max = a[0];
            //    //for (int i = 1; i < n; i++)
            //    //    if (a[i] > max)
            //    //        max = a[i];
            //    //cout << "max = " << max << endl;
            //    //return max;
            //    //int Max = DiemTrungBinhCaoNhat();
            //}



            static void Main(string[] args)
            {
                //Khởi tạo danh sách học sinh
                List<Hocsinh> listhocsinh = new List<Hocsinh>();
                Console.Write("Nhap so luong hoc sinh: ");
                string SoLuongHocSinh = Console.ReadLine();

                // Kiểm tra chữ số nhập vào có phải số nguyên hay k
                int KiemTraSoNguyen = int.Parse(SoLuongHocSinh);

            //Thực hiện vòng lặp để nhập thông tin học sinh
            for (int i = 0; i < KiemTraSoNguyen; i++)
                {
                 Console.WriteLine("Thong tin hoc sinh thu " + (i + 1));
                Program.NhapThongTinHocSinh();
                }

            //Thực hiện vòng lặp để xuất ra thông tin học sinh
            foreach (Hocsinh hs in listhocsinh) 
            {
                Program.XuatThongTinHocSinh();
            }

            //Sắp xếp theo ddiemr trung bình từ thấp đến cao

            listhocsinh.Sort(
                 (p1, p2) =>
                    {
                        if (p1.DiemTrungbinh == p2.DiemTrungbinh) return 0;
                       if (p1.DiemTrungbinh < p2.DiemTrungbinh) return -1;
                        return 1;
                    }
                   );
             //In ra màn hình điểm trung bình từ thấp đến cao
                Console.WriteLine("====================");
                Console.WriteLine("Diem TB tu thap den cao:");

            //Thực hiện vòng lặp để xuất thông tin học sinh
                foreach (Hocsinh hs in listhocsinh)
                {
                   Console.WriteLine($"{hs.Hoten} - {hs.DiemTrungbinh}");
                }
            // Xuất ra màn hình học sinh có điểm trung bình cao nhất
        }
                
    }
}

