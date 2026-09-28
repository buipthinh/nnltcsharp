using System;
using System.Collections.Generic;

namespace Lab02 {
    class DaySo {
        //Field
        private int[] a;

        //Constructor
        public DaySo() {
            a = new int[0];
        }

        public DaySo(int n) { //n phan tu, mac dinh bang 0
            a = new int[n];
        }

        public DaySo(int[] arr) { //Tao tu mot mang co san
            a = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) {
                a[i] = arr[i];
            }
        }

        public DaySo(DaySo other) : this(other.a) { //Copy constructor
        }

        //Property
        public int N {
            get { return a.Length; }
        }

        //Indexer
        public int this[int i] {
            get {
                if (i < 0 || i >= a.Length) {
                    throw new IndexOutOfRangeException("Chi so vuot pham vi.");
                }
                return a[i];
            }
            set {
                if (i < 0 || i >= a.Length) {
                    throw new IndexOutOfRangeException("Chi so vuot pham vi.");
                }
                a[i] = value;
            }
        }

        //Method
        public void Input() {
            int n = NhapLieu.SoNguyen("Nhap so phan tu n: ", 1);
            a = new int[n];
            for (int i = 0; i < n; i++) {
                a[i] = NhapLieu.SoNguyen($"a[{i}] = ");
            }
        }

        public void Output() {
            if (a.Length == 0) {
                Console.WriteLine("(Day rong)");
                return;
            }
            Console.WriteLine(string.Join(" ", a));
        }

        //Tim cac so chan, tra ve mot DaySo moi
        public DaySo TimSoChan() {
            List<int> chan = new List<int>();
            foreach (int x in a) {
                if (x % 2 == 0) {
                    chan.Add(x);
                }
            }
            return new DaySo(chan.ToArray());
        }
    }

    class Bai23 {
        public static void Run() {
            DaySo d = new DaySo();
            d.Input();
            Console.Write("Day so: ");
            d.Output();
            Console.Write("Cac so chan: ");
            d.TimSoChan().Output();
            Console.WriteLine($"Dung indexer: d[0] = {d[0]}");
        }
    }
}