using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Encapsulation
{
    public class CheckBadBankAccount : BadBankAccount
    {
        public void CheckBalance()
        {
            // Example of bad pratice using a public variable
            BadBankAccount badAccount = new BadBankAccount();
            badAccount.balance = 1000;
            System.Console.WriteLine($"Checking bad account balance: {badAccount.balance}");
        }
    }
}