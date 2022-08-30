using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class QA : Employee
    {
        // instance variable, gunakan huruf kecil
        private decimal makan = 0M;

        public QA(int empId, string firstName, string lastName, DateTime joinDate, 
            decimal basicSalary, decimal makan) : base(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.makan = makan;
            Role = "QA"; 
            // call method TotalSalary belong Employee
            TotalSalary = TotalSalary + makan;
        }




        // method automatically huruf capital
        public decimal Makan { get => makan; set => makan = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | TjMakan = {this.makan.ToString("C", new CultureInfo("id-ID"))}|Total Salary = {TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
