namespace EmployeeOPP.Classes
{
	public class Date
	{
		#region Fields
		private int _year;
		private int _month;
		private int _day;
        #endregion

        #region Methods
        public Date(int day, int month, int year)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public override string ToString() 
        {
            //dia/mes/año
            var dateConcatenated = _day + "/" + _month + "/" + _year;
            return dateConcatenated;
        }
        #endregion
    }
}