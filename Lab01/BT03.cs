namespace Lab01;

class BT03 //Lop BT03
{
    public static void Run()
    {
        Console.Write("Nhap so nguyen x: ");
        int x = int.Parse(Console.ReadLine()); //Nhap x
        Console.Write("Nhap so nguyen y: ");
        int y = int.Parse(Console.ReadLine()); //Nhap y

        double ketQua = (double)Math.Pow(x, y); //Tinh luy thua
        Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + ketQua); //Xuất kết quả
    }
}