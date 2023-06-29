using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class Program
    {
        
        public class Bank
        {
            public void AddClient(Client client) { ClientList.Add(client) }
            public void RemoveClient(Client client) { ClientList.Remove(client) }
            public void AddAccount(AccountBase account) { AccountList.Add(account) }
            public void RemoveAccount(AccountBase account) { AccountList.Remove(account) }
        }

        public class ClientList
        {
            private readonly List<Client> _clients = new List<Client>();

            public void Add(Client client) { _clients.Add(client); }
            public void Remove(Client client) { _clients.Remove(client); }
        }


        public class AccountList
        {
            private readonly List<AccountBase> _accounts = new List<AccountBase>();

            public void Add(AccountBase account) { _accounts.Add(account); }
            public void Remove(AccountBase account) { _accounts.Remove(account); }
        }


        public class Client
        {
            private string Name { get; set; }
            private string Lastname { get; set; }
            private int Age { get; set; }
            private int Id { get; set; }
        }

        public class AccountBase
        {
            private int Id { get; set; }
            private float Balance { get; set; } = 0f;

            private TransactionHistory TransactionHistory = new TransactionHistory();

            public void Withdraw(float money) { this.Balance -= money; }
            public void Deposit(float money) { this.Balance += money; }
            public void GetTransactionInfo(int id)
            {
                this.TransactionHistory.Display(id);
            }
        }

        public class Transaction
        {
            private int Id { get; set; }
            private DateTime Date { get; set; }
            private string Operation { get; set; }
            private float Amount { get; set; }
            
            private TransactionHistory History;

            public void AddToHistory()
            {
                History.Add(new Transaction { Id = Id, Date = Date,Operation = Operation, Amount = Amount });
            }
        }

        public class TransactionHistory
        {
            private Stack<Transaction> List = new Stack<Transaction>();

            public void Add(Transaction transaction) { List.Push(transaction); }
            public void Display(int Id)
            {
                foreach(Transaction item in List)
                {
                    Console.Write(item + "\b");
                }
            }
        }

    }
}

