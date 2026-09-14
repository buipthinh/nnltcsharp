namespace Lab01;

class BT09 {
    public static void MaxMin (double a, double b, double c, out double max, out double min) {
        max = a; //Tim max
        if(b > max) max = b;
        if(c > max) max = c;

        min = a; //Tim min
        if(b < min) min = b;
        if(c < min) min = c;
    }

    public static void Run() {
        double a, b, c;
        while(true) { //Kiem tra co phai so thuc?
            Console.Write("Nhap so thuc a: ");
            if(double.TryParse(Console.ReadLine(), out a)) {
                break;
            }
            Console.WriteLine(a + "khong phai la so thuc.");
        }
        while(true) {
            Console.Write("Nhap so thuc b: ");
            if(double.TryParse(Console.ReadLine(), out b)) {
                break;
            }
            Console.WriteLine(b + "khong phai la so thuc.");
        }
        while(true) {
            Console.Write("Nhap so thuc c: ");
            if(double.TryParse(Console.ReadLine(), out c)) {
                break;
            }
            Console.WriteLine(c + "khong phai la so thuc.");
        }

        double soLonNhat, soNhoNhat; //Khoi tao 2 bien so lon nhat va so nho nhat
        MaxMin(a, b, c, out soLonNhat, out soNhoNhat); //Dung ham MaxMin, thay the 2 bien max, min
        Console.WriteLine("So lon nhat la: " + soLonNhat);
        Console.WriteLine("So be nhat la: " + soNhoNhat);
    }
}