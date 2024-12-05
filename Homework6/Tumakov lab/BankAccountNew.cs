using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_lab
{
    enum AccountType { Current, Savings }
    class BankAccountNew
    {
        private static int accountNumCounter = 0;
        private int accountNum;
        private decimal balance;
        private AccountType accountType;    
        public BankAccountNew(decimal balance, AccountType accountType)
        {
            if (balance >= 0)
            {
                this.accountNum = accountNumCounter++;
                this.balance = balance;
                this.accountType = accountType;
            }
            else { Console.WriteLine("Введите баланс правильно"); }
        }

        public string GetFullInfo()
        {
            return $"Номер счёта {accountNum}, Баланс {balance}, Тип счёта {accountType}";
        }
        public void AddMoney(decimal money)
        {
            this.balance += money;
        }
        public void TakeMoney(decimal money)
        {
            if ( money <= this.balance)
            {
                this.balance -= money;
            }
            else { Console.WriteLine("Операция не прошла. Недостаточно средств."); }
        }

    }
}
