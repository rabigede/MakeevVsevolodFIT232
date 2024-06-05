using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccountQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание списка данных о банковских счетах
            List<BankAccount> accounts = new List<BankAccount>
            {
                new BankAccount { AccountNumber = "1234567890", Name = "John Doe", Income = 1000, Expense = 500 },
                new BankAccount { AccountNumber = "9876543210", Name = "Jane Smith", Income = 2000, Expense = 1000 },
                new BankAccount { AccountNumber = "0123456789", Name = "Mike Jones", Income = 3000, Expense = 1500 },
                new BankAccount { AccountNumber = "1122334455", Name = "Mary Johnson", Income = 4000, Expense = 2000 },
                new BankAccount { AccountNumber = "2233445566", Name = "Bob Brown", Income = 5000, Expense = 2500 },
            };

            // Запрос для отбора клиентов с отрицательным балансом
            var accountsWithNegativeBalance = from account in accounts
                                              where account.Balance < 0
                                              select account;

            // Подсчет количества клиентов с положительным балансом
            var countOfAccountsWithPositiveBalance = accounts.Count(account => account.Balance > 0);

            // Запрос для выдачи клиентов с максимальным доходом
            var accountWithMaxIncome = accounts.OrderByDescending(account => account.Income).First();

            // Подсчет общей суммы налогов
            var totalTaxAmount = accounts.Sum(account => account.Tax);

            // Вывод результатов
            Console.WriteLine("Клиенты с отрицательным балансом:");
            foreach (var account in accountsWithNegativeBalance)
            {
                Console.WriteLine($"{account.Name} ({account.AccountNumber})");
            }

            Console.WriteLine($"\nКоличество клиентов с положительным балансом: {countOfAccountsWithPositiveBalance}");

            Console.WriteLine($"\nКлиент с максимальным доходом:");
            Console.WriteLine($"{accountWithMaxIncome.Name} ({accountWithMaxIncome.AccountNumber})");

            Console.WriteLine($"\nОбщая сумма налогов: {totalTaxAmount}");
            Console.ReadKey();
        }

        public class BankAccount
        {
            public string AccountNumber { get; set; }
            public string Name { get; set; }
            public int Income { get; set; }
            public int Expense { get; set; }
            public int Tax { get { return (int)(Income * 0.05); } }
            public int Balance { get { return Income - Expense - Tax; } }
        }
    }
}