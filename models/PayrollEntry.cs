// employee_management_system/models/PayrollEntry.cs
using System;

namespace employee_management_system.models
{
    public class PayrollEntry
    {
        // From Employees table
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int DepartmentId { get; set; } // FK to departments table
        public int GradeId { get; set; }      // FK to grades table
        public decimal PersonalizedIncrement { get; set; }

        // From departments table (for display)
        public string DepartmentName { get; set; }

        // From grades table
        public decimal BasicSalary { get; set; }
        public decimal TransportAllowance { get; set; }
        public decimal NewYearBonus { get; set; }
        public decimal ChristmasAllowance { get; set; } // Maps to christmas_bonus in DB

        // Calculated field - NOT stored in the database
        public decimal NetSalary { get; set; }
    }
}