using System;

namespace Bubble_sort
{
    /// <summary>
    /// Kelas Program digunakan sebagai titik awal eksekusi program C#
    /// </summary>
    class program
    {

        /// <summary>
        /// Variabel a adalah array integer private yang memiliki panjang 20 elemen.
        /// </summary>
        private int[] a = new int[20];

        /// <summary>
        /// Variabel n adalah integer private yang akan digunakan di dalam kelas.
        /// </summary>
        private int n;

        /// <summary>
        /// Metode read() digunakan untuk membaca input dari pengguna.
        /// </summary>
        public void read()
        {

            /// <summary>
            /// Loop while(true) digunakan untuk meminta pengguna untuk memasukkan jumlah elemen dalam array, 
            /// kemudian memeriksa apakah jumlah elemen tersebut tidak lebih dari 20. Jika iya, program akan melanjutkan, 
            /// jika tidak, pesan kesalahan akan ditampilkan kepada pengguna.
            /// </summary>
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }

            /// <summary>
            /// Metode Console.WriteLine() digunakan untuk mencetak baris kosong pada konsol, 
            /// kemudian mencetak garis pemisah, dan pesan yang memberikan instruksi kepada pengguna untuk memasukkan elemen array.
            /// </summary>
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-------------------------");

            /// <summary>
            /// Loop for digunakan untuk mengulangi kode yang dimasukkan di dalamnya sebanyak n kali, 
            /// yang sama dengan jumlah elemen yang dimasukkan pengguna ke dalam array. 
            /// Pada setiap iterasi, pengguna diminta untuk memasukkan elemen array dan nilai yang dimasukkan disimpan dalam array.
            /// </summary>
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }

        /// <summary>
        /// Metode display digunakan untuk mencetak semua elemen dalam array ke konsol. 
        /// Setiap elemen dipisahkan dengan spasi.
        /// </summary>
        public void display()
        {
            /// <summary>
            /// Baris kode ini mencetak elemen array ke konsol dalam urutan yang telah tersusun.
            /// Baris kode pertama digunakan untuk mencetak baris kosong, dan baris kedua hingga keempat digunakan 
            /// untuk mencetak judul yang menjelaskan konten yang akan ditampilkan.
            /// Setelah judul, baris kode untuk loop for digunakan untuk mencetak semua elemen dalam array ke konsol, 
            /// dengan setiap elemen dicetak pada baris baru. Akhirnya, baris kosong terakhir digunakan untuk 
            /// memisahkan output dari program berikutnya yang mungkin akan ditampilkan di konsol.
            /// </summary>
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun");
            Console.WriteLine("----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Metode ini mengurutkan elemen array menggunakan algoritma Bubble Sort..
        /// </summary>
        public void BubbleSortArray()
        {
            /// <summary>
            /// Sebuah loop for digunakan untuk melakukan iterasi sebanyak n-1 kali, dimulai dari indeks 1.
            /// Hal ini dilakukan untuk membandingkan setiap pasangan elemen berturut-turut dalam array pada algoritma Bubble Sort.
            /// </summary>
            for (int i = 1; i < n; i++)
            {
                /// <summary>
                /// Sebuah loop for digunakan untuk melakukan iterasi sebanyak n-i kali, dimulai dari indeks 0.
                /// Hal ini dilakukan untuk membandingkan setiap pasangan elemen berturut-turut dalam array pada algoritma Bubble Sort.
                /// </summary>
                for (int j = 0; j < n - i; j++)
                {
                    ///<summary>
                    /// jika nilai j belum ditemukan nilai yang dicari maka nilai j bakal ditambah 1 sampai ketemu nilai  yang di cari
                    /// </summary>

                    if (a[j] > a[j + 1]) 
                    {
                        ///<summary>
                        /// ini untuk tukar elemen
                        /// </summary> 
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Metode Main adalah metode yang pertama kali dijalankan ketika program C# dijalankan.
        /// </summary>
        /// <param> name ="args">Daftar argumen baris perintah yang diberikan kepada program.</param>
        static void Main(string[] args)
        {
            //creating the object of the bubblesort class
            program myList = new program();

            //pemanggilan fungsi untuk menerima elemen array
            myList.read();
            //pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            //pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            //exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}