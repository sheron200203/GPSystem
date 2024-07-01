using GPSystem.DB;
using GPSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSystem.CLASSES
{
    internal class SalaryFunctions
    {
        public decimal NoPay(decimal monthlySalary, int salaryCycledateRange, int absentDays)
        {
            decimal noPayVal = (monthlySalary / salaryCycledateRange) * absentDays;
            return noPayVal;
        }
        public decimal BasePay(decimal monthlySalary, decimal allowances, decimal overTimeRate, decimal overtimeHours)
        {
            decimal basePayVal = monthlySalary + allowances + (overTimeRate * overtimeHours);
            return basePayVal;
        }
        public decimal GrossPay(decimal basePay, decimal noPay, decimal tax)
        {
            decimal grossPayVal = basePay - (noPay + basePay * tax / 100);
            return grossPayVal;
        }
    }
}
