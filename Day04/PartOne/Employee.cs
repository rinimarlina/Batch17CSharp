using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartOne
{
    internal class Employee
    {
        // instance variable
        private int empId;
        private string firstName;
        private string lastName;
        private DateTime joinDate;
        private decimal basicSalary;
        private string city;
        private string role;
        private decimal totalSalary;
        // static variable
        public static int totalEmployee = 0;
        public static decimal totalBasicSalary = 0M;




        //empty / default constructor
        public Employee()
        {
            totalEmployee++;
            totalBasicSalary += this.BasicSalary;
            this.totalSalary = this.basicSalary;
        }

        // constructor parameter
        public Employee(int empId, string firstName, 
            string lastName, DateTime joinDate, decimal basicSalary)
        {
            this.empId = empId;//new Random().Next(1000, 1100);
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            totalEmployee++;
            totalBasicSalary += this.BasicSalary;
            this.totalSalary= this.basicSalary;
        }

        //overloading constructor
        public Employee(int empId, 
            string firstName, string lastName, 
            DateTime joinDate, decimal basicSalary, 
            string city) : this (empId, firstName, lastName, joinDate, basicSalary)
        { 
            this.city = city;
        }

        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, string role) : this(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.role = role;
        }

        public override string? ToString()
        {
            return $"Employee={this.empId} | {this.firstName}| {this.lastName}  |{this.role} |Basic Salary : {this.totalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }



        // get set
        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public decimal BasicSalary { get => basicSalary; 
            set { 
                    basicSalary = value;
                totalSalary = basicSalary;
                } 
        }
        public string City { get => city; set => city = value; }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalary { get => totalSalary; set => totalSalary = value; }
    }
}
