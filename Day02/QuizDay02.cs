using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class QuizDay02
    {
        //No.1
        public static int[] InitArrayInt(int[] arr)
        {
            int[] array = arr;
            return array;
        }
        //cara 1 pakai while:
        //public static int[] UbahPosisi(int[] arr)
        //{
        //    int[] value = arr;
        //    Random rand = new Random();
        //    int n = arr.Length - 1;

        //    while (n > 0)
        //    {
        //        int temp = value[n];
        //        int random = rand.Next(0, n);
        //        value[n] = value[random];
        //        value[random] = temp;
        //        n--;
        //    }
        //    return arr;
        //}

        //cara 2 pakai for:
        public static int[] RandomPosition(int[] n)
        {
            int[] array = n;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(0, n.Length);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array;
        }

        //No. 2
        public static int[] ShiftArray(int[] arr)
        {
            int[] array = arr;
            int first = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                array[i] = arr[(i + 1)];
            }
            array[arr.Length - 1] = first;
            return array;
        }

        //No. 3
        public static int[] RotateArray(int[] arr)
        {
            int[] num = new int[arr.Length];
            for (int j = 1; j < 4; j++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotating {j}");
                int first = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    num[i] = arr[(i + 1)];
                }
                num[arr.Length - 1] = first;
                DisplayArray(num);
                arr = num;
            }
            return num;
        }

        //No 4
        public static int[] RotateArray2(int[] arr)
        {
            int[] num = new int[arr.Length];
            for (int j = 1; j < 4; j++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotating {j}");
                int first = arr[arr.Length-1];
                for (int i = arr.Length - 1;i > 0; i--)
                {
                    num[i] = arr[(i - 1)];
                }
                num[0] = first;
                DisplayArray(num);
                arr = num;
            }
            return num;
        }

        //No. 5
        public static int[] jumlahAngkaArray (int[] arr)
        {
            int[] array = arr;
            int count = 0;
            Array.Sort(array);
            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (i < arr.Length - 1 && arr[i] != arr[i + 1] )
                {
                    Console.WriteLine($"{arr[i]} muncul sebanyak {count}  ");
                }
                else if (i == arr.Length - 1)
                {
                    Console.WriteLine($"{arr[i]} muncul sebanyak {count}  ");
                }
            }
            return array;

        }

        //No 06
        public static void UbahAngkaDuplikat(int[] arr)
        {
            Console.WriteLine("Before maker :");
            DisplayArray(arr);
            Console.WriteLine("After maker :");

            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                if (i < arr.Length - 1 && n == arr[i + 1])
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (j == arr.Length - 1)
                        {
                            arr[j] = -1;
                        }
                        else
                        {
                            arr[j] = arr[j + 1];
                        }

                    }
                }
            }
            DisplayArray(arr);
            Console.WriteLine();
        }

        //No 7
        public static void RemoveDuplicates(int[] arr)
        {
            Console.WriteLine("\nBefore remove :\n");
            DisplayArray(arr);
            Console.WriteLine("\nAfter remove :\n");
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                if (i < arr.Length - 1 && n == arr[i + 1])
                {
                    continue;
                }
                Console.WriteLine($"{arr[i]}");
            }
        }

        //No 8
        public static void JumlahArray()
        {
            var myChar = "abcdefghijklmnopqrstuvwxyz";
            Random r = new Random();
            char[] arr = new char[100];
            int count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = myChar[r.Next(0, 26)];
            }

            foreach (var item in arr)
            {
                Console.Write(item);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                if (i < arr.Length - 1 && n == arr[i - 1])
                {
                    count++;
                }
                else if (i == arr.Length - 1 && n == arr[i - 1])
                {
                    Console.Write($"{count} {arr[i]}");
                }
                else
                {
                    Console.Write($"{count} {arr[i]}");
                    count = 1;
                }
            }
        }

        //09
        public static int[,] No9(int b, int k)
        {
            int[,] matrix = new int[b, k];
            int counter = 5;

            //fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }
                }
            }
            return matrix;
        }

        //10
        public static int[,] No10(int b, int k)
        {
            int[,] matrix = new int[b, k];
            Random r = new Random();
            double sum = 0;

            //fill matrix

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //isi diagonal
                    matrix[i, j] = r.Next(100);
                    if (i == j)
                    {
                        sum += matrix[i, j];

                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }

                }
            }
            Console.WriteLine($"Total sum Random = {sum} ");
            return matrix;
        }

        //No.11

        public static int[,] No11(int baris, int kolom)
        {
            int[,] matrix = new int[7, 7];
            int n = baris - 1;

            //fill matrix

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                    if (i != 0 && j != 0)
                    {
                        if (i != n && j != n)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }

            }
            return matrix;
        }

        //No. 12
        //public static int[,] HitungMatrix(int b, int k)
        //{
        //    int[,] matrix = new int[7, 7];
        //    //int temp = matrix[i, j];
        //    int summ = 0;
        //    //matrix[6, 6] = 0;

        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            foreach ( in matrix)
        //            {
        //                summ += ;
        //                int temp = matrix[i, j];
        //                //summ += matrix[i, j];
        //                temp = summ;

        //                if (i == j)
        //                {
        //                    matrix[i, j] = i + j;
        //                }
        //                else if (i < j)
        //                {
        //                    matrix[i, j] = i + j;
        //                }
        //                else if (i > j)
        //                {
        //                    matrix[i, j] = i + j;
        //                }

        //            }
        //        }
        //    }

        //    return matrix;
        //}

        //No.14
        //public static int[,] No14(int baris, int kolom)
        //{
        //    int[,] matrix = new int[7, 7];
        //    int n = baris - 1;

        //    //fill matrix

        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {

        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            matrix[i, j] = i + j;
        //            if (i != 0 && j != 0)
        //            {
        //                if (i != n && j != n)
        //                {
        //                    matrix[i, j] = 0;
        //                }
        //            }
        //        }

        //    }
        //    return matrix;
        //}

        //No 15

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) //looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //looping kolom
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");

            }
        }

        /*public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
            }
        }*/

        public static void DisplayMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
            }
        }
    }
}
