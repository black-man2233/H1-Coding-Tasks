using BankSystem.Model;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using static BankSystem.Utilities.RelayCommands;

namespace BankSystem.ViewModels
{
    public class CreateUserVM : Utilities.ViewModelBase
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public ICommand SignInCommand { get; set; }
        BitmapImage ProfileImage { get; set; }

        BankAccountModel _currentUser;

        public CreateUserVM()
        {
            SignInCommand = new RelayCommand(Singin);
            _currentUser = new(System.Environment.UserName); //Gets the current PC user Name
            _name = _currentUser.OwnerName;
            ProfileImage = new();
            //ProfileImage = _currentUser.ProfilePicrure.Source.ToString();

            var a = _currentUser.ProfilePicrure.Source;
            MessageBox.Show(a.GetType().ToString());
        }
        private void Singin(Object obj)
        {
            if (obj is Window w)
            {
                MainWindow m = new();
                m.Show();
                w.Close();
            }
        }
    }
}
