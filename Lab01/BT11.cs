using System.Text;

class Chuoi {
    public string DaoChuoi(string s) { //Ket qua tra ve chuoi (string)
        StringBuilder sb = new StringBuilder(); //Khoi tao doi tuong
        for(int i = s.Length - 1; i >= 0; i--) {
            sb.Append(s[i]); //Lay ky tu tai vi tri i va dua vao sb
        }
        return sb.ToString();
    }
}

class BT11 {
    public static void Run() {
        Console.Write("Nhap vao chuoi: ");
        string s = Console.ReadLine();
        Chuoi chuoi = new Chuoi(); //Tao doi tuong nhan thong tin tu lop Chuoi
        string chuoiDao = chuoi.DaoChuoi(s); //Goi pt va nhan ket qua tra ve
        Console.WriteLine("Chuoi sau khi dao nguoc: " + chuoiDao);
    }
}