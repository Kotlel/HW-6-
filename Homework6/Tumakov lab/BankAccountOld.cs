using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_lab
{
    internal class BankAccountOld
    {
        private int accountNum;
        private decimal balance;
        private AccountType accountType;
        public BankAccountOld(int accountNum, decimal balance, AccountType accountType)
        {
            if (balance >= 0 && accountNum >= 0)
            {
                this.accountNum = accountNum;
                this.balance = balance;
                this.accountType = accountType;
            }
            else { Console.WriteLine("Введите номер и баланс правильно"); }
        }
            public string GetFullInfoOld()
            {
                return $"Номер счёта {accountNum}, Баланс {balance}, Тип счёта {accountType}";
            }
        
    }
}
