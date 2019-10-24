using EDU_IComparable_Vs_IComparer.Helpers;
using EDU_IComparable_Vs_IComparer.Models;
using EDU_IComparable_Vs_IComparer.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EDU_IComparable_Vs_IComparer.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        [TestMethod()]
        public void CompareTo_Test()
        {
            List<Employee> employees = EmployeesTestData.GetListOf10Employees();

            employees.Sort();

            Assert.AreEqual("Anthony", employees.First().LastName);
            Assert.AreEqual("Zimmerman", employees.Last().LastName);
        }

        [TestMethod()]
        public void SortBySalary_Test()
        {
            List<Employee> employees = EmployeesTestData.GetListOf10Employees();

            employees.Sort(new SortBySalaryHelper());

            foreach (Employee employee in employees)
            {
                Trace.WriteLine(employee + "; " + employee.CalculateTotalSalary());
            }

            Assert.AreEqual("Downs", employees.First().LastName);
            Assert.AreEqual("Friedman", employees.Last().LastName);
        }

        [TestMethod()]
        public void SortByBirthDay_Test()
        {
            List<Employee> employees = EmployeesTestData.GetListOf10Employees();

            employees.Sort(new SortByBirthDateHelper());

            foreach (Employee employee in employees)
            {
                Trace.WriteLine(employee + "; " + employee.CalculateTotalSalary());
            }

            Assert.AreEqual("Beard", employees.First().LastName);
            Assert.AreEqual("Everett", employees.Last().LastName);
        }
    }
}