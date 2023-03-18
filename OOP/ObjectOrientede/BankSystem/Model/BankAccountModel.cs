using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BankSystem.Model
{
    public class BankAccountModel
    {
        #region Properties
        public Image ProfilePicture { get; set; } = new();
        public string UserName { get; set; }
        private double Balance { get; set; }
        public string EmailAdress { get; set; }
        public int PhoneNumber { get; set; }
        public AddressModel Adress { get; set; }
        #endregion

        #region Constructor
        public BankAccountModel(string userName)
        {
            this.UserName = userName;
            this.Balance = 10;
            ProfilePicture = new();
            _randomPicture();
        }
        public BankAccountModel(BankAccountModel user)
        {
            this.ProfilePicture = user.ProfilePicture;
            this.UserName = user.UserName;
            this.Balance = user.Balance;
            this.EmailAdress = user.EmailAdress;
            this.PhoneNumber = user.PhoneNumber;
            this.Adress = user.Adress;
        }
        public BankAccountModel()
        {
            this.UserName = "Bruger Navnet";
            this.Balance = 123;
            this.EmailAdress = "bruger@email.com";
            this.PhoneNumber = 128923;
            this.Adress = new()
            {
                FullAdress = "Din fulde Adress"
            };
        }
        #endregion

        #region Methods
        private void _randomPicture()
        {
            Random r = new();
            ProfilePicture.Source = new BitmapImage(new Uri($"https://thispersondoesnotexist.xyz/img/400{r.Next(10)}.jpg"));
            ///The used URL/Link contains an image of an unexisted person I
            ///change the value of the last digit in the range of 1 and 10, to
            ///get a new picture

        } //Randomises User ProfilePicture

        public void CheckBalance() => MessageBox.Show($" Din Balance er på {this.Balance}"); //returns current Balance

        public void WithDraw(double Ammount)
        {
            if (CanWithDraw())
            {
                Balance = Balance - Ammount;
            }
            else
                MessageBox.Show($"Du har ikke nok penge på din konto \n Din Balance er på {Balance}");
        } // Reduce the current balance by the given input

        private bool CanWithDraw()
        {
            if (Balance > 0) { return true; }
            else { return false; }
        } //returns true if user can withdraw money
        #endregion
    }
}
