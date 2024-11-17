namespace ConsoleApp1
{
    public class BankAccount
    {
        private decimal _balance;
        public int AccountNumber { get; set; }


    public decimal Balance 
        {
            get => _balance;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Your balance can not be a negative number!");
                }
                else
                {
                    _balance = value;
                }
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Successfully tranfered {amount}$ to your account! Your updated balance is {Balance}");
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}$ from your account! Your updated balance is {Balance}");
        }

    }
}
