using System;
using System.Collections.Generic;

namespace Lab02 {
    class PersonList {
        //Field
        private List<Person> ds;

        //Constructor
        public PersonList() {
            ds = new List<Person>();
        }

        //Copy constructor, sao chep tung Person
        public PersonList(PersonList other) {
            ds = new List<Person>();
            foreach (Person p in other.ds) {
                ds.Add(new Person(p));
            }
        }

        //Property
        public int Count {
            get { return ds.Count; }
        }

        //Indexer
        public Person this[int i] {
            get { return ds[i]; }
            set { ds[i] = value; }
        }

        //Method
        public void Add(Person x) {
            ds.Add(x);
        }

        public void Input() {
            int n = NhapLieu.SoNguyen("Nhap so nguoi: ", 0);
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"--- Nguoi thu {i + 1} ---");
                Person p = new Person();
                p.Input();
                ds.Add(p);
            }
        }

        public void Output() {
            if (ds.Count == 0) {
                Console.WriteLine("(Danh sach rong)");
                return;
            }
            for (int i = 0; i < ds.Count; i++) {
                Console.WriteLine($"--- Nguoi thu {i + 1} ---");
                ds[i].Output();
            }
        }

        public PersonList LivingPeople() {
            PersonList kq = new PersonList();
            foreach (Person p in ds) {
                if (p.IsLiving()) {
                    kq.Add(p);
                }
            }
            return kq;
        }
    }

    class Bai22 {
        public static void Run() {
            PersonList list = new PersonList();
            list.Input();

            Console.WriteLine("=== TAT CA NHAN KHAU ===");
            list.Output();

            Console.WriteLine("=== NHUNG NGUOI CON SONG ===");
            PersonList song = list.LivingPeople();
            song.Output();
            Console.WriteLine($"Tong: {song.Count}/{list.Count} nguoi con song.");
        }
    }
}