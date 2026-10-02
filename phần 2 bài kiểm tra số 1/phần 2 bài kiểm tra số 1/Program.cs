using System;
using System.Collections.Generic;
using System.Linq;

namespace LogisticsAutoSpeed
{
    public abstract class PhuongTien
    {
        private string _maPT;
        private string _tenHang;
        private int _namSanXuat;
        private decimal _giaGoc;

        public string MaPT
        {
            get => _maPT;
            set => _maPT = string.IsNullOrWhiteSpace(value) ? "PT000" : value.Trim();
        }

        public string TenHang
        {
            get => _tenHang;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên hãng không được để trống!");
                _tenHang = value.Trim();
            }
        }

        public int NamSanXuat
        {
            get => _namSanXuat;
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("Năm sản xuất không hợp lệ!");
                _namSanXuat = value;
            }
        }

        public decimal GiaGoc
        {
            get => _giaGoc;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Giá gốc phải lớn hơn 0!");
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
            return $"Mã PT: {MaPT} | Hãng: {TenHang} | Năm SX: {NamSanXuat} | Giá gốc: {GiaGoc:N0} VNĐ";
        }
    }

    public class OTo : PhuongTien
    {
        public int SoChoNgoi { get; set; }
        public double DungTichDongCo { get; set; }

        public OTo(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int soChoNgoi, double dungTichDongCo)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            if (soChoNgoi <= 0 || dungTichDongCo <= 0)
                throw new ArgumentException("Số chỗ ngồi và dung tích động cơ phải > 0!");

            SoChoNgoi = soChoNgoi;
            DungTichDongCo = dungTichDongCo;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (SoChoNgoi <= 9)
                return GiaGoc + (GiaGoc * 0.12m) + (GiaGoc * 0.30m);
            else
                return GiaGoc + (GiaGoc * 0.10m);
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" | Số chỗ: {SoChoNgoi} | Dung tích động cơ: {DungTichDongCo}L | Giá lăn bánh: {TinhGiaLanBanh():N0} VNĐ";
        }
    }

    public class XeMay : PhuongTien
    {
        public int DungTichXylanh { get; set; }

        public XeMay(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int dungTichXylanh)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            if (dungTichXylanh <= 0)
                throw new ArgumentException("Dung tích xi lanh phải > 0!");

            DungTichXylanh = dungTichXylanh;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (DungTichXylanh < 175)
                return GiaGoc + (GiaGoc * 0.02m);
            else
                return GiaGoc + (GiaGoc * 0.05m);
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" | Dung tích: {DungTichXylanh}cc | Giá lăn bánh: {TinhGiaLanBanh():N0} VNĐ";
        }
    }

    public class QuanLyPhuongTien
    {
        private readonly List<PhuongTien> _danhSachPT = new List<PhuongTien>();

        public void AddPhuongTien(PhuongTien pt)
        {
            _danhSachPT.Add(pt);
            Console.WriteLine($"=> Đã thêm thành công: {pt.TenHang}");
        }

        public void DisplayAll()
        {
            if (!_danhSachPT.Any())
            {
                Console.WriteLine("Danh sách phương tiện đang trống.");
                return;
            }

            foreach (var pt in _danhSachPT)
            {
                Console.WriteLine(pt.GetInfo());
            }
        }

        public PhuongTien FindMaxGiaLanBanh()
        {
            return _danhSachPT.OrderByDescending(pt => pt.TinhGiaLanBanh()).FirstOrDefault();
        }

        public List<PhuongTien> SearchByName(string keyword)
        {
            return _danhSachPT.Where(pt => pt.TenHang.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            QuanLyPhuongTien qlpt = new QuanLyPhuongTien();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n=== HỆ THỐNG QUẢN LÝ PHƯƠNG TIỆN LOGISTICS AUTOSPEED ===");
                Console.WriteLine("1. Thêm Ô tô");
                Console.WriteLine("2. Thêm Xe máy");
                Console.WriteLine("3. Hiển thị danh sách phương tiện");
                Console.WriteLine("4. Tìm phương tiện có Giá lăn bánh cao nhất");
                Console.WriteLine("5. Tìm phương tiện theo tên hãng");
                Console.WriteLine("0. Thoát");
                Console.Write("Vui lòng chọn chức năng: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("\n-- THÊM Ô TÔ --");
                            Console.Write("Mã PT: "); string maOto = Console.ReadLine();
                            Console.Write("Tên Hãng: "); string hangOto = Console.ReadLine();
                            Console.Write("Năm sản xuất: "); int namOto = int.Parse(Console.ReadLine());
                            Console.Write("Giá gốc (VNĐ): "); decimal giaOto = decimal.Parse(Console.ReadLine());
                            Console.Write("Số chỗ ngồi: "); int choNgoi = int.Parse(Console.ReadLine());
                            Console.Write("Dung tích động cơ (L): "); double dungTichOto = double.Parse(Console.ReadLine());

                            OTo oto = new OTo(maOto, hangOto, namOto, giaOto, choNgoi, dungTichOto);
                            qlpt.AddPhuongTien(oto);
                        }
                        catch (Exception ex) { Console.WriteLine($"=> LỖI: {ex.Message}"); }
                        break;

                    case "2":
                        try
                        {
                            Console.WriteLine("\n-- THÊM XE MÁY --");
                            Console.Write("Mã PT: "); string maXeMay = Console.ReadLine();
                            Console.Write("Tên Hãng: "); string hangXeMay = Console.ReadLine();
                            Console.Write("Năm sản xuất: "); int namXeMay = int.Parse(Console.ReadLine());
                            Console.Write("Giá gốc (VNĐ): "); decimal giaXeMay = decimal.Parse(Console.ReadLine());
                            Console.Write("Dung tích xi lanh (cc): "); int dungTichXM = int.Parse(Console.ReadLine());

                            XeMay xeMay = new XeMay(maXeMay, hangXeMay, namXeMay, giaXeMay, dungTichXM);
                            qlpt.AddPhuongTien(xeMay);
                        }
                        catch (Exception ex) { Console.WriteLine($"=> LỖI: {ex.Message}"); }
                        break;

                    case "3":
                        Console.WriteLine("\n-- DANH SÁCH PHƯƠNG TIỆN --");
                        qlpt.DisplayAll();
                        break;

                    case "4":
                        Console.WriteLine("\n-- PHƯƠNG TIỆN CÓ GIÁ LĂN BÁNH CAO NHẤT --");
                        var ptMax = qlpt.FindMaxGiaLanBanh();
                        Console.WriteLine(ptMax != null ? ptMax.GetInfo() : "Danh sách trống!");
                        break;

                    case "5":
                        Console.Write("\nNhập tên hãng cần tìm: ");
                        string keyword = Console.ReadLine();
                        var kqTimKiem = qlpt.SearchByName(keyword);
                        if (kqTimKiem.Count > 0)
                        {
                            Console.WriteLine($"Tìm thấy {kqTimKiem.Count} phương tiện:");
                            kqTimKiem.ForEach(pt => Console.WriteLine(pt.GetInfo()));
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy phương tiện nào khớp với từ khóa.");
                        }
                        break;

                    case "0":
                        isRunning = false;
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}