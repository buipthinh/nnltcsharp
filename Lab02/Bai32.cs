using System;
using System.Collections.Generic;

namespace Lab02 {
    //Mo phong Array.Sort bang interface
    static class SapXepInterface {
        //Cach 1: phan tu tu so sanh duoc (T cai dat IComparable<T>)
        public static void Sort<T>(T[] a) where T : IComparable<T> {
            for (int i = 0; i < a.Length - 1; i++) {
                for (int j = i + 1; j < a.Length; j++) {
                    if (a[i].CompareTo(a[j]) > 0) {
                        Swap(a, i, j);
                    }
                }
            }
        }

        //Cach 2: truyen vao mot doi tuong so sanh (IComparer<T>)
        public static void Sort<T>(T[] a, IComparer<T> comparer) {
            for (int i = 0; i < a.Length - 1; i++) {
                for (int j = i + 1; j < a.Length; j++) {
                    if (comparer.Compare(a[i], a[j]) > 0) {
                        Swap(a, i, j);
                    }
                }
            }
        }

        private static void Swap<T>(T[] a, int i, int j) {
            T tam = a[i];
            a[i] = a[j];
            a[j] = tam;
        }
    }

    class Bai32 {
        public static void Run() {
            int[] so = { 5, 2, 9, 1, 7 };
            SapXepInterface.Sort(so); //int co san IComparable<int>
            Console.WriteLine("Mang so: " + string.Join(" ", so));

            string[] ten = { "Lan", "An", "Minh", "Binh" };
            SapXepInterface.Sort(ten); //string co san IComparable<string>
            Console.WriteLine("Mang chuoi: " + string.Join(" ", ten));

            HocSinh[] ds = {
                new HocSinh("Tran Van An", 7.5),
                new HocSinh("Le Thi Binh", 9.0),
                new HocSinh("Nguyen Van Cuong", 5.5)
            };

            SapXepInterface.Sort(ds); //Dung CompareTo o bai 3.1
            Console.WriteLine("=== HOC SINH THEO DIEM ===");
            foreach (HocSinh hs in ds) Console.WriteLine(hs);

            SapXepInterface.Sort(ds, new SoSanhTheoTen());
            Console.WriteLine("=== HOC SINH THEO TEN ===");
            foreach (HocSinh hs in ds) Console.WriteLine(hs);
        }
    }
}