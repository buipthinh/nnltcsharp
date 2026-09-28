using System;

namespace Lab02 {
    class Point {
        //Field
        private double x;
        private double y;

        //Constructor
        public Point() {
            x = 0;
            y = 0;
        }
        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }

        //Property
        public double X {
            get { return x; }
            set { x = value; }
        }
        public double Y {
            get { return y; }
            set { y = value; }
        }

        //Method
        public void Input() {
            while (true) {
                Console.Write("Nhap vao x: ");
                if(double.TryParse(Console.ReadLine(), out double nx)) {
                    X = nx;
                    break;
                }
                Console.WriteLine("Vui long nhap mot so.");
            }
            while (true) {
                Console.Write("Nhap vao y: ");
                if(double.TryParse(Console.ReadLine(), out double ny)) {
                    Y = ny;
                    break;
                }
                Console.WriteLine("Vui long nhap mot so.");
            }
        }

        public void Output() {
            Console.WriteLine(ToString());
        }

        //Override ToString
        public override string ToString() {
            return $"({x}, {y})";
        }

        //Phep toan
        public static Point operator +(Point a, Point b) { //Phep toan cong
            return new Point(a.x + b.x, a.y + b.y);
        }
 
        public static Point operator -(Point a, Point b) { //Phep toan tru
            return new Point(a.x - b.x, a.y - b.y);
        }
 
        public static Point operator -(Point a) { //Phep toan lay am
            return new Point(-a.x, -a.y);
        }

        //(a) Khoang cach - phuong thuc thanh vien
        public double KhoangCach(Point p) {
            double dx = x - p.x;
            double dy = y - p.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
 
        //(a) Khoang cach - phuong thuc tinh
        public static double KhoangCach(Point a, Point b) {
            double dx = a.x - b.x;
            double dy = a.y - b.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
 
        //(b) Trung diem - phuong thuc thanh vien
        public Point TrungDiem(Point p) {
            return new Point((x + p.x) / 2, (y + p.y) / 2);
        }
 
        //(b) Trung diem - phuong thuc tinh
        public static Point TrungDiem(Point a, Point b) {
            return new Point((a.x + b.x) / 2, (a.y + b.y) / 2);
        }
    }
    class Bai12 {
        public static void Run() {
            Point A = new Point();
            Point B = new Point();
 
            Console.WriteLine("Nhap diem A:");
            A.Input();
            Console.WriteLine("Nhap diem B:");
            B.Input();
 
            Console.Write("A = "); A.Output();
            Console.Write("B = "); B.Output();
 
            Console.WriteLine("=== PHEP TOAN ===");
            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A - B = {A - B}");
            Console.WriteLine($"-A = {-A}");
 
            Console.WriteLine("=== (a) KHOANG CACH AB ===");
            Console.WriteLine($"Phuong thuc thanh vien: {A.KhoangCach(B):F2}");
            Console.WriteLine($"Phuong thuc tinh: {Point.KhoangCach(A, B):F2}");
 
            Console.WriteLine("=== (b) TRUNG DIEM I CUA AB ===");
            Console.WriteLine($"Phuong thuc thanh vien: I = {A.TrungDiem(B)}");
            Console.WriteLine($"Phuong thuc tinh: I = {Point.TrungDiem(A, B)}");
        }
    }
}
