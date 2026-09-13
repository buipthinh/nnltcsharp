namespace Lab01;

class BT06 {
    public static int Max(int a, int b, int c) {
        int max = a; //Mac dinh a se la so lon nhat va dua vao bien max
        if(b > max) max = b; //Kiem tra xem b co lon hon max?
        if(c > max) max = c; //Kiem tra xem c co lon hon max?

        return max; //Ket thuc tra ve gia tri max
    }
    public static void Run() {
        int a, b, c;
        while (true) { //Cac ham kiem tra co phai so nguyen ko
            Console.Write("Nhap so nguyen a: ");
            string inputA = Console.ReadLine();
            if(int.TryParse(inputA, out a)) {
                break;
            }
            Console.WriteLine("a khong phai la so nguyen.");
        }
        while (true) {
            Console.Write("Nhap so nguyen b: ");
            string inputB = Console.ReadLine();
            if(int.TryParse(inputB, out b)) {
                break;
            }
            Console.WriteLine("b khong phai la so nguyen.");
        }
        while (true) {
            Console.Write("Nhap so nguyen c: ");
            string inputC = Console.ReadLine();
            if(int.TryParse(inputC, out c)) {
                break;
            }
            Console.WriteLine("c khong phai la so nguyen.");
        }

        int soLonNhat = Max(a,b,c); //Tao bien lay so lon nhat tai class Max
        Console.WriteLine("So lon nhat trong 3 so nguyen la " + soLonNhat); //Xuat gia tri lon nhat
    }
}