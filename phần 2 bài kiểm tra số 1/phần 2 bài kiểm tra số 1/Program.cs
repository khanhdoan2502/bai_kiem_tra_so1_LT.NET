using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoSpeedManagement
{
    // A. Abstract Class PhuongTien (Lop cha tru tuong)
    public abstract class PhuongTien
    {
        private string _maPT;
        private string _tenHang;
        private int _namSanXuat;
        private decimal _giaGoc;

        public string MaPT
        {
            get => string.IsNullOrWhiteSpace(_maPT) ? "PT000" : _maPT;
            set => _maPT = string.IsNullOrWhiteSpace(value) ? "PT000" : value.Replace(" ", "");
        }

        public string TenHang
        {
            get => _tenHang;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ten hang khong duoc de trong!");
                _tenHang = value;
            }
        }

        public int NamSanXuat
        {
            get => _namSanXuat;
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("Nam san xuat khong hop le!");
                _namSanXuat = value;
            }
        }

        public decimal GiaGoc
        {
            get => _giaGoc;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Gia goc phai lon hon 0!");
                _giaGoc = value;
            }
        }

        protected PhuongTien(string maPT, string tenHang, int namSanXuat, decimal giaGoc)
        {
            MaPT = maPT;
            TenHang = tenHang;
            NamSanXuat = namSanXuat;
            GiaGoc = giaGoc;
        }

        public abstract decimal TinhGiaLanBanh();

        public virtual string GetInfo()
        {
            return $"Ma: {MaPT} | Hang: {TenHang} | Nam SX: {NamSanXuat} | Gia goc: {GiaGoc:N0} VND";
        }
    }

    // B. Class OTo ke thua tu PhuongTien
    public class OTo : PhuongTien
    {
        public int SoChoNgoi { get; set; }
        public double DungTichDongCo { get; set; }

        public OTo(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int soChoNgoi, double dungTichDongCo)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            if (soChoNgoi <= 0 || dungTichDongCo <= 0)
                throw new ArgumentException("So cho ngoi va dung tich dong co phai lon hon 0!");
            SoChoNgoi = soChoNgoi;
            DungTichDongCo = dungTichDongCo;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (SoChoNgoi <= 9)
            {
                // Truoc ba 12% + Tieu thu dac biet 30%
                return GiaGoc + (GiaGoc * 0.12m) + (GiaGoc * 0.30m);
            }
            else
            {
                // Truoc ba 10%
                return GiaGoc + (GiaGoc * 0.10m);
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" | O to: {SoChoNgoi} cho, {DungTichDongCo}L | Gia lan banh: {TinhGiaLanBanh():N0} VND";
        }
    }

    // C. Class XeMay ke thua tu PhuongTien
    public class XeMay : PhuongTien
    {
        public int DungTichXylanh { get; set; }

        public XeMay(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int dungTichXylanh)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            if (dungTichXylanh <= 0)
                throw new ArgumentException("Dung tich xi-lanh phai lon hon 0!");
            DungTichXylanh = dungTichXylanh;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (DungTichXylanh < 175)
            {
                // Truoc ba 2%
                return GiaGoc + (GiaGoc * 0.02m);
            }
            else
            {
                // Truoc ba 5%
                return GiaGoc + (GiaGoc * 0.05m);
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" | Xe may: {DungTichXylanh}cc | Gia lan banh: {TinhGiaLanBanh():N0} VND";
        }
    }

    // D. Class QuanLyPhuongTien (Quan ly Tap hop)
    public class QuanLyPhuongTien
    {
        private List<PhuongTien> _danhSach = new List<PhuongTien>();

        public void AddPhuongTien(PhuongTien pt)
        {
            _danhSach.Add(pt);
        }

        public void DisplayAll()
        {
            foreach (var pt in _danhSach)
            {
                Console.WriteLine(pt.GetInfo());
            }
        }

        public PhuongTien FindMaxGiaLanBanh()
        {
            if (!_danhSach.Any()) return null;
            return _danhSach.OrderByDescending(p => p.TinhGiaLanBanh()).First();
        }

        public List<PhuongTien> SearchByName(string keyword)
        {
            return _danhSach.Where(p => p.TenHang.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }

    // Chuong trinh tuong tac nhap xuat tu ban phim (khong dau)
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyPhuongTien ql = new QuanLyPhuongTien();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("       HE THONG QUAN LY PHUONG TIEN AUTOSPEED     ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Them moi O to");
                Console.WriteLine("2. Them moi Xe may");
                Console.WriteLine("3. Hien thi danh sach phuong tien & Gia lan banh");
                Console.WriteLine("4. Tim phuong tien co Gia lan banh cao nhat");
                Console.WriteLine("5. Tim kiem phuong tien theo Ten hang");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine("==================================================");
                Console.Write("Nhap lua chon cua ban (0-5): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Nhap ma phuong tien: ");
                            string maOTo = Console.ReadLine();
                            Console.Write("Nhap ten hang: ");
                            string hangOTo = Console.ReadLine();
                            Console.Write("Nhap nam san xuat: ");
                            int namOTo = int.Parse(Console.ReadLine());
                            Console.Write("Nhap gia goc (VND): ");
                            decimal giaOTo = decimal.Parse(Console.ReadLine());
                            Console.Write("Nhap so cho ngoi: ");
                            int choNgoi = int.Parse(Console.ReadLine());
                            Console.Write("Nhap dung tich dong co (L): ");
                            double dungTich = double.Parse(Console.ReadLine());

                            OTo oto = new OTo(maOTo, hangOTo, namOTo, giaOTo, choNgoi, dungTich);
                            ql.AddPhuongTien(oto);
                            Console.WriteLine("-> Them O to thanh cong!");
                            break;

                        case "2":
                            Console.Write("Nhap ma phuong tien: ");
                            string maXM = Console.ReadLine();
                            Console.Write("Nhap ten hang: ");
                            string hangXM = Console.ReadLine();
                            Console.Write("Nhap nam san xuat: ");
                            int namXM = int.Parse(Console.ReadLine());
                            Console.Write("Nhap gia goc (VND): ");
                            decimal giaXM = decimal.Parse(Console.ReadLine());
                            Console.Write("Nhap dung tich xi-lanh (cc): ");
                            int xiLanh = int.Parse(Console.ReadLine());

                            XeMay xeMay = new XeMay(maXM, hangXM, namXM, giaXM, xiLanh);
                            ql.AddPhuongTien(xeMay);
                            Console.WriteLine("-> Them Xe may thanh cong!");
                            break;

                        case "3":
                            Console.WriteLine("--- DANH SACH PHUONG TIEN ---");
                            ql.DisplayAll();
                            break;

                        case "4":
                            Console.WriteLine("--- PHUONG TIEN CO GIA LAN BANH CAO NHAT ---");
                            var maxPt = ql.FindMaxGiaLanBanh();
                            if (maxPt != null)
                                Console.WriteLine(maxPt.GetInfo());
                            else
                                Console.WriteLine("Danh sach trong!");
                            break;

                        case "5":
                            Console.Write("Nhap tu khoa ten hang can tim: ");
                            string keyword = Console.ReadLine();
                            var results = ql.SearchByName(keyword);
                            Console.WriteLine($"--- KET QUA TIM KIEM ('{keyword}') ---");
                            if (results.Any())
                            {
                                foreach (var item in results)
                                    Console.WriteLine(item.GetInfo());
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay phuong tien nao phu hop!");
                            }
                            break;

                        case "0":
                            running = false;
                            Console.WriteLine("Dang thoat chuong trinh. Tam biet!");
                            break;

                        default:
                            Console.WriteLine("Lua chon khong hop le! Vui long chon tu 0 den 5.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[LOI DU LIEU]: {ex.Message}");
                }

                if (running)
                {
                    Console.WriteLine("\nNhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }
            }
        }
    }
}