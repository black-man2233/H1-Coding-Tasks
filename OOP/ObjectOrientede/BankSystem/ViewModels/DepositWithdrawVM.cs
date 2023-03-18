using BankSystem.Model;

namespace BankSystem.ViewModels
{
    class DepositWithdrawVM
    {
        public BankAccountModel User { get; set; }

        public DepositWithdrawVM()
        {
            User = new(CreateUserVM.CurrentUserAccount);
        }
    }
}