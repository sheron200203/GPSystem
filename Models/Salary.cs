using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSystem.Models
{
    internal class Salary
    { 
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string Month { get; set; }
        public int AbsentDay { get; set; }
        public int NoOvertimeHours { get; set; }
        public int NoLeaves { get; set; }
        public int NoHolidays { get; set; }
        public decimal BasePay {  get; set; }   
        public decimal NoPay { get; set; }
        public decimal GrossPay { get; set; }

        public Salary(int employeeID, string month, int absentDay, int noOvertimeHours, int noLeaves, int noHolidays, decimal basePay, decimal noPay, decimal grossPay)
        {
            EmployeeID = employeeID;
            Month = month;
            AbsentDay = absentDay;
            NoOvertimeHours = noOvertimeHours;
            NoLeaves = noLeaves;
            NoHolidays = noHolidays;
            BasePay = basePay;
            NoPay = noPay;
            GrossPay = grossPay;
        }
        public Salary() { }
    }
}
