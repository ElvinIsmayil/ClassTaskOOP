namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.AccountNumber = 1;  
            account.Balance = 0;

            int input;

            do
            {
                Console.WriteLine("Choose an operation: ");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance");
                Console.WriteLine("0. Exit");

                input = int.Parse(Console.ReadLine());




                switch (input)
                {
                    

                    case 1:
                        Console.WriteLine("Please enter the amount of money you want to deposit to your account:");
                        decimal amount1 = Convert.ToDecimal(Console.ReadLine());
                        account.Deposit(amount1);
                        break;

                    case 2:
                        Console.WriteLine("Please enter the amount of money you want to withdraw from your account:");
                        decimal amount2 = Convert.ToDecimal(Console.ReadLine());
                        account.Withdraw(amount2);
                        break;
                    case 3:
                        Console.WriteLine(account.Balance);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("There is no such action");
                        break;

                }

            } while (input!=0);



        }
    }
}
