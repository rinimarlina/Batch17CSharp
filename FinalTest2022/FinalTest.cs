using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2022
{
    internal class FinalTest
    {
        //No 2
        public static void No2()
        {
            Console.WriteLine("Enter the number = ");
            int f = int.Parse (Console.ReadLine ());

            int fact = 1;
            while(true)
            {
                Console.Write (f);

                if(f == 1)
                {
                    break ;

                }
                Console.Write("*");
                fact *= f;
                f--;
            }
            
            Console.WriteLine(" = {0}", fact);
            Console.ReadLine ();
        }

        //No 3
        public static void No3 ()
        {

            int n = 0;

            for (int i = 0; i < n; i++)
            {
                sum += n;
            }
            return sum;
        }

        //No 4
        public static int No4(int n)
        {
            while(true)
            {
                if(n <= 2)
                {
                    return 1;
                }
                return No4(n  - 1) + No4(n -2);
            }
        }

            
        //No 8
        public static int[,] No8 (int b, int k)
        {
            int[,] matrix = new int[7, 4];
            //int n = b + 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //matrix[i, j] = i + j;
                    if (i == j) 
                    {
                         matrix[i, j] = i + 1;
                    }
                    else if (i < j)
                    {
                         matrix[i, j] = j + 1;
                    }
                    else if (i > j)
                    {
                         matrix[i, j] = j + 1;
                    }

                }
            }
            return matrix;
        }

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

       
    }
}
