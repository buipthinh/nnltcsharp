namespace Lab01;

class NhanVien {
    private string hoTen { get; set; } = ""; //Goi phuong thuc get, set
    private int mucLuong { get; set; }
    private int soNgayVang { get; set; }
    public void Nhap() { //Ham nhap thong tin nhan vien
        Console.Write("Nhap ho ten nhan vien: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap muc luong: ");
        mucLuong = int.Parse(Console.ReadLine()); //Bat buoc phai ghi so nguyen (chua co thong bao nhap lai)
        while(true) { //Vong lap while bat buoc phai nhap so nguyen
            Console.Write("Nhap so ngay vang: ");
            if(int.TryParse(Console.ReadLine(), out int ngay) && ngay >= 0) { //So ngay vang phai lon hon 0
                soNgayVang = ngay;
                break;
            }
            Console.WriteLine("So ngay vang phai lon hon hoac bang 0."); //Thong bao nhap lai
        }
    }
    public void Xuat() {
        int tienPhat = soNgayVang * 100000; //Tien phat theo yeu cau de bai
        int tienThucNhan = mucLuong - tienPhat; //So tien thuc nhan
        if(tienThucNhan < 0) { tienThucNhan = 0; } //Neu tien phat > tien thuc nhan thi tien thuc nhan se bang 0
        //Vi so tien thuc nhan khong the la so am
        Console.WriteLine("THONG TIN NHAN VIEN");
        Console.WriteLine("Ho ten nhan vien: " + hoTen);
        Console.WriteLine("Muc luong: " + mucLuong);
        Console.WriteLine("So ngay vang: " + soNgayVang);
        Console.WriteLine("Tien phat: " + tienPhat);
        Console.WriteLine("Tien thuc nhan: " + tienThucNhan);
    }
}

class BT14 {
    public static void Run() {
        NhanVien nv = new NhanVien();
        nv.Nhap();
        nv.Xuat();
    }
}