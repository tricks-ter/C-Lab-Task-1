using System;

namespace Test

{
    class Debt
    {
        private double balance;
        private double interestRate;

        public Debt() { }

        // Constructor to initialize balance and interest rate
        public Debt(double initialBalance, double initialInterestRate)
        {
            balance = initialBalance;
            interestRate = initialInterestRate;
        }

        // Method to print current balance
        public void PrintBalance()
        {
            Console.WriteLine(balance);
        }

        // Method to wait for one year and grow the debt amount
        public void WaitOneYear()
        {
            balance = balance * interestRate;

            PrintBalance();



        }
    }
}