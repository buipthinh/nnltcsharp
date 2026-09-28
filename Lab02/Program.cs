namespace Lab02;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Chon bai tap: ");
        int chon = int.Parse(Console.ReadLine());

        switch (chon)
        {
            case 11:
                Bai11.Run();
                break;
            case 12:
                Bai12.Run();
                break;
            case 13:
                Bai13.Run();
                break;
            case 14:
                BT14.Run();
                break;
            case 15:
                Bai15.Run();
                break;
            case 21:
                Bai21.Run();
                break;
            case 22:
                Bai22.Run();
                break;
            case 23:
                Bai23.Run();
                break;
            case 24:
                Bai24.Run();
                break;
            case 26:
                Bai26.Run();
                break;
            case 31:
                Bai31.Run();
                break;
            case 32:
                Bai32.Run();
                break;
            case 33:
                Bai33.Run();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le.");
                break;
        }
    }
}