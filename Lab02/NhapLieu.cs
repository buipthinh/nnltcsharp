using System;

namespace Lab02 {
    //Gom cac vong lap nhap lieu dung chung cho nhieu bai
    static class NhapLieu {
        public static int SoNguyen(string thongBao, int min = int.MinValue, int max = int.MaxValue) {
            while (true) {
                Console.Write(thongBao);
                if (int.TryParse(Console.ReadLine(), out int so) && so >= min && so <= max) {
                    return so;
                }
                Console.WriteLine($"Vui long nhap so nguyen tu {min} den {max}.");
            }
        }

        public static double SoThuc(string thongBao, double min = double.MinValue) {
            while (true) {
                Console.Write(thongBao);
                if (double.TryParse(Console.ReadLine(), out double so) && so >= min) {
                    return so;
                }
                Console.WriteLine("Gia tri khong hop le, vui long nhap lai.");
            }
        }

        public static string Chuoi(string thongBao) {
            Console.Write(thongBao);
            string s = Console.ReadLine();
            return s == null ? "" : s.Trim();
        }
    }
}