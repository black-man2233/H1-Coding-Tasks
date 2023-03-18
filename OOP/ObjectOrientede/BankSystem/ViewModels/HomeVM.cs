using BankSystem.Model.DateAndTime;
using BankSystem.Utilities;

namespace BankSystem.ViewModels
{
    public class HomeVM : ViewModelBase
    {
        #region Properties
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }

        private DateModel _date;
        public DateModel Date
        {
            get { return _date; }
            set { _date = value; OnPropertyChanged(); }
        }

        private TimeModel _time;
        public TimeModel Time
        {
            get { return _time; }
            set { _time = value; OnPropertyChanged(); }
        }
        #endregion

        #region Cunstructors
        public HomeVM(string name)
        {
            this.UserName = name;
            _date = new DateModel();

            _time = new TimeModel();
            this.Time.Start();
        } //Takes Name as parameter
        public HomeVM()
        {
            this.UserName = new(CreateUserVM.CurrentUserAccount.UserName);

            _date = new DateModel();
            _time = new TimeModel();
            this.Time.Start();
        } //Takes no parameter
        #endregion
    }
}
