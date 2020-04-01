using System;
using Calculator;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculateTestProject
{
    [TestClass]
    public class CalculatorTest
    {
        IService service;

        [TestInitialize]
        public void initialize()
        {
            var container = new WindsorContainer();

            container.Register(Component.For<ISalaryCalculator>().ImplementedBy<SalaryCalculator>());

            container.Register(Component.For<IService>().ImplementedBy<ServiceImplementor>());

            service = container.Resolve<IService>();
        }

        [TestMethod]
        public void AnnualSalaryTest()
        {
          //  SalaryCalculator sc = new SalaryCalculator();

            decimal annualSalary = service.GetAnnualSalary(50);

            Assert.AreEqual(104000, annualSalary);
        }
        [TestMethod]
        public void HourlyWageTest()
        {
           // SalaryCalculator sc = new SalaryCalculator();

            decimal hourlyWage = service.GetHourlyWage(52000);

            Assert.AreEqual(25, hourlyWage);
        }
    }
    
}
