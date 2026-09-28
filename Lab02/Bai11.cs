using System;
using System.Text;

namespace Lab02 {
    class SinhVien {
        //Field (dung de luu tru du lieu)
        private string hoTen;
        private int namSinh;

        //Constructor (khoi tao doi tuong va gan gia tri ban dau cho field)
        public SinhVien() {
            hoTen = "";
            namSinh = DateTime.Now.Year;
        }
        
        public SinhVien(string hoTen, int namSinh) {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }

        //Property (kiem tra du lieu, phuogn thuc get, set)
        public string HoTen {
            get { return hoTen; }
            set { hoTen = value.Trim(); }
        }

        public int NamSinh {
            get { return namSinh; }
            set {
                int namHienTai = DateTime.Now.Year;
                if (value > 1990 && value <= namHienTai) {
                    namSinh = value;
                } else {
                    Console.WriteLine("Vui long nhap tu 1990 den nam hien tai.");
                }
            }
        }

        //Method (cac phuong thuc)
        public void Nhap() {
            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine();
            while(true) { //Kiem tra nhap dung so nguyen
                Console.Write("Nhap nam sinh: ");
                if(int.TryParse(Console.ReadLine(), out int ns)) {
                    NamSinh = ns;
                    if(namSinh != 0) break;
                } else {
                    Console.WriteLine("Vui long nhap mot so nguyen.");
                }
            }
        }

        public int TinhTuoi() { //Phuong thuc tinh tuoi
            return DateTime.Now.Year - namSinh;
        }

        public void Xuat() {
            Console.WriteLine($"Ho va ten: {hoTen}");
            Console.WriteLine($"Nam sinh: {namSinh}");
            Console.WriteLine($"Tuoi: {TinhTuoi()}");
        }
    }

    class Bai11 {
        public static void Run() {
            SinhVien sv = new SinhVien();
            Console.WriteLine("=== NHAP THONG TIN SINH VIEN ===");
            sv.Nhap();
            Console.WriteLine("=== THONG TIN SINH VIEN ===");
            sv.Xuat();
        }
    }
}