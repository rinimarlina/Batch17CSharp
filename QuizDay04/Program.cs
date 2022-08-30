//call class employee
/*using Day4.PartOne;
using System;
using System.Collections.Generic;
using static System.Console;

/*setiap create object instan,gunakan operator ne
Employee emp1 = new Employee();
emp1.EmpId = 1000;
emp1.FirstName = "Rini";
emp1.LastName = "Marlina";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 7_000_000;
emp1.City = "Bogor";
emp1.Role = "Programmer";

//create object Employee with parameter constructor
Employee emp2 = new Employee(1001,"Code","Academy",new DateTime(),5_000_000);
emp2.Role = "Sales";
Employee emp3 = new Employee(1002, "Fatin", "Fatiyah", new DateTime(), 6_000_000, "Bogor");
emp3.Role = "QA";
Employee emp4 = new Employee(1003,"Budi","Farhana",new DateTime(2023,8,29),5_000_000,"Bandung");
emp4.Role = "Sales";

WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());
WriteLine($"Total Employee: {Employee.totalEmployee}");
WriteLine($"Total Salary: {Employee.totalBasicSalary}");

WriteLine($"---------------------LIST EMPLOYEE---------------------");
//create object programmer
Programmer prog1 = new Programmer(1004,"Rini","Marlina", new DateTime(2021,07,12),5_500_000,
                                "Bogor",500_000);
//create object sales
Sales sals = new Sales(1005, "Anisa", "Farhanani", new DateTime(2020, 08, 14), 5_000_000,
                        "Bogor", 1_000_000, 500_000);
//create object QA
QA myQA = new QA(1005, "Fatih", "Akbar", new DateTime(2020, 07, 2), 4_500_000,
                "Bogor", 10_000);

//store to list
List<Employee> listEmps = new List<Employee> { emp1, emp2, emp3, emp4, prog1, sals, myQA };
foreach (var item in listEmps)
{
    WriteLine(item.ToString());
}

//gunakan encapsulation untuk manipulasi attribute object
/*emp1.firstName = "Code";
emp1.empId = 1001;*/

/*using Day4.PartTwo;
using System;
using System.Collections.Generic;
using static System.Console;
WriteLine($"---------------------IMPLEMENTATION INTERFACE-------------------");
//call interface & implementation

IEmployee empInf = new EmployeeImpl();

var listOfEmps = empInf.InitDataEmployee();
empInf.ShowList(ref listOfEmps);

var emp = empInf.FindEmployeeById(listOfEmps, 1002);
WriteLine($"Found : {emp}");

var total = empInf.GetTotalSalary(ref listOfEmps);
WriteLine($"Total Salary : {total}");

WriteLine("--------- Salary Range --------");
var empsSalaryRange = empInf.FindSalaryRange(listOfEmps, 5_000_000, 6_000_000);
empInf.ShowList(ref empsSalaryRange);*/



using Day4.QuizDay04;
using System;
using System.Collections.Generic;
using static System.Console;

//WriteLine($"======================================QUIZ DAY 04===================================");
////create object Employee with parameter constructor
//SUV suv1 = new SUV("D 1001 UM", 2015, "SUV", 500_000, 100_000);
//SUV suv2 = new SUV("D 1002 UM", 2019, "SUV", 500_000, 100_000);
//Taxi taxi1 = new Taxi("D 88 UK", 2018, "Taxi", 5, 4500, 40, 10_000);
//Taxi taxi2 = new Taxi("D 87 UK", 2018, "Taxi", 10, 4500, 100, 10_000);
//Angkot ang1 = new Angkot("D 55 UJ", 2016, "Angkot", 4500, 35);
//Angkot ang2 = new Angkot("D 55 UJ", 2015, "Angkot", 4500, 40);


////store to list
//List<Car> listCar = new List<Car> { suv1, suv2, taxi1, taxi2, ang1, ang2};
//foreach (var item in listCar)
//{
//    WriteLine($"{item.ToString()}");
//}


WriteLine("-----------------------------------------IMPLEMENTATION INTERFACE-----------------------------------------");
ICar carInf = new CarImpl();
var listCar = carInf.InitDataCar();
carInf.ShowList(ref listCar);

WriteLine("\n-----------------------------------------Total Revenue By Type-----------------------------------------");
var totalRevn = carInf.GetTotalRevenueByType(listCar);
carInf.ShowListRevenue(totalRevn);

WriteLine("\n-------------------------------------------Total Car By Type-------------------------------------------");
var totalCar = carInf.TotalCarByType(listCar);
carInf.ShowListType(totalCar);

WriteLine("\n-----------------------------------------Find Revenue By Type-----------------------------------------");
var RevRange = carInf.FindRevenueByRange(listCar, 500_000, 600_000);
carInf.ShowList(ref RevRange);

ReadLine();