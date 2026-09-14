using System;
namespace Lab01;

class ChuoiKyTu {
    public void XuLyChuoi(string s) {
        string chuoiThuong = s.ToLower(); //Tao 1 bien va chuyen chuoi thanh chu thuong
        string chuoiHoa = s.ToUpper(); //Tao 1 bien va chuyen chuoi thanh im hoa
        string[] cacTu = s.Split(' ', StringSplitOptions.RemoveEmptyEntries); //Tao 1 bien de dem so tu
        Console.WriteLine("Chuoi thuong: " + chuoiThuong);
        Console.WriteLine("Chuoi hoa: " + chuoiHoa);
        Console.WriteLine("So luong tu: " + cacTu.Length);
    }
}

class BT12 {
    public static void Run() {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();
        ChuoiKyTu chuoi = new ChuoiKyTu();
        chuoi.XuLyChuoi(s);
    }
}