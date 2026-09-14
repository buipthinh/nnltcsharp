using System;
namespace Lab01;

class Mang
{
    private string[] danhSach; //Luu danh sach ho ten

    public void Nhap()
    {
        Console.Write("Nhap n: "); //Nhap so luong nguoi
        int n = int.Parse(Console.ReadLine());
        danhSach = new string[n]; //khoi tao mang

        for (int i = 0; i < n; i++) //Ham nhap ho ten tung nguoi
        {
            Console.Write($"Ho ten [{i}]: ");
            danhSach[i] = Console.ReadLine();
        }
    }

    public void SapXep()
    {
        Array.Sort( //Sap xep theo thu tu cua chuoi
            danhSach,
            StringComparer.CurrentCulture);
    }

    public void InMang()
    {
        for (int i = 0; i < danhSach.Length; i++)
        {
            Console.WriteLine(danhSach[i]);
        }
    }
}

class BT16
{
    public static void Run()
    {
        Mang mang = new Mang();
        mang.Nhap();
        mang.SapXep();
        Console.WriteLine("\nDanh sach sau khi sap xep:");
        mang.InMang();
    }
}