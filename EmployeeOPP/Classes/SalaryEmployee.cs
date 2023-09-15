﻿namespace EmployeeOOP.Classes
{
    public class SalaryEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }

        #endregion

        #region Methods

        public SalaryEmployee()
        {

        }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            var salaryConcatenated = $"Salario Devengado: {Salary:C2}\n\t";
            return salaryConcatenated;


        }

        #endregion
    }
}