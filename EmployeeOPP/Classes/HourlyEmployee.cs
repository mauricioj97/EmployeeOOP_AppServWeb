using EmployeeOOP.Classes;

namespace EmployeeOPP.Classes
{
    public class HourlyEmployee:Employee
    {

        #region Properties
        
        public int Hour { get; set; }

        public decimal HourValue { get; set; }

        #endregion

        #region Methods

        public HourlyEmployee()
        {

        }

        public override decimal GetValueToPay()
        {
            return Hour;
        }

        public override string ToString()
        {
            var hourConcatenated = $"Valor Hora: {HourValue:C2}\n\t" +
            $"Horas Semanales: {Hour}\n\t";
            return hourConcatenated;
                
        }

        #endregion
    }

}
