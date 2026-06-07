namespace HomeWork2.task2
{
    public class BankAccount
    {
        private int balance;

        public void Deposite(double amount)
        {
            balance += (int)amount;
            Console.WriteLine($"deposited : +{amount}$  yuor new balance is : {balance}$");
        }

        public void withdraw(double amount)
        {
            if (balance >= amount)
            {

                balance -= (int)amount;
                Console.WriteLine($"Withdrawed : -{amount}$ . yuor new balance is : {balance}$");
            }
            else
            {
                Console.WriteLine("insifiton fund . can not withdraw this amount");
            }

        }
        public void ShowBalance()
        {
            Console.WriteLine( $"account balance : {balance}$");
            }
        }
    }

