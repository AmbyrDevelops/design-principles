using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Encapsulation
{
    public class CheckBankAccount : BankAccount {
        public void CheckBalance() {

            // Example of using a private variable to demonstrate encapsulation logic
            BankAccount bankAccount = new BankAccount();
            bankAccount.SetBalance(1000);
            System.Console.WriteLine($"Starting balance: {bankAccount.GetBalance()}");

            // Depositing to the bank account
            bankAccount.Deposit(500);
            System.Console.WriteLine($"New balance: {bankAccount.GetBalance()}");

            // Withdrawing from the bank account
            bankAccount.Withdraw(200);
            System.Console.WriteLine($"New balance: {bankAccount.GetBalance()}");
        }
    }
}