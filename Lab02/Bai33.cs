using System;

namespace Lab02 {
    public delegate int SoSanh<T>(T a, T b);

    static class SapXepDelegate {
        public static void Sort<T>(T[] a, SoSanh<T> soSanh) {
            for (int i = 0; i < a.Length - 1; i++) {
                for (int j = i + 1; j < a.Length; j++) {
                    if (soSanh(a[i], a[j]) > 0) { //Goi ham duoc truyen vao
                        T tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }
        }
    }

    class Bai33 {
        //Ham thuong co cung hinh dang voi delegate SoSanh<int>
        static int TangDan(int a, int b) {
            return a - b;
        }

        public static void Run() {
            int[] so = { 5, 2, 9, 1, 7 };

            SapXepDelegate.Sort(so, TangDan); //Truyen ten ham
            Console.WriteLine("Tang dan: " + string.Join(" ", so));

            SapXepDelegate.Sort(so, (a, b) => b - a); //Truyen bieu thuc lambda
            Console.WriteLine("Giam dan: " + string.Join(" ", so));

            SapXepDelegate.Sort(so, (a, b) => (a % 2) - (b % 2)); //Chan truoc, le sau
            Console.WriteLine("Chan truoc le sau: " + string.Join(" ", so));

            HocSinh[] ds = {
                new HocSinh("Tran Van An", 7.5),
                new HocSinh("Le Thi Binh", 9.0),
                new HocSinh("Nguyen Van Cuong", 5.5)
            };

            SapXepDelegate.Sort(ds, (x, y) => y.Diem.CompareTo(x.Diem));
            Console.WriteLine("=== HOC SINH THEO DIEM GIAM DAN ===");
            foreach (HocSinh hs in ds) Console.WriteLine(hs);

            SapXepDelegate.Sort(ds, (x, y) => string.Compare(x.HoTen, y.HoTen));
            Console.WriteLine("=== HOC SINH THEO TEN ===");
            foreach (HocSinh hs in ds) Console.WriteLine(hs);
        }
    }
}