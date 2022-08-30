using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class EmployeeImpl : IEmployee
    {
        public Employee FindEmployeeById(List<Employee> list, int id)
        {
            Employee emps = null;
            foreach (var item in list)
            {
                if(item.EmpId == id)
                {
                    emps = item;
                }
            }

            return emps;
        }

        public List<Employee> FindSalaryRange(List<Employee> list, decimal startFrom, decimal endTo)
        {
            var empRange = new List<Employee>();

            foreach (var item in list)
            {
                if(item.TotalSalary >= startFrom && item.TotalSalary <= endTo)
                {
                    empRange.Add(item);
                }
            }

            return empRange;
        }

        public Dictionary<string, int> GetTotalEmployeeByRole(List<Employee> list)
        {
            //throw new NotImplementedException();
        }

        public decimal GetTotalSalary<T>(ref List<T> list)
        {
            var total = 0M;
            // OfType digunakan jika data yg dikirim generic
            // dan kita ingin akses attribute sebuah class employee
            foreach (var item in list.OfType<Employee>())
            {
                total += item.TotalSalary;
            }
            return total;
        }

        public List<Employee> InitDataEmployee()
        {
            Employee emp1 = new Employee(1001, "Andy", "Garcia",
                   new DateTime(), 3_000_000);

            Employee emp2 = new Employee(1001, "Charlie", "Bronson",
                    new DateTime(), 4_000_000);

            Employee emp3 = new Employee(1002, "Arya", "Stark", new DateTime(2022, 8, 29), 5_000_000, "Bandung");

            Programmer prog1 = new Programmer(1004, "Badu", "Duba", new DateTime(2021, 7, 12), 5_500_000,
                                  "Bogor", 500_00);

            QA empQA = new QA(1004, "Tony", "Buba", new DateTime(2021, 7, 12), 4_500_000, 500_000);

            Sales sales = new Sales(1006, "John", "Snow", new DateTime(2019, 5, 18), 3_500_000, 10, 15);

            // store to list return with variable
            /*List<Employee> listEmps = new List<Employee> { emp1, emp2, emp3,  prog1,empQA,sales };
            return listEmps;*/

            // direct return without variable
            return new List<Employee> { emp1, emp2, emp3, prog1, empQA, sales };
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
