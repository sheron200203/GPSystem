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
        private readonly decimal _monthlySalary;

        public SalaryFunctions(decimal monthlySalary)
        {
            _monthlySalary = monthlySalary;
        }

        public decimal CalculateNoPay(int salaryCycleDateRange, int absentDays)
        {
            return (_monthlySalary / salaryCycleDateRange) * absentDays;
        }

        public decimal CalculateBasePay(decimal allowance, decimal overtimeRate, decimal overtimeHours)
        {
            return _monthlySalary + allowance + (overtimeRate * overtimeHours);
        }

        public decimal CalculateGrossPay(decimal basePay, decimal noPay, decimal tax)
        {
            return basePay - (noPay + (basePay * tax / 100));
        }
    }
}
