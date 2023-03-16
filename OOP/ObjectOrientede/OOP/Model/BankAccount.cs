namespace OOP.Model
{
    public class BankAccount
    {
        public string OwnerName { get; set; }
        private double Balance { get; set; }

        public BankAccount(string UserName)
        {
            this.OwnerName = UserName;
            this.Balance = 0;

            OwnerName.ToString();
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
