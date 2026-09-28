using System;
using System.Collections.Generic;

namespace Lab02 {
    class MaTran {
        //Field
        private int[,] a;

        //Constructor
        public MaTran() {
            a = new int[0, 0];
        }

        public MaTran(int n, int m) {
            a = new int[n, m];
        }

        public MaTran(MaTran other) {
            int n = other.SoDong, m = other.SoCot;
            a = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = other.a[i, j];
        }

        //Property
        public int SoDong {
            get { return a.GetLength(0); }
        }

        public int SoCot {
            get { return a.GetLength(1); }
        }

        //Indexer, truy cap phan tu (i, j)
        public int this[int i, int j] {
            get {
                KiemTraChiSo(i, j);
                return a[i, j];
            }
            set {
                KiemTraChiSo(i, j);
                a[i, j] = value;
            }
        }

        private void KiemTraChiSo(int i, int j) {
            if (i < 0 || i >= SoDong || j < 0 || j >= SoCot) {
                throw new IndexOutOfRangeException("Chi so vuot pham vi.");
            }
        }

        //Method
        public void Input() {
            int n = NhapLieu.SoNguyen("Nhap so dong n: ", 1);
            int m = NhapLieu.SoNguyen("Nhap so cot m: ", 1);
            a = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = NhapLieu.SoNguyen($"a[{i},{j}] = ");
        }

        public void Output() {
            for (int i = 0; i < SoDong; i++) {
                for (int j = 0; j < SoCot; j++) {
                    Console.Write($"{a[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        private static bool LaSoNguyenTo(int x) { //Kt So nguyen to
            if (x < 2) return false;
            for (int k = 2; k * k <= x; k++) {
                if (x % k == 0) return false;
            }
            return true;
        }

        public List<int> TimSoNguyenTo() {
            List<int> kq = new List<int>();
            foreach (int x in a) { //Foreach duyet het mang 2 chieu
                if (LaSoNguyenTo(x)) {
                    kq.Add(x);
                }
            }
            return kq;
        }
    }

    class Bai24 {
        public static void Run() {
            MaTran mt = new MaTran();
            mt.Input();

            Console.WriteLine("=== MA TRAN ===");
            mt.Output();

            List<int> nt = mt.TimSoNguyenTo();
            if (nt.Count == 0) {
                Console.WriteLine("Khong co so nguyen to.");
            } else {
                Console.WriteLine("Cac so nguyen to: " + string.Join(" ", nt));
            }

            Console.WriteLine($"Dung indexer: mt[0, 0] = {mt[0, 0]}");
        }
    }
}