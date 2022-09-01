using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class QuizDay03
    {
        //No 1
        public static void displayHashset(HashSet<int> number1)
        {

            foreach (int tampil in number1)
            {
                Console.Write($" {tampil}");
            }
        }
        public static void SameElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.IntersectWith(number2);
            Console.WriteLine("Elemen yang sama adalah : ");
            displayHashset(result);
        }

        public static void UnionElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.UnionWith(number2);
            Console.WriteLine("Tampilan union : ");
            displayHashset(result);
        }

        public static void ExceptElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.ExceptWith(number2);
            Console.WriteLine("Tampilan yang tidak sama : ");
            displayHashset(result);
        }

        public static void SymmetricExceptElement(HashSet<int> number1, HashSet<int> number2)
        {
            HashSet<int> result = new HashSet<int>(number1);
            result.SymmetricExceptWith(number2);
            Console.WriteLine("Tampilan element yang tidak sama A & B : ");
            displayHashset(result);
        }

        static void Main(string[] args)
        {
            HashSet<int> hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            HashSet<int> hs2 = new HashSet<int>() { 1, 2, 3, 4 };

            displayHashset(hs1);
            Console.WriteLine();
            displayHashset(hs2);
            Console.WriteLine();
            SameElement(hs1, hs2);
            Console.WriteLine();
            UnionElement(hs1, hs2);
            Console.WriteLine();
            ExceptElement(hs1, hs2);
            Console.WriteLine();
            SymmetricExceptElement(hs1, hs2);


        }

        //No. 2
        public static List<T> No2<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (T item in list)
            {
                myList.Add(item);
            }
            myList.Reverse();
            return myList;
        }


    }
}
