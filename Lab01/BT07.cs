namespace Lab01;

class BT07 {
    public static bool KiemTraSoNguyenTo(int n) { //Tao ham kt snt
        if(n < 2) { return false; } //Neu gia tri < 2 thi tra ve false
        for(int i = 2; i <= Math.Sqrt(n); i++) { //Tao vong lap for
            if(n % i == 0) { return false; }
        }
        return true;
    }

    public static void Run() {
        int n;
        while (true) { //Ham kiem tra so nguyen
            Console.Write("Nhap so nguyen n: ");
            if(int.TryParse(Console.ReadLine(), out n)) {
                break;
            }
            Console.WriteLine("n khong phai la so nguyen.");
        }

        if(KiemTraSoNguyenTo(n)) { //Dung if de kiem tra so nguuyen to
            Console.WriteLine(n + "la so nguyen to.");
        } else {
            Console.WriteLine(n + "khong phai la so nguyen to");
        }
    }
}
