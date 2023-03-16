using System;

namespace BankSystem.Model.DateAndTime
{
    public class DateModel : Utilities.ViewModelBase
    {
        #region Properties
        private int _day;
        public int Day
        {
            get { return _day; }
            set { _day = value; OnPropertyChanged(); }
        }

        private int _month;
        public int Month
        {
            get { return _month; }
            set { _month = value; OnPropertyChanged(); }
        }

        private int _year;
        public int Year
        {
            get { return _year; }
            set { _year = value; OnPropertyChanged(); }
        }

        #endregion

        #region Cunstructor
        public DateModel()
        {
            DateTime dateTime = DateTime.Now;
            this.Day = dateTime.Day;
            this.Month = dateTime.Month;
            this.Year = dateTime.Year;

        }

        #endregion


    }
}
