using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_system.models
{
    internal class PayrollEntry
    {
        // Employee Identification
        public string EmployeeName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeFacultyDepartment { get; set; } // Combines Faculty and Department
        public string EmployeeGrade { get; set; }

        // Salary Components
        public decimal BasicSalary { get; set; }
        public decimal PersonalizedIncrement { get; set; }
        public decimal NewYearBonus { get; set; }
        public decimal TransportAllowance { get; set; }
        public decimal ChristmasAllowance { get; set; }

        // Calculated Field (should be calculated, not directly set in model usually)
        public decimal NetSalary { get; private set; } // Set internally, or by a service/controller

        // Timestamp for when the payroll entry was last updated/saved
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Calculates the Net Salary based on other components.
        /// This method can be called whenever any salary component changes.
        /// </summary>
        public void CalculateNetSalary()
        {
            NetSalary = BasicSalary + PersonalizedIncrement + NewYearBonus + TransportAllowance + ChristmasAllowance;
        }

        /// <summary>
        /// Constructor to initialize a new PayrollEntry.
        /// </summary>
        public PayrollEntry()
        {
            // Default constructor
        }

        /// <summary>
        /// Constructor to initialize a PayrollEntry with initial values.
        /// </summary>
        public PayrollEntry(string employeeName, string employeeId, string facultyDepartment, string grade,
                            decimal basicSalary, decimal personalizedIncrement, decimal newYearBonus,
                            decimal transportAllowance, decimal christmasAllowance)
        {
            EmployeeName = employeeName;
            EmployeeId = employeeId;
            EmployeeFacultyDepartment = facultyDepartment;
            EmployeeGrade = grade;
            BasicSalary = basicSalary;
            PersonalizedIncrement = personalizedIncrement;
            NewYearBonus = newYearBonus;
            TransportAllowance = transportAllowance;
            ChristmasAllowance = christmasAllowance;

            CalculateNetSalary(); // Calculate net salary upon creation
        }
    }

}
