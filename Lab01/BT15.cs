using System;

class Mang { 
    private int[] a;
    public void Nhap() {
        Console.Write("Nhap so luong phan tu: "); //Nhap so luong phan tu (n)
        int n = int.Parse(Console.ReadLine());

        a = new int[n]; //Khoi tao mang dua tren n
        for(int i=0; i<n; i++) { //Nhap tung mang (chua xet phai la 1 so)
            Console.Write("Nhap phan tu thu " + i + ": ");
            a[i] = int.Parse(Console.ReadLine()); //Ep chuoi phai la so nguyen
        }
    }
    public void InMang() {
        Console.WriteLine("Mang: ");
        for(int i=0; i<a.Length; i++) { //Vong lap de in phan tu trong chuoi
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }
    public void MaxMin(out int max, out int min) {
        max = a[0]; //Lay phan tu thu nhat lam max
        min = a[0]; //Lay phan tu thu nhat lam min
        for(int i=0; i<a.Length; i++) { //Xet trong mang
            if(a[i]>max) { max = a[i]; } //Neu phan tu con lai lon hon max (a[0]) thi lay no lam max
            if(a[i]<min) { min = a[i]; } //Min tuong tu
        }
    }
    
    public bool KiemTraSoNguyenTo(int n) { //Ham kiem tra so nguyen to
        if(n<2) { return false; } //Neu nho hon 2, ko phai
        for(int i=2; i<=Math.Sqrt(n); i++) {
            if(n%i==0) { return false; }
        }
        return true;
    }
    public int[] laySNT() {
        List<int> ketQua = new List<int>();
        foreach(int x in a) { //Duyet tung phan tu
            if(KiemTraSoNguyenTo(x)) { ketQua.Add(x); }
        } //Neu la snt, them vao danh sach
        return ketQua.ToArray(); //Dua ve danh sach ket qua
    }
}

class BT15 {
    public static void Run() {
        Mang mang = new Mang();
        mang.Nhap();
        mang.InMang();
        mang.MaxMin(out int lon, out int be); //Khoi tao lon be de thay the max min cua Ham MaxMin
        Console.WriteLine("Phan tu lon nhat: " + lon);
        Console.WriteLine("Phan tu nho nhat: " + be);

        int[] mangNuyenTo = mang.laySNT();
        Console.Write("Cac so nguyen to trong mang: ");
        foreach(int x in mangNuyenTo) {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }
}
