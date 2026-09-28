using System;
using System.Collections.Generic;

namespace Lab02 {
    class DayPhanSo {
        //Field
        private List<PhanSo> ds;

        //Constructor
        public DayPhanSo() {
            ds = new List<PhanSo>();
        }

        public DayPhanSo(DayPhanSo other) {
            ds = new List<PhanSo>();
            foreach (PhanSo p in other.ds) {
                ds.Add(new PhanSo(p));
            }
        }

        //Property
        public int Count {
            get { return ds.Count; }
        }

        //Indexer
        public PhanSo this[int i] {
            get { return ds[i]; }
            set { ds[i] = value; }
        }

        //Method
        public void Input() {
            int n = NhapLieu.SoNguyen("Nhap so phan so n: ", 1);
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Phan so thu {i + 1}:");
                PhanSo p = new PhanSo();
                p.Input();
                ds.Add(p);
            }
        }

        public void Output() {
            Console.WriteLine(string.Join("   ", ds));
        }

        public PhanSo Tong() {
            PhanSo tong = new PhanSo(); //Mau so phai la 0/1
            foreach (PhanSo p in ds) {
                tong = tong + p; //Dung toan tu + da overload o Bai 1.4
            }
            return tong;
        }
    }

    class Bai26 {
        public static void Run() {
            DayPhanSo d = new DayPhanSo();
            d.Input();

            Console.Write("Day phan so: ");
            d.Output();
            Console.WriteLine($"Tong = {d.Tong()}");
        }
    }
}