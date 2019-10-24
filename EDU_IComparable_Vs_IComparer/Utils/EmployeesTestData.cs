using EDU_IComparable_Vs_IComparer.Models;
using System;
using System.Collections.Generic;

namespace EDU_IComparable_Vs_IComparer.Utils
{
    public static class EmployeesTestData
    {
        public static List<Employee> GetListOf10Employees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id = 10001,
                    FirstName = "Evelyn",
                    LastName = "Friedman",
                    Position = "Engineer",
                    BaseSalary = 50000,
                    QuarterlyBonus = 2000,
                    AnnualBonus = 5000,
                    BirthDate =  new DateTime(1990, 03, 04)
                },
                new Employee()
                {
                    Id = 10002,
                    FirstName = "Van",
                    LastName = "Anthony",
                    Position = "QA",
                    BaseSalary = 60000,
                    QuarterlyBonus = 3500,
                    AnnualBonus = 4000,
                    BirthDate =  new DateTime(1992, 10, 06)
                },
                new Employee()
                {
                    Id = 10003,
                    FirstName = "Drew",
                    LastName = "Strickland",
                    Position = "Engineer",
                    BaseSalary = 70000,
                    QuarterlyBonus = 1500,
                    AnnualBonus = 3000,
                    BirthDate =  new DateTime(1987, 01, 01)
                },
                new Employee()
                {
                    Id = 10004,
                    FirstName = "Sonny",
                    LastName = "Zimmerman",
                    Position = "PM",
                    BaseSalary = 80000,
                    QuarterlyBonus = 2000,
                    AnnualBonus = 10000,
                    BirthDate =  new DateTime(1986, 03, 03)
                },
                new Employee()
                {
                    Id = 10005,
                    FirstName = "Kailey",
                    LastName = "Rush",
                    Position = "Engineer",
                    BaseSalary = 90000,
                    QuarterlyBonus = 1000,
                    AnnualBonus = 15000,
                    BirthDate =  new DateTime(1981, 10, 10)
                },
                new Employee()
                {
                    Id = 10006,
                    FirstName = "Kenna",
                    LastName = "Downs",
                    Position = "QA",
                    BaseSalary = 85000,
                    QuarterlyBonus = 3000,
                    AnnualBonus = 13000,
                    BirthDate =  new DateTime(1984, 7, 2)
                },
                new Employee()
                {
                    Id = 10007,
                    FirstName = "Kaila",
                    LastName = "Beard",
                    Position = "PM",
                    BaseSalary = 74000,
                    QuarterlyBonus = 2000,
                    AnnualBonus = 13000,
                    BirthDate =  new DateTime(1974, 2, 10)
                },
                new Employee()
                {
                    Id = 10008,
                    FirstName = "Jett",
                    LastName = "Wood",
                    Position = "Engineer",
                    BaseSalary = 94000,
                    QuarterlyBonus = 500,
                    AnnualBonus = 5000,
                    BirthDate =  new DateTime(1987, 4, 8)
                },
                new Employee()
                {
                    Id = 10009,
                    FirstName = "Mauricio",
                    LastName = "West",
                    Position = "Engineer",
                    BaseSalary = 65000,
                    QuarterlyBonus = 1300,
                    AnnualBonus = 3000,
                    BirthDate =  new DateTime(1989, 9, 11)
                },
                new Employee()
                {
                    Id = 100010,
                    FirstName = "Neil",
                    LastName = "Everett",
                    Position = "QA",
                    BaseSalary = 91000,
                    QuarterlyBonus = 2400,
                    AnnualBonus = 8000,
                    BirthDate =  new DateTime(1993, 2, 10)
                },
            };
        }
    }
}
