using System;
using System.Collections;
namespace Lab02 {
    class ArrayPoint {
        //Field
        private ArrayList ds;

        //Constructor
        public ArrayPoint() {
            ds = new ArrayList();
        }
        public ArrayPoint(ArrayPoint other) {
            ds = new ArrayList();
            foreach (Point p in other.ds) {
                ds.Add(new Point(p.X, p.Y));   //Tao Point moi, khong dung chung
            }
        }

        //Property
        public int Count {
            get { return ds.Count; }
        }
 
        //Indexer
        public Point this[int i] {
            get {
                if (i < 0 || i >= ds.Count) {
                    throw new IndexOutOfRangeException("Chi so vuot pham vi.");
                }
                return (Point)ds[i];   //ArrayList luu object nen phai ep kieu
            }
            set {
                if (i < 0 || i >= ds.Count) {
                    throw new IndexOutOfRangeException("Chi so vuot pham vi.");
                }
                ds[i] = value;
            }
        }

        //Method
        public void Add(Point p) {
            ds.Add(p);
        }
 
        public void Input() {
            int n = NhapLieu.SoNguyen("Nhap so diem: ", 0);
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Diem thu {i}:");
                Point p = new Point();
                p.Input();
                ds.Add(p);
            }
        }
 
        public void Output() {
            for (int i = 0; i < ds.Count; i++) {
                Console.WriteLine($"P[{i}] = {this[i]}");
            }
        }
    }

    class Bai21 {
        public static void Run() {
            ArrayPoint ap = new ArrayPoint();
            ap.Input();
            Console.WriteLine("=== DANH SACH DIEM ===");
            ap.Output();
            if (ap.Count > 0) {
                Console.WriteLine($"Dung indexer lay ap[0]: {ap[0]}");
                ap[0] = new Point(10, 10);
                Console.WriteLine($"Sau khi gan ap[0] = (10, 10): {ap[0]}");
            }
        }
    }
}