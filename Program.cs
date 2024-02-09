using System;

namespace Program
{
    public class Accounts
    {
        public string Name { get; private set; }
        public float Money { get; private set; }

        public Accounts(string name, float money)
        {
            Name = name;
            Money = money;

            Console.WriteLine($"\n\n{name}, Your Account has been created.\nYour Account balance is: {money}\n");
        }

        public void Withdraw(float amount)
        {
            if (amount <= Money)
            {
                Money -= amount;
                Console.WriteLine($"Your Current Balance is: {Money}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void Deposit(float amount)
        {
            Money += amount;
            Console.WriteLine($"Your Current Balance is: {Money}");
        }

        

    }
}
