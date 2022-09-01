using static System.Console;
using Day02;
/*
var myArray = Arrays.InitArraysInt(new int[] { 10, 20, 30, 40, 50 });

var boys = Arrays.InitArraysString(new[] { "asep", "budi", "charlie" });

var arrRandom = Arrays.InitRandomArray(10);

Arrays.DisplayArrayInt(myArray);
WriteLine();
Arrays.DisplayArrayString(boys);

WriteLine();
var total = Arrays.SumAllElement(myArray);
Write($"Total :{total}");

WriteLine();
Arrays.DisplayArrayInt(arrRandom);
var largest = Arrays.FindLargestElement(arrRandom);
var indexOfLargest = Arrays.FindIndexLargest(arrRandom);
WriteLine($"Largest : {largest}");
WriteLine($"Index of Largest : {indexOfLargest}");
WriteLine();
Array.Sort(arrRandom);
WriteLine($"Found at index : {Array.BinarySearch(arrRandom, 25)}");
Arrays.DisplayArrayInt(arrRandom);
Array.Reverse(arrRandom);
WriteLine();

ReadLine();*/

/** QUIZ SOLUTION */

/*int[] n = { 15, 10, 20, 30, 45, 24 };
WriteLine("Before Random Position");
Arrays.DisplayArrayInt(n);
WriteLine();
var randomArr = QuizSolution.RandomPosition(n);
WriteLine("After Random Position");
Arrays.DisplayArrayInt(randomArr);

WriteLine();

WriteLine("Before Shift Array");
Arrays.DisplayArrayInt(n);
var shiftArray = QuizSolution.ShiftArray(n);
WriteLine();
WriteLine("After Shift Array");
Arrays.DisplayArrayInt(shiftArray);*/

/** Matrix */
/*Matrix.InitMatrix();
var myMatrix = Matrix.FillRandomMatrix(5, 5);
Matrix.DisplayMatrix(myMatrix);

WriteLine();
var matrixDiagonal = Matrix.MatrixDiagonal(5, 5);
Matrix.DisplayMatrix(matrixDiagonal);*/



//QUIZ ARRAY//
//No. 01
//int[] n = { 15, 2, 30, 12, 10, 5 };
//var myArray = Day02.QuizDay02.InitArrayInt(n);
//Console.WriteLine("Before Random : ");
//Day02.QuizDay02.DisplayArray(myArray);
//var rini = Day02.QuizDay02.UbahPosisi(myArray);
//Console.WriteLine("\nAfter random position element change : ");
//Day02.QuizDay02.DisplayArray(rini);

//// No. 02
//int[] x = { 15, 2, 30, 12, 10, 5 };
//var myArray = Day02.QuizArray.InitArrayInt(x);
//Console.WriteLine("Before shifting : ");
//Day02.QuizArray.DisplayArray(myArray);
//var shift = Day02.QuizArray.ShiftArray(myArray);
//Console.WriteLine("\n After shifting : ");
//Day02.QuizArray.DisplayArray(shift);

//No 3
/*int[] n = { 15, 2, 30, 12, 10, 5 };
var RotateArray = Day02.QuizArray.InitArrayInt(n);
Console.WriteLine("\nBefore Rotating");
Day02.QuizArray.DisplayArray(RotateArray);
var num = QuizArray.RotateArray(RotateArray);*/

//No 4
/*int[] n = { 15, 2, 30, 12, 10, 5 };
var RotateArray2 = Day02.QuizArray.InitArrayInt(n);
Console.WriteLine("\nBefore Rotating");
Day02.QuizArray.DisplayArray(RotateArray2);
var num = QuizArray.RotateArray2(RotateArray2);
*/
//No 5
//int[] x = { 15, 2, 30, 12, 10, 5, 2, 10, 5};
//var myArray = Day02.QuizArray.jumlahAngkaArray(x);
//var count = Day02.QuizArray.ShiftArray(myArray);

//No 6
/*int[] n = { 1, 5, 3, 7, 8, 5, 1 };
 Day02.QuizArray.UbahAngkaDuplikat(n);*/

//No 7
/*int[] n = { 1, 5, 3, 7, 8, 5, 1 };
Day02.QuizDay02.RemoveDuplicates(n);
*/

//No 08
//int arr = 100;
//QuizDay02.JumlahArray();
//QuizDay02.DisplayArra

//09
//WriteLine();
//var matrixDiagonal = QuizMatrix.No9(5,5);
//Matrix.DisplayMatrix(matrixDiagonal);

//10
//WriteLine();
//var myDiagonal = QuizMatrix.No10(5, 5);
//Matrix.DisplayMatrix(myDiagonal);

//11
WriteLine();
var myDiagonal = QuizDay02.No11(7, 7);
Matrix.DisplayMatrix(myDiagonal);

//12
//WriteLine();
//var myHitung = QuizMatrix.HitungMatrix(6, 6);
//Matrix.DisplayMatrix(myHitung);

////No 15
//char[,] student = new char[,]{
//    {'A','B','A','C','C','D','E','E','A','D'},
//    {'D','B','A','B','C','A','E','E','A','D'},
//    {'E','D','D','A','C','B','E','E','A','D'},
//    {'C','B','A','E','D','C','E','E','A','D'},
//    {'A','B','D','C','C','D','E','E','A','D'},
//    {'B','B','E','C','C','D','E','E','A','D'},
//    {'B','B','A','C','C','D','E','E','A','D'},
//    {'E','B','E','C','C','D','E','E','A','D' },
//};
//char[] guru = new char[] { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };





ReadLine();