using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bankkonto
{
    public class BankAccount
    {
        private int balance { get; set; }
        
        public void withdraw(int amount) {
            if (amount < 0) {
                throw new ArgumentOutOfRangeException("Invalid amount");
            }
            if(balance - amount < 0) {
                Console.WriteLine("You don't have enough money in your account");
            } else {
                balance -= amount;
                Console.WriteLine($"You withdrew {amount}");
                Console.WriteLine($"Your new balance is {balance}");
            }
        }

        public void deposit(int amount) {
            balance += amount;
            Console.WriteLine($"You deposited {amount}");
            Console.WriteLine($"Your new balance is {balance}");
        }

        public void print() {
            Console.WriteLine($"Your current balance is: {balance}");
        }
    }
}