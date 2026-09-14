namespace Lab01;

public class SinhVien {
    private string maSV { get; set; } = ""; //Cac phuong thuc get, set cho bien
    private string hoTen { get; set; } = ""; //Cac phuong thuc get, set cho bien
    private string diaChi { get; set ;} = ""; //Cac phuong thuc get, set cho bien
    private int namThu { get; set; } //Cac phuong thuc get, set cho bien
    public void Nhap() { //Ham nhap thong tin cua sinh vien
        Console.Write("Nhap ma sinh vien: ");
        maSV = Console.ReadLine();
        Console.Write("Nhap ho ten sinh vien: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap dia chi sinh vien: ");
        diaChi = Console.ReadLine();
        while (true) { //Vong lap while xac dinh gia tri phai la so nguyen
            Console.Write("Nhap nam thu: ");
            if(int.TryParse(Console.ReadLine(), out int nam) && nam>=1 && nam <=4) { //va khong be hon 1, lon hon 4
                namThu = nam; //Sau khi nhap xong, se tra ve bien nam, cho bien nam = namThu
                break;
            }
            Console.WriteLine("Nam cua sinh vien phai tren 1 va duoi 4."); //Neu nhap sai se nhap lai
        }
    }
    public void Xuat() { //Ham xuat thong tin sinh vien
        Console.WriteLine("THONG TIN SINH VIEN");
        Console.WriteLine("Ma so sinh vien: " + maSV);
        Console.WriteLine("Ho ten sinh vien: " + hoTen);
        Console.WriteLine("Dia chi sinh vien: " + diaChi);
        Console.WriteLine("Nam thu: " + namThu);
    }
}

class BT13 {
    public static void Run() {
        SinhVien sv = new SinhVien(); //Tao 1 bien tham chieu, lay cac du lieu tu lop SinhVien
        sv.Nhap(); //Goi phuong thuc nhap
        sv.Xuat(); //Goi phuong thuc xuat
    }
}