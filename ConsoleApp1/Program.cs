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
            private readonly ClientList ClientList = new ClientList();
            private readonly AccountList AccountList = new AccountList();

            public void AddClient() 
            {
                Client client = new Client();
                this.ClientList.Add(client);
            }
            public void RemoveClient(int id) 
            {
                this.ClientList.Remove(id);
            }
            public void AddAccount(AccountBase account) { AccountList.Add(account) }
            public void RemoveAccount(AccountBase account) { AccountList.Remove(account) }
        }

        public class ClientList
        {
            private readonly List<Client> _clients = new List<Client>();

            public void Add(Client client) { _clients.Add(client); }
            public void Remove(int id) {
                Client client = this._clients.Find(item => item.Id == id);
                this._clients.Remove(client); 
            }
        }


        public class AccountList
        {
            private readonly List<AccountBase> _accounts = new List<AccountBase>();

            public void Add(AccountBase account) { _accounts.Add(account); }
            public void Remove(int id)
            {
                AccountBase account = this._accounts.Find(item => item.Id == id);
                this._accounts.Remove(account);
            }
        }


        public class Client
        {
            public string Name { get; set; }
            public string Lastname { get; set; }
            public int Age { get; set; }
            public int Id { get; set; }
        }

        public class AccountBase
        {
            public int Id { get; set; }
            public float Balance { get; set; } = 0f;

            private TransactionHistory TransactionHistory = new TransactionHistory();

            public void Withdraw(float money) {
                this.Balance -= money;
                Transaction transaction = new Transaction();
                transaction.Add(this.Id, DateTime.Now, "Withdraw", money);
                TransactionHistory.Add(transaction);
            }
            public void Deposit(float money) {
                this.Balance += money;
                Transaction transaction = new Transaction();
                transaction.Add(this.Id, DateTime.Now, "Deposit", money);
                TransactionHistory.Add(transaction);
            }
            public void GetTransactionInfo(int id)
            {
                this.TransactionHistory.Display(id);
            }
        }

        public class Transaction
        {
            private int Id { get; set; }
            private string Date { get; set; }
            private string Operation { get; set; }
            private float Amount { get; set; }

            public void Add(int id, DateTime date, string operation, float amount)
            {
                this.Id = id;
                this.Date = date.ToString("dddd, dd MMMM yyyy HH:mm");
                this.Operation = operation;
                this.Amount = amount;
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

