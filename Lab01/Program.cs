namespace Lab01;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. BT01");
        Console.WriteLine("2. BT03");
        Console.WriteLine("3. BT04");
        Console.WriteLine("4. BT05");
        Console.WriteLine("5. BT06");
        Console.WriteLine("6. BT07");
        Console.WriteLine("7. BT08");
        Console.WriteLine("8. BT09");
        Console.WriteLine("9. BT10");
        Console.WriteLine("10. BT11");
        Console.WriteLine("11. BT12");
        Console.WriteLine("12. BT13");
        Console.WriteLine("13. BT14");
        Console.WriteLine("14. BT15");
        Console.WriteLine("15. BT16");
        Console.WriteLine("16. BT17");
        Console.Write("Chon bai tap: ");
        int chon = int.Parse(Console.ReadLine());

        switch (chon)
        {
            case 1:
                BT01.Run();
                break;
            case 2:
                BT03.Run();
                break;
            case 3:
                BT04.Run();
                break;
            case 4:
                BT05.Run();
                break;
            case 5:
                BT06.Run();
                break;
            case 6:
                BT07.Run();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le.");
                break;
        }
    }
}