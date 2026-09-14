namespace Lab01;

class Chuoi
{
    public bool DoiXung(string s)
    { //Kiem tra chuoi co doi xung hay ko?
        int left = 0; //left bat dau tu dau chuoi
        int right = s.Length - 1; //right bat dau tu cuoi chuoi
        //Do dai cua chuoi bat dau tu 0 den Length - 1
        while (left < right) //Vong lap so sanh tung cap ky tu
        {
            if (s[left] != s[right]) //Neu 2 ky tu trai phai khac nhau thi sai
            {
                return false; //Tra ve false neu ko doi xung
            }
            left++;
            right--;
        }
        return true;
    }
}

class BT10
{
    public static void Run()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();
        Chuoi chuoi = new Chuoi();
        bool ketQua = chuoi.DoiXung(s); //Kiem tra chuoi
        if (ketQua)
        {
            Console.WriteLine("Chuoi doi xung.");
        }
        else
        {
            Console.WriteLine("Chuoi khong doi xung.");
        }
    }
}