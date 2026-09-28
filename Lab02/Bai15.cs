using System;

namespace Lab02 {
    class DonThuc {
        //Field: P(x) = a * x^n
        private double a;
        private int n;

        //Constructor
        public DonThuc() {
            a = 0;
            n = 0;
        }

        public DonThuc(double a, int n) {
            this.a = a;
            this.n = n >= 0 ? n : 0;
        }

        public DonThuc(DonThuc p) {
            a = p.a;
            n = p.n;
        }

        //Property
        public double A {
            get { return a; }
            set { a = value; }
        }

        public int N {
            get { return n; }
            set {
                if (value >= 0) {
                    n = value;
                } else {
                    Console.WriteLine("Bac n phai la so nguyen khong am.");
                }
            }
        }

        //Method
        public void Input() {
            while (true) {
                Console.Write("Nhap he so a: ");
                if (double.TryParse(Console.ReadLine(), out double ha)) {
                    A = ha;
                    break;
                }
                Console.WriteLine("Vui long nhap mot so thuc.");
            }

            n = -1;
            while (true) {
                Console.Write("Nhap bac n: ");
                if (int.TryParse(Console.ReadLine(), out int bn)) {
                    N = bn;
                    if (n != -1) break;
                } else {
                    Console.WriteLine("Vui long nhap so nguyen.");
                }
            }
        }

        public void Output() {
            Console.WriteLine(ToString());
        }

        public override string ToString() {
            if (n == 0) return $"{a}";
            if (n == 1) return $"{a}x";
            return $"{a}x^{n}";
        }

        //(a) Tinh gia tri P(x) = a * x^n
        public double TinhGiaTri(double x) {
            return a * Math.Pow(x, n);
        }

        //(b) Dao ham: P'(x) = a*n * x^(n-1)
        public DonThuc DaoHam() {
            if (n == 0) {
                return new DonThuc(0, 0);   // dao ham hang so = 0
            }
            return new DonThuc(a * n, n - 1);
        }
    }

    class Bai15 {
        public static void Run() {
            DonThuc p = new DonThuc();
            Console.WriteLine("=== NHAP DON THUC P(x) = a.x^n ===");
            p.Input();
            Console.WriteLine($"P(x) = {p}");

            //(a)
            double x;
            while (true) {
                Console.Write("Nhap x: ");
                if (double.TryParse(Console.ReadLine(), out x)) break;
                Console.WriteLine("Vui long nhap mot so thuc.");
            }
            Console.WriteLine($"(a) P({x}) = {p.TinhGiaTri(x)}");

            //(b)
            DonThuc q = p.DaoHam();
            Console.WriteLine($"(b) Q(x) = P'(x) = {q}");
        }
    }
}