using System.Text.Json;

namespace Accounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running account demo.");
            IAccount account1 = new NamedAccount("John");
            account1.Deposit(1000);
            account1.Withdraw(100);
            int balance = account1.Balance;
            Console.WriteLine($"Account Balance is {balance}.");

            var jsonSerializationOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string strJson = JsonSerializer.Serialize(account1, jsonSerializationOptions);
            Console.WriteLine(strJson);
        }
    }
}