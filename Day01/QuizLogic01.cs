using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fundamental.day01
{
    internal class QuizLogic01
    {
        //No 1. Buat program untuk menghitung summary dari angka yang diinput
        public static void Summary()
        {
            int sum = 0;
            int x;
            Console.Write("Enter number integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                x = n % 10;
                sum = sum + x;
                n = n / 10;
            }
            Console.Write("Total sum= " + sum);
        }

        //2. Buat program untuk menghitung jumlah digit yang diinput. Tidak dibolehkan menggunakan string.length().
        public static void CountDigits()
        {
            int sum = 0;
            int x = 0;
            Console.Write("Enter number integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                sum = sum + (number % 10);
                number = number / 10;
                x++;

            }

            Console.WriteLine($"Count= {x}");
        }

        //No 3. Buat program dengan inputan integer dan output (balik angka)
        public static void BalikAngka()
        {
            Console.Write("Enter number integer: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            int hasil = 0;
            while (angka != 0)
            {
                hasil = angka % 10;
                angka = angka / 10;

                Console.Write($"{hasil}");
            }
        }

        //No 4. Buat program untuk menampilkan bilangan terbesar kedua dengan inputan dinamis.Tidak dibolehkan angka inputan dikurang 1.
        public static void MaxKedua()
        {
            int count = 0;
            Console.Write("Enter number integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number - 1; i++)
            {
                count++;
            }
            Console.Write($"Count = {count}");
        }

        //No 5. Buat program GuessNumber, dimana user input angka untuk menebak random number, jika benar munculkan return message
        public static void GuessNumbers()
        {
            Console.WriteLine("Guess magic number between 0-20 : ");

            Random random = new Random();
            int number = random.Next(0, 20);

            int guess = -1;

            while (guess != number)
            {
                Console.WriteLine("Enter your guess ?");
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

                // cek kondisi
                if (guess == number)
                {
                    Console.WriteLine($"Tebakan kamu benar, angka yang ditebak {guess}");
                    Console.WriteLine($"Tebak lagi?");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("\n");
                        GuessNumbers();
                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Your Quit");
                        break;
                    }
                }
                else if (
                    guess > number)
                {
                    Console.WriteLine($"Your guess is too high");
                }
                else
                {
                    Console.WriteLine($"Your guess is too low");
                }


            }
        }

        //No 6.Buat program menampilkan angka terbesar
        public static void Max()
        {
            int max = int.MinValue;
            int number;
            int x;


            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Enter number integer: [Ketik 0 untuk keluar]");
                number = Convert.ToInt32(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                }
                else if (number == 0)
                {
                    Console.Write($"Angka terbesar: {max}");
                    break;
                }
            }
        }

        //No 7.Buat program untuk menampilkan angka pembagi dari sebuah bilangan
        public static void AngkaPembagi()
        {
            Console.Write("Enter number :");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        //No 8.Buat program untuk menampilkan bilangan prima dalam range tertentu.
        public static void PrimeNumber()
        {
            Console.Write("Enter number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                int jumlah = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        jumlah++;
                    }
                }
                if (jumlah == 2)
                {
                    Console.Write(i + " ");
                }
            }
        }

        //No 9. Buat program untuk men-check apakah kata yang diinput palindrome, palindrome adalah kata
        //      yang jika dibaca dari depan atau belakang memiliki karakter yang sama.
        public static void Palindrome()
        {
            Console.Write("Masukkan strings :");
            string name = Console.ReadLine();
            string rini = name.ToLower();
            string reverse = string.Empty;

            for (int i = rini.Length - 1; i>= 0; i++)
            {
                reverse += rini[i];
            }
            if (rini == reverse)
            {
                Console.WriteLine($"{rini} Ya! ini adalah Palindrome");
            }
            else
            {
                Console.WriteLine($"{rini} No! ini bukan Palindrome");
            }
            Console.ReadKey();
        }

        //10.Buat program untuk menghitung jumlah huruf vocal dan consonant dalam sebuah kalimat
        public static void Vowel1()
        {
            Console.Write("Enter string : ");
            string kalimat = Console.ReadLine();
            kalimat.ToLower();
            int vowelHitung = 0;
            int consonantHitung = 0;
            string kata = "";
            for (int i = 0; i < kalimat.Length; i++)
            {
                kata = kalimat[i].ToString();

                if (kata == "a" || kata == "i" ||
                   kata == "u" || kata == "e" ||
                   kata == "o")
                {
                    vowelHitung++;
                }
                else
                {
                    consonantHitung++;
                }
            }
            Console.WriteLine($"Vowel : {vowelHitung}, consonant : {consonantHitung}");
        }

        //No 11. Buat program untuk menghitung jumlah kata dalam kalimat yang diinput
        public static void JumlahKata()
        {
            Console.Write("Enter string : ");
            string kalimat = Console.ReadLine();
            kalimat.ToLower();
            int jumlahKata = 0;
            string kata = "";

            for (int i = 0; i < kalimat.Length; i++)
            {
                kata = kalimat[i].ToString();
                if ((kata == "") || (1 == kalimat.Length - 1))
                {
                    jumlahKata++;
                }
                Console.WriteLine($"Total Words : {jumlahKata}");
            }

            //No 12. Buat program untuk mereplace middle character menjadi symbol * dalam sebuah kalimat
            static void Replace()
            {
                Console.Write("Enter string : ");
                string kalimat = Console.ReadLine();
                kalimat.ToLower();
                int jumlah = 0;
                string kata = "";
                string ubah = "";
                for (int i = 1; i < kalimat.Length - 1; i++)
                {
                    kata = kalimat[i].ToString();
                    if (kata == " ")
                    {
                        ubah += kata;
                    }
                    else if (kata != " ")
                    {
                        ubah += "*";
                    }
                }
                var replacement = kalimat.Replace(kalimat.Substring(1, kalimat.Length - 2), ubah);
                Console.WriteLine(replacement);
            }

            //No 13. Buat program untuk menampilkan berapa hari lagi ke hari jumat
            static void Vowel()
            {
                DateTime now = DateTime.Now;
                DayOfWeek sabtu = DayOfWeek.Saturday;
                DayOfWeek today = now.DayOfWeek;
                int daysRemaining = sabtu - today;
                Console.WriteLine($"Hari Sabtu: {now.AddDays(daysRemaining).ToShortDateString()}");
                Console.WriteLine($"{daysRemaining} hari lagi!");
            }


            //No 14. 14.Buat program untuk menampilkan jumlah kata yang dicari seperti contoh berikut (gunakan
            //method IndexOf):
            static void findPattern()
            {
                Console.WriteLine("Masukkan text : ");
                string input = Console.ReadLine();
                Console.WriteLine("Temukan pola :");
                string pattern = Console.ReadLine();

                int a = 0;
                int count = 0;

                while ((a = input.IndexOf(pattern, a)) != -1)
                {
                    a += pattern.Length;
                    count++;
                }
                Console.WriteLine(($"{pattern} Muncul sebanyak : {count}"));
            }
            // No 15. Buat program second greatest
            static void GreatestSecond()
            {
                int max = 0;
                int secondmax = 0;
                int n = 0;
                for (int i = 0; i < 6; i++)
                {
                    Console.Write($"Enter {i}. number :");
                    int angka = Convert.ToInt32(Console.ReadLine());
                    if(angka > max)
                    {
                        secondmax = max;
                        max = angka;
                    }else if (angka < max)
                    {
                        if(angka > secondmax)
                        {
                            secondmax = angka;
                        }
                        else
                        {
                            secondmax = secondmax;
                        }
                        max = max;
                    }
                }
                Console.WriteLine($"Second Greatest : {secondmax}");
            }
        }
    }
}
