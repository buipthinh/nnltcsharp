using System;
using System.Collections.Generic;

class MaTran
{
    private int[,] a; //Tao mang hai chieu

    private int n; //So dong
    private int m; //So cot

    public void TaoMang()
    {
        Console.Write("Nhap so dong n: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot m: ");
        m = int.Parse(Console.ReadLine());

        a = new int[n, m]; //Khoi tao ma tran
        Random random = new Random(); //Tao doi tuong

        for (int i = 0; i < n; i++) //Random tu 10 den 100
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = random.Next(10, 101);
            }
        }
    }

    public void InMang()
    {
        Console.WriteLine("\nMa tran:");

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public void TachChanLe(out int[] mangChan, out int[] mangLe) {
        List<int> chan = new List<int>(); //Tao doi tuong
        List<int> le = new List<int>();

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] % 2 == 0) { //Tim so chan
                    chan.Add(a[i, j]);
                } else {
                    le.Add(a[i, j]); //Khong phai so chan thi dua vao so le
                }
            }
        }

        mangChan = chan.ToArray(); //Chuyen List thanh mang
        mangLe = le.ToArray();
    }
}

class BT17
{
    public static void Run()
    {
        MaTran maTran = new MaTran();
        maTran.TaoMang();
        maTran.InMang();

        maTran.TachChanLe(out int[] mangChan,out int[] mangLe);

        Console.WriteLine("\nCac so chan:"); //In so chan
        foreach (int x in mangChan) {
            Console.Write(x + " ");
        }

        Console.WriteLine("\nCac so le:"); //In so le
        foreach (int x in mangLe)  {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }
}