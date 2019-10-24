using EDU_IComparable_Vs_IComparer.Models;
using System.Collections.Generic;

namespace EDU_IComparable_Vs_IComparer.Helpers
{
    public class SortByBirthDateHelper : IComparer<Employee>
    {
        public int Compare(Employee emp1, Employee emp2)
        {
            return emp1.BirthDate.CompareTo(emp2.BirthDate);
        }
    }
}
