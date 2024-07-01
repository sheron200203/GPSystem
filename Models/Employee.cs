using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSystem.Models
{
    internal class Employee
    {
      
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal OvertimeRate { get; set; }
        public decimal Allowance { get; set; }
        public string FullName  { get; set; }


    public Employee(string firstName, string lastName, decimal monthlySalary, decimal overtimeRate, decimal allowance )
        {
           this.FirstName = firstName;
            this.LastName = lastName;
            this.MonthlySalary = monthlySalary;
            this.OvertimeRate = overtimeRate;
            this.Allowance = allowance;
        }

        public Employee()
        {

        }

    }
}

