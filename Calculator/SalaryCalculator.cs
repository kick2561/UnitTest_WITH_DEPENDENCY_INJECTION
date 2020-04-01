using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator : ISalaryCalculator
    {
        const int HoursInYear = 2080;
        public decimal GetAnnualSalary(decimal hourlywage)
        {
            
            decimal annualSalary = HoursInYear * hourlywage;
            return annualSalary;
        }
        public decimal GetHourlyWage(int annualSalary)
        {
            return annualSalary / HoursInYear;
        }
        
    }
}
