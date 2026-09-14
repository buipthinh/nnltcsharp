namespace Lab01;

class BT08 {
    public static void HoanVi(ref double a, ref double b) {
        double temp = a; //Phuong thuc hoan vi co ban
        a = b;
        b = temp;
    }
    public static void Run() {
        double x, y;
        while (true) { //Kiem tra co phai so thuc?
            Console.Write("Nhap so nguyen x: ");
            if(double.TryParse(Console.ReadLine(), out x)) {
                break;
            }
            Console.WriteLine(x + " khong phai la so thuc.");
        }
        while (true) {
            Console.Write("Nhap so nguyen y: ");
            if(double.TryParse(Console.ReadLine(), out y)) {
                break;
            }
            Console.WriteLine(y + "khong phai la so thuc.");
        }
        Console.WriteLine("Truoc khi hoan vi: x = " + x + ", y = " + y);
        HoanVi(ref x, ref y); //Hoan vi
        Console.WriteLine("Sau khi hoan vi: x = " + x + ", y = " + y);
    }
}