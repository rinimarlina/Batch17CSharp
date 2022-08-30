using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Sales : Employee
    {
        private decimal bonus;
        private decimal commission;

        public Sales(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, decimal commission, decimal bonus) : base(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.Commission = commission/100;
            Role = "Sales";
            this.Bonus = bonus/100;
            TotalSalary = basicSalary + (basicSalary *(bonus/100))+ (basicSalary * (commission / 100));
        }

        public decimal Commission { get => commission; set => commission = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Bonus = {String.Format("{0:0.0%}", this.bonus)}|Commission = {String.Format("{0:0.0%}", this.commission)}|Total Salary = {TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
