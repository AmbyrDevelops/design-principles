using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount()
        {
        }

        public BankAccount(decimal balance) {
            Deposit(balance);
        }

        public decimal GetBalance() {
            return this.balance;
        }

        public void SetBalance(decimal balance) {
            this.balance = balance;
        }

        public void Deposit(decimal amount) {
            if (amount < 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "The deposit amount cannot be negative");
            }
            
            else if (amount == 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "The deposit amount cannot be zero");
            }

            else {
                this.balance += amount;
            }
        }

        public void Withdraw(decimal amount) {
            if (amount < 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "The withdrawal amount cannot be negative");
            }

            else if (amount == 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "The withdrawal amount cannot be zero");
            }

            else if (amount > this.balance) {
                throw new ArgumentOutOfRangeException(nameof(amount), "The withdrawal amount cannot be greater than the account balance");
            }

            else {
                this.balance -= amount;
            }
        }
    }
}