namespace Accounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running account demo.");
            IAccount account1 = createTestAccount();
            account1.Deposit(1000);
            account1.Withdraw(100);
            int balance = account1.Balance;
            Console.WriteLine($"Account Balance is {balance}.");

            var jsonSerializationOptions = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString1 = System.Text.Json.JsonSerializer.Serialize<IAccount>(account1, jsonSerializationOptions);
            Console.WriteLine(jsonString1);

            // the previous approach is valid.
            // https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/migrate-from-newtonsoft?pivots=dotnet-7-0
            // However, now it does not support Polymorphic serialization
            // https://www.reddit.com/r/csharp/comments/tnmgs4/newtonsoftjson_vs_systemtextjson_vs_jsonnet/
            var jsonString2 = Newtonsoft.Json.JsonConvert.SerializeObject(account1, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(jsonString2);
        }

        private static IAccount createTestAccount()
        {
            return new NamedAccount("John");
        }
    }
}