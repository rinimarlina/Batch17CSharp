using Day03;
/*
MyCollections.InitList();
MyCollections.InitStack();
MyCollections.InitDictionary();
MyCollections.InitHashSet();
MyCollections.InitQueue();*/

//declare List<T>
/*var list = new List<string> { "asep", "budi", "charlie" };
var students = MyCollections.GetStudent(ref list);

foreach (var item in students)
{
    Console.WriteLine($"{item}");
}

var numbers = new List<int> { 2, 3, 4, 5, 6 };
var myNumber = MyCollections.GetStudent(ref numbers);
foreach (var item in numbers)
{
    Console.WriteLine($"{item}");
}*/


/*QUIZ LIST*/
//No 2
Console.WriteLine("\n No 2\n");
Console.WriteLine("\n Reverse ke 1\n");
var listR = new List<int> { 1, 2, 3, 4 };
var angR = QuizDay03.No2(ref listR);
foreach (var item in angR)
{
    Console.Write(item + "");
}
Console.WriteLine("\n Reverse ke 2\n");
var listRe = new List<string> { "A", "BB", "CC", "DDDD" };
var angRe = QuizDay03.No2(ref listRe);
foreach (var item in angRe)
{
    Console.Write(item + "");
}