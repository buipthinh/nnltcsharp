namespace Lab01;

class BT04 //Lop BT04
{
    public static void Run()
    {
        Console.Write("Nhap so nguyen x: ");
        string inputX = Console.ReadLine(); //Nhap x
        if(!int.TryParse(inputX, out int x)) //Doi chuoi inputX thanh so nguyen x
        {
            Console.WriteLine("x khong phai la mot so nguyen.");
            return;
        }
        Console.Write("Nhap so nguyen y: ");
        string inputY = Console.ReadLine(); //Nhap y
        if(!int.TryParse(inputY, out int y)) //Doi chuoi inputY thanh so nguyen y
        {
            Console.WriteLine("y khong phai la mot so nguyen.");
            return;
        }

        double ketQua = (double)Math.Pow(x,y);
        Console.WriteLine("Ket qua cua" + x + "mu" + y + "la: " + ketQua);
    }
}