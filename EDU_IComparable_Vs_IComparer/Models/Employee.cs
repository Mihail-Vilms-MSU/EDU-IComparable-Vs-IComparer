using System;

namespace EDU_IComparable_Vs_IComparer.Models
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public float BaseSalary { get; set; }
        public float QuarterlyBonus { get; set; }
        public float AnnualBonus { get; set; }
        public DateTime BirthDate { get; set; }

        public float CalculateTotalSalary()
        {
            return BaseSalary + AnnualBonus + QuarterlyBonus * 4;
        }

        // comparing by LastName field
        public int CompareTo(Employee otherEmployee)
        {
            return otherEmployee.LastName.CompareTo(this.LastName) * (-1);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Position}, {BirthDate})";
        }
    }
}
