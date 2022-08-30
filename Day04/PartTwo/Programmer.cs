using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Programmer : Employee
    {
        private decimal transportasi;

        public Programmer(int empId, string firstName, string lastName,
            DateTime joinDate, decimal basicSalary,
            string city, decimal transportasi) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.transportasi = transportasi;
            Role = "Programmer";
            TotalSalary = basicSalary +transportasi;
            
        }

        public decimal Transportasi { get => transportasi; set => transportasi = value; }

        

        public override string? ToString()
        {
            return $"{base.ToString()} | TjTransportasi = {this.transportasi.ToString("C", new CultureInfo("id-ID"))}|Total Salary = {TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
