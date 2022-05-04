using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
    {
    internal class Account
        {
        private static int NextId { get; set; } = 1;
        public int AcctNbr { get; private set; } = 0;

        public string Name { get; set; } = string.Empty;

        public decimal Balance { get; private set; } = 0;


        public bool Deposit(decimal Amount)
            {
            if (Amount <= 0)
                {
                Console.WriteLine("Amount must be > zero");
                return false;
                }
            Balance = Balance + Amount;
            return true;
            }
        public bool Withdraw(decimal Amount)
            {
            if (Amount <= 0)
                {
                Console.WriteLine("Amount must be > zero");
                return false;
                }
            if (Amount > Balance)
                {
                Console.WriteLine("Insufficient Balance");
                return false;
                }

            Balance = Balance - Amount;
            return true;
            }

        public bool Transfer(decimal Amount, Account ToAccount)
            {
            var success = Withdraw(Amount);
            if (success)
                {
                ToAccount.Deposit(Amount);
                return true;
                }
            return false;
            }
        public Account() 
            {
            AcctNbr = NextId++;
            }
        }
    }
