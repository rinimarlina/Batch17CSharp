using static System.Console;
// call class employee
using Day04.PartOne;
using Day04.PartTwo;

// setiap create object instance, gunakan operator new

// gunakan encapsulation untuk manipulasi attribute object
/*emp1.firstName = "Code";
emp1.empId = 1001;*/
/*
Employee emp1 = new Employee();
emp1.EmpId = 1000;
emp1.FirstName = "Dian";
emp1.LastName = "Kang";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 5_000_000;
emp1.City = "Bogor";
emp1.Role = "Programmer";


// create object Employee with parameter constructor
Employee emp2 = new Employee(1001,"Code","Academy",
                    new DateTime(),5_000_000);
emp2.Role = "Sales";

Employee emp3 = new Employee(1002, "Asep", "Dayat", 
                    new DateTime(2022,8,29), 5_000_000, "Bandung");

emp3.Role = "QA";
emp3.BasicSalary = 7_000_000;

Employee emp4 = new Employee(1003, "Budi", "F", new DateTime(2022, 8, 12), 6_000_000, "Jakarta", "Programmer");

WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());
WriteLine($"Total Employee : {Employee.totalEmployee}");
WriteLine($"Total Employee Basic Salary: {Employee.totalBasicSalary}");


WriteLine($"=================LIST EMPLOYEE ==============================");

// create object programmer
Programmer prog1 = new Programmer(1004, "Badu", "Duba", new DateTime(2021, 7, 12), 5_500_000, 
                                  "Bogor", 500_00);

// store to list
List<Employee> listEmps = new List<Employee> { emp1, emp2,emp3,emp4,prog1 };

foreach (var item in listEmps)
{
    WriteLine(item.ToString());
}*/

WriteLine("========== Implementation Interface ==================");
// call interface & implementation

IEmployee empInf = new EmployeeImpl();

var listOfEmps = empInf.InitDataEmployee();
empInf.ShowList(ref listOfEmps);

var emp = empInf.FindEmployeeById(listOfEmps,1002);
WriteLine($"Found : {emp}");

var total = empInf.GetTotalSalary(ref listOfEmps);
WriteLine($"Total Salary : {total}");

WriteLine("--------- Salary Range -----------");
var empsSalaryRange = empInf.FindSalaryRange(listOfEmps, 2_000_000, 4_500_000);
empInf.ShowList(ref empsSalaryRange);

ReadLine();

