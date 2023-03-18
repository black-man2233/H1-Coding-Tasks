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
        public string Name { get; set; }
        public BitmapImage ProfileImage { get; set; }
        public static BankAccountModel CurrentUserAccount { get; set; } = new();

        public ICommand SignInCommand { get; set; }
        public CreateUserVM()
        {
            SignInCommand = new RelayCommand(Singin);
            CurrentUserAccount = new(System.Environment.UserName); //Gets the current PC user Name
            Name = CurrentUserAccount.UserName;

            CurrentUserAccount.PhoneNumber = 32456985;
            CurrentUserAccount.EmailAdress = new($"{CurrentUserAccount.UserName}@email.dk");
            CurrentUserAccount.Adress = new("Struervej", 17, 9000, "Allborg");

            ProfileImage = new BitmapImage(new Uri((CurrentUserAccount.ProfilePicture.Source).ToString()));
        }

        private void Singin(Object obj)
        {
            if (obj is Window @this)
            {
                MainWindow m = new();
                m.Show();
                @this.Close();
            }
        } //On Sign in BUtton press
    }
}
