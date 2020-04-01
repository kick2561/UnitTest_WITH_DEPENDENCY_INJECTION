using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ServiceImplementor : IService
    {
        readonly ISalaryCalculator _salaryCalculator;

        public ServiceImplementor(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        public decimal GetAnnualSalary(decimal hourlywage)
        {
            decimal annualSalary = _salaryCalculator.GetAnnualSalary(hourlywage);
            return annualSalary;
        }

        public decimal GetHourlyWage(int annualSalary)
        {
            decimal hourlyWage = _salaryCalculator.GetHourlyWage(annualSalary);
            return hourlyWage;
        }
    }
}
