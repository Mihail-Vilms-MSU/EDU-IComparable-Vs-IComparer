using EDU_IComparable_Vs_IComparer.Models;
using System.Collections.Generic;

namespace EDU_IComparable_Vs_IComparer.Helpers
{
    public class SortBySalaryHelper : IComparer<Employee>
    {
        public int Compare(Employee emp1, Employee emp2)
        {
            if (emp1.CalculateTotalSalary() - emp2.CalculateTotalSalary() < 0) return 1;
            return -1;
        }
    }
}
