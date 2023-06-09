﻿using BankSystem.Model;

namespace BankSystem.ViewModels
{
    public class UserProfileVM
    {
        public BankAccountModel User { get; set; }
        public UserProfileVM()
        {
            User = new(CreateUserVM.CurrentUserAccount);
        }

    }
}
