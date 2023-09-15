using EmployeeOOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOPP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Properties


        public double Commission { get; set; }
        public int ValCommission { get; set; }
        public int Cv { get; set; }

        public decimal Sales { get; set; }

        #endregion

        #region Methods

        public CommissionEmployee()
        {

        }

        public override decimal GetValueToPay()
        {
            Console.Write("Ingresar cantidad ventas: ");
            Cv = Convert.ToInt32(Console.ReadLine());
            Sales = Convert.ToDecimal((ValCommission * Commission) * Cv);
            return Sales;
        }

        public override string ToString()
        {
            var commissionConcatenated =
            $"{base.ToString()}" +
                $"Ventas por comisiones: {Sales:C2}\n\t";
            return commissionConcatenated;
        }

        #endregion
    }
}
