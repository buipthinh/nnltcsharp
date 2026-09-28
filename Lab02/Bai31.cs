using System;
using System.Collections.Generic;

namespace Lab02 {
    // Lop HocSinh cai dat interface IComparable<HocSinh>
    class HocSinh : IComparable<HocSinh> {
        //Field
        private string hoTen;
        private double diem;

        //Constructor
        public HocSinh() {
            hoTen = "";
            diem = 0;
        }

        public HocSinh(string hoTen, double diem) {
            this.hoTen = hoTen;
            this.diem = diem;
        }

        //Property
        public string HoTen {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public double Diem {
            get { return diem; }
            set { diem = value; }
        }

        //Cai dat interface: tra ve < 0 neu this dung truoc, > 0 neu dung sau, 0 neu bang nhau
        public int CompareTo(HocSinh? other) {
            if (other == null) return 1;
            return diem.CompareTo(other.diem);
        }

        public override string ToString() {
            return $"{hoTen,-15}{diem,5}";
        }
    }

    // Lop so sanh rieng (IComparer): sap xep theo ten
    class SoSanhTheoTen : IComparer<HocSinh> {
        public int Compare(HocSinh? x, HocSinh? y) {
            if (x == null || y == null) return 0;
            return string.Compare(x.HoTen, y.HoTen);
        }
    }

    class Bai31 {
        static void Xuat(HocSinh[] ds) {
            foreach (HocSinh hs in ds) {
                Console.WriteLine(hs);
            }
        }

        public static void Run() {
            HocSinh[] ds = {
                new HocSinh("Tran Van An", 7.5),
                new HocSinh("Le Thi Binh", 9.0),
                new HocSinh("Nguyen Van Cuong", 5.5),
                new HocSinh("Pham Thi Dung", 8.0)
            };

            Console.WriteLine("=== BAN DAU ===");
            Xuat(ds);

            Array.Sort(ds); //Dung CompareTo cua HocSinh
            Console.WriteLine("=== SAP THEO DIEM (IComparable) ===");
            Xuat(ds);

            Array.Sort(ds, new SoSanhTheoTen());  //Dung IComparer
            Console.WriteLine("=== SAP THEO TEN (IComparer) ===");
            Xuat(ds);
        }
    }
}