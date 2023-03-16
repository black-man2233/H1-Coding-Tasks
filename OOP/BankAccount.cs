using System;

public class BankAccount
{
    public string OwnerName { get; set; }
    public int Balance { get; }

    public BankAccount(string UserName)
    {
        this.OwnerName = UserName;
        this.Balance = 0;
    }

    public void CheckBalance() => Console.WriteLine($" Din Balance er på {Balance}");

    public void


}
