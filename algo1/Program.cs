using System;
using System.Collections;

namespace algo1
{
    class Program
    {
        // Deklarasi array int dengan ukuran 71
        private int[] prim = new int[71];
        private int i;
        private int n;

        // Deklarasi variabel int untuk menyimpan banyak data pada array

        // Fungsi / Method untuk menerima masukan
        public void read() 
        {
            // menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukan banyaknya element pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 71)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 71 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = n - 2; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                prim[i] = Int32.Parse(s1);

            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element Array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int pr = n - 2; pr < n; pr++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // For n - passes
            {
                // Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int pr = n - 2; pr < n - i; pr++)
                {
                    if (prim[pr] > prim[pr + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = prim[pr];
                        prim[pr] = prim[pr + 1];
                        prim[pr + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Creating the object of the Bubbleshort class
            Program myList = new Program();

            // Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            // pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            // pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            //Exit
            Console.WriteLine("\n\n Tekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}


