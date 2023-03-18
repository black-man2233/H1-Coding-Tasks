using System;
using System.Windows.Threading;

namespace BankSystem.Model.DateAndTime
{
    public class TimeModel : Utilities.ViewModelBase
    {
        private string _hour = "00";
        public string Hour
        {
            get { return _hour; }
            set { _hour = value; OnPropertyChanged(); }
        }

        private string _minutes = "00";
        public string Minutes
        {
            get { return _minutes; }
            set { _minutes = value; OnPropertyChanged(); }
        }

        private string _second = "00";
        public string Second
        {
            get { return _second; }
            set { _second = value; OnPropertyChanged(); }
        }

        DispatcherTimer timer = new DispatcherTimer();

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            this.Hour = currentTime.Hour.ToString("00");
            this.Minutes = currentTime.Minute.ToString("00");
            this.Second = currentTime.Second.ToString("00");
        }
        public void Start()
        {
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }
    }
}
