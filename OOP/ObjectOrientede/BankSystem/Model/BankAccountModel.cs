using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BankSystem.Model
{
    public class BankAccountModel
    {
        public string OwnerName { get; set; }
        private double Balance { get; set; }
        public Image ProfilePicrure { get; set; } = new();

        private void _randomPicture()
        {
            Random r = new();
            ProfilePicrure.Source = new BitmapImage(new Uri($"https://thispersondoesnotexist.xyz/img/400{r.Next(10)}.jpg"));
        }

        public BankAccountModel(string UserName)
        {
            this.OwnerName = UserName;
            this.Balance = 10;
            ProfilePicrure = new();
            _randomPicture();
        }

        public void CheckBalance() => Console.WriteLine($" Din Balance er på {this.Balance}");

        public void WithDraw(double Ammount)
        {
            if (CanWithDraw())
            {
                Balance = Balance - Ammount;
            }
            else
            {
                Console.WriteLine($"Du har ikke nok penge på din konto \n Din Balance er på {Balance}");
            }
        }

        private bool CanWithDraw()
        {
            if (Balance > 0) { return true; }
            else { return false; }
        }
    }
}
