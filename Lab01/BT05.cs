namespace Lab01;

class BT05
{
    public static double x;
    public static double y;
    public static bool daNhapData = false; //Kiem tra da nhap x va y chua

    public static void Run()
    {
        int chon = 0;
        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            if (!int.TryParse(Console.ReadLine(), out chon)) //Kiem tra nhap dung lua chon
            {
                Console.WriteLine("Loi: Vui long nhap so tu 1 den 4!");
                continue;
            }

            switch (chon)
            {
                case 1:
                    Op1.Run();
                    break;
                case 2:
                    if (KiemTraDaNhap()) Op2.Run();
                    break;
                case 3:
                    if (KiemTraDaNhap()) Op3.Run();
                    break;
                case 4:
                    Console.WriteLine("Da thoat chuong trinh.");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }

        } while (chon != 4); //Lap lai neu chon khac voi 4 lua chon
    }

    private static bool KiemTraDaNhap() //Ham kiem tra xem da nhap so thuc chua
    {
        if (!daNhapData) //Neu bien chua co, he thong se bao loi
        {
            Console.WriteLine("Loi: Ban chua nhap gia tri x va y! Vui long chon 1 truoc.");
            return false;
        }
        return true;
    }
}

class Op1 //Lop lua chon nhap so thuc x va y
{
    public static void Run()
    {
        while (true) //Dung while de nhap lai khi nhap ko dung so thuc
        {
            Console.Write("Nhap so thuc x: ");
            if (double.TryParse(Console.ReadLine(), out BT05.x)) //Dua chuoi x ve so thuc
                break;
            Console.WriteLine("Loi: x phai la mot so thuc. Vui long nhap lai!");
        }
        while (true)
        {
            Console.Write("Nhap so thuc y: ");
            if (double.TryParse(Console.ReadLine(), out BT05.y)) //Dua chuoi y ve so thuc
                break;
            Console.WriteLine("Loi: y phai la mot so thuc. Vui long nhap lai!");
        }

        BT05.daNhapData = true; //Danh dau nhap du lieu thanh cong
        Console.WriteLine("Da luu gia tri x = " + BT05.x + "va y = " + BT05.y);
    }
}

class Op2 //Lop tinh luy thua
{
    public static void Run()
    {
        double ketQua = Math.Pow(BT05.x, BT05.y);
        Console.WriteLine("Ket qua cua " + BT05.x + " mu " + BT05.y + " la: " + ketQua);
    }
}

class Op3 //Lop tinh can bac hai
{
    public static void Run()
    {
        //Kiem tra dieu kien
        if (BT05.x < 0)
            Console.WriteLine("Khong the tinh can bac 2 cua x (" + BT05.x + ") vì x < 0!");
        else //Neu dung thi tinh toan theo phuong thuc Math.Sqrt
            Console.WriteLine("Can bac 2 cua x (" + BT05.x + ") la: " + Math.Sqrt(BT05.x));

        if (BT05.y < 0)
            Console.WriteLine("Khong the tinh can bac 2 cua y (" + BT05.y + ") vì y < 0!");
        else //Neu dung thi tinh toan theo phuong thuc Math.Sqrt
            Console.WriteLine("Can bac 2 cua y (" + BT05.y + ") la: " + Math.Sqrt(BT05.y));
    }
}