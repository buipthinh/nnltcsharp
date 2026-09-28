using System;
namespace Lab02 {
    class Person {
        //Field
        private string id;
        private string name;
        private int yob;
        private int yod;

        //Constructor
        public Person() {
            id = "";
            name = "";
            yob = 0;
            yod = 0;
        } 
        public Person(Person p) {
            id = p.id;
            name = p.name;
            yob = p.yob;
            yod = p.yod;
        }

        //Property
        public string Id {
            get { return id; }
            set { id = value.Trim(); }
        }   
        public string Name {
            get { return name; }
            set { name = value.Trim(); }
        }

        int namHienTai = DateTime.Now.Year; //Lay nam hien tai
        public int Yob {
            get { return yob; }
            set {
                if (value > 1990 && value <= namHienTai) {
                    yob = value;
                } else {
                    Console.WriteLine("Vui long nhap tu 1990 den nam hien tai.");
                }
            }
        }
        public int Yod {
            get { return yod; }
            set { //value == 0 (neu = 0 la con song)
                if (value == 0 || (value >= yob && value <= namHienTai)) {
                    yod = value;
                } else {
                    Console.WriteLine("Nam mat khong hop le.");
                }
            }
        }

        //Method
        public void Input() {
            Console.Write("Nhap id: ");
            Id = Console.ReadLine();
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();
            
            yob = 0;
            while (true) {
                Console.Write("Nhap nam sinh: ");
                if(int.TryParse(Console.ReadLine(), out int ns)) {
                    Yob = ns;
                    if(yob != 0) break;
                } else {
                    Console.WriteLine("Vui long nhap so nguyen.");
                }
            }

            yod = -1; //Lay gia tri ban dau la -1 vi 0 la con song
            while (true) {
                Console.Write("Nhap nam mat (nhap 0 neu con song): ");
                if(int.TryParse(Console.ReadLine(), out int nm)) {
                    Yod = nm;
                    if(yod != -1) break;
                } else {
                    Console.WriteLine("Vui long nhap so nguyen.");
                }
            }
        }

        public void Output() {
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Ho ten: {name}");
            Console.WriteLine($"Nam sinh: {yob}");
            if(IsLiving()) {
                Console.WriteLine("Nam mat: (hien con song).");
            } else {
                Console.WriteLine($"Nam mat: {yod}");
            }
        }

        public bool IsLiving() {
            return yod == 0;
        }
    }

    class Bai13 {
        public static void Run() {
            Person p1 = new Person();
            Console.WriteLine("=== NHAP THONG TIN ===");
            p1.Input();
            Console.WriteLine("=== THONG TIN ===");
            p1.Output();

            //Copy constructor
            Person p2 = new Person(p1);
            Console.WriteLine("=== BAN SAO ===");
            p2.Output();
        }
    }
}