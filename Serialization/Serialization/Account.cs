using System;
using System.Text.Json.Serialization;

[Serializable]
public class Account
{
    //Private members of Account class 
    //and Adding [JsonInclude] because to restore private fields.
    [JsonInclude]
    private int accountNo;
    [JsonInclude]
    private string accountHolderName;
    [JsonInclude]
    private string bankName;
    [JsonInclude]
    private double balance;

    public Account() { }

    public int GetAccountNo()
    {
        return accountNo;
    }

    public void SetAccountNo(int accNo)
    {
        accountNo = accNo;
    }

    public string GetAccountHolderName()
    {
        return accountHolderName;
    }

    public void SetAccountHolderName(string name)
    {
        accountHolderName = name;
    }

    public string GetBankName()
    {
        return bankName;
    }

    public void SetBankName(string bank)
    {
        bankName = bank;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void SetBalance(double bal)
    {
        if (bal < 500)
        {
            Console.WriteLine("Minimum balance should be ₹500");
        }
        else
        {
            balance = bal;
        }
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Amount Deposited Successfully");
    }

    public void Withdraw(double amount)
    {
        if (balance - amount < 500)
        {
            Console.WriteLine("Insufficient Balance! Minimum ₹500 should be maintained.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Amount Withdrawal is Successful.");
        }
    }

    public double CheckBalance()
    {
        return balance;
    }
}