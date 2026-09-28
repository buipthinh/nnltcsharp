using System;
namespace Lab02 {
    class PhanSo {
        //Field
        private int tu;
        private int mau;

        //Constructor
        public PhanSo() {
            tu = 0;
            mau = 1; //Mau = 0 thi phan so se vo nghia
        }

        public PhanSo(PhanSo p) { //Constructor sao chep
            tu = p.tu;
            mau = p.mau;
        }

        public PhanSo(int tu) {
            this.tu = tu;
            mau = 1;
        }

        public PhanSo(int tu, int mau) {
            if (mau == 0) {
                throw new DivideByZeroException("Mau so phai khac 0.");
            }
            this.tu = tu;
            this.mau = mau;
            RutGon();
        }

        //Property
        public int Tu {
            get { return tu; }
            set { tu = value; RutGon(); }
        }

        public int Mau {
            get { return mau; }
            set {
                if(value != 0) {
                    mau = value;
                    RutGon();
                } else {
                    Console.WriteLine("Mau so phai khac 0.");
                }
            }
        }

        //Method
        private static int UCLN(int a, int b) {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0) {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
 
        //Rut gon va dua dau am len tu so (mau luon duong)
        private void RutGon() {
            if (mau < 0) {
                tu = -tu;
                mau = -mau;
            }
            int u = UCLN(tu, mau);
            if (u != 0) {
                tu /= u;
                mau /= u;
            }
        }
 
        public void Input() {
            while (true) {
                Console.Write("Nhap tu so: ");
                if (int.TryParse(Console.ReadLine(), out int t)) {
                    tu = t;
                    break;
                }
                Console.WriteLine("Vui long nhap so nguyen.");
            }
            while (true) {
                Console.Write("Nhap mau so: ");
                if (int.TryParse(Console.ReadLine(), out int m) && m != 0) {
                    mau = m;
                    break;
                }
                Console.WriteLine("Mau so phai la so nguyen khac 0.");
            }
            RutGon();
        }
 
        public override string ToString() {
            if (mau == 1) return $"{tu}";
            return $"{tu}/{mau}";
        }

        //Toan tu hai ngoi
        public static PhanSo operator +(PhanSo a) {
            return new PhanSo(a);
        }

        public static PhanSo operator -(PhanSo a) {
            return new PhanSo(-a.tu, a.mau);
        }
        
        public static PhanSo operator +(PhanSo a, PhanSo b) {
            return new PhanSo(a.tu * b.mau + b.tu * a.mau, a.mau * b.mau);
        }
 
        public static PhanSo operator -(PhanSo a, PhanSo b) {
            return new PhanSo(a.tu * b.mau - b.tu * a.mau, a.mau * b.mau);
        }
 
        public static PhanSo operator *(PhanSo a, PhanSo b) {
            return new PhanSo(a.tu * b.tu, a.mau * b.mau);
        }
 
        public static PhanSo operator /(PhanSo a, PhanSo b) {
            if (b.tu == 0) {
                throw new DivideByZeroException("Khong the chia cho phan so bang 0.");
            }
            return new PhanSo(a.tu * b.mau, a.mau * b.tu);
        }
 
        //Toan tu so sanh (mau luon duong nen nhan cheo duoc)
        public static bool operator >(PhanSo a, PhanSo b) {
            return a.tu * b.mau > b.tu * a.mau;
        }
 
        public static bool operator <(PhanSo a, PhanSo b) {
            return a.tu * b.mau < b.tu * a.mau;
        }
 
        public static bool operator >=(PhanSo a, PhanSo b) {
            return a.tu * b.mau >= b.tu * a.mau;
        }
 
        public static bool operator <=(PhanSo a, PhanSo b) {
            return a.tu * b.mau <= b.tu * a.mau;
        }
 
        public static bool operator ==(PhanSo a, PhanSo b) {
            return a.tu * b.mau == b.tu * a.mau;
        }
 
        public static bool operator !=(PhanSo a, PhanSo b) {
            return !(a == b);
        }
 
        //Khi overload == va != thi nen override Equals va GetHashCode
        public override bool Equals(object obj) {
            if (obj is PhanSo p) return this == p;
            return false;
        }
 
        public override int GetHashCode() {
            return tu.GetHashCode() ^ mau.GetHashCode();
        }
}
 
    class BT14 {
        public static void Run() {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();
 
            Console.WriteLine("Nhap phan so a:");
            a.Input();
            Console.WriteLine("Nhap phan so b:");
            b.Input();
 
            Console.WriteLine($"a = {a}, b = {b}");
 
            Console.WriteLine("=== MOT NGOI ===");
            Console.WriteLine($"+a = {+a}");
            Console.WriteLine($"-a = {-a}");
 
            Console.WriteLine("=== HAI NGOI ===");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            if (b.Tu != 0) {
                Console.WriteLine($"a / b = {a / b}");
            } else {
                Console.WriteLine("a / b = khong chia duoc (b = 0)");
            }
 
            Console.WriteLine("=== SO SANH ===");
            Console.WriteLine($"a > b  : {a > b}");
            Console.WriteLine($"a < b  : {a < b}");
            Console.WriteLine($"a >= b : {a >= b}");
            Console.WriteLine($"a <= b : {a <= b}");
            Console.WriteLine($"a == b : {a == b}");
            Console.WriteLine($"a != b : {a != b}");
 
            //Thu cac constructor khac
            PhanSo c = new PhanSo(a);
            PhanSo d = new PhanSo(5);
            PhanSo e = new PhanSo(6, -8);
            Console.WriteLine("=== CONSTRUCTOR ===");
            Console.WriteLine($"Sao chep a: {c}");
            Console.WriteLine($"new PhanSo(5): {d}");
            Console.WriteLine($"new PhanSo(6, -8): {e}");
        }
    }
}