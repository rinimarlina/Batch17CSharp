using Day03;
/*
MyCollections.InitList();
MyCollections.InitStack();
MyCollections.InitDictionary();
MyCollections.InitHashSet();
MyCollections.InitQueue();*/

//declare List<T>
var list = new List<string> { "asep", "budi", "charlie" };
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
}