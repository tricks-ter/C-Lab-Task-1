using System;
using System.Collections.Generic;
using Program;
using Test;

namespace Test
{
    public class Master
    {
        public static void Main(string[] args)
        {
            string choice;
            string sound;
            DecreasingCounter counter = new DecreasingCounter();
            Product products;
            Debt d = new Debt();
            Whistle w = new Whistle();
            Dalmatian dal = new Dalmatian();
            Gauge g = new Gauge();

            List<Accounts> accountList = new List<Accounts>();

            do
            {
                Console.WriteLine("\nEnter Your Choice and Type 'exit' to quit");
                Console.WriteLine("1.Create an Account ");
                Console.WriteLine("2.Deposit Money");
                Console.WriteLine("3.Withdraw Money");
                Console.WriteLine("4.Make a sound");
                Console.WriteLine("5.Hear the sound");
                Console.WriteLine("6.Display Product info");
                Console.WriteLine("7.Set Counter Counter");
                Console.WriteLine("8.Decrement from Counter");
                Console.WriteLine("9.Reset the counter");
                Console.WriteLine("10.Create Debt");
                Console.WriteLine("11.Wait years to check Balance");
                Console.WriteLine("12.Create Dalmatian Object");
                Console.WriteLine("13.Increase Gauge");
                Console.WriteLine("14.Decrease Gauge");
                Console.Write("Your Choice : ");

                choice = Console.ReadLine()!;

                switch (choice.ToLower())
                {
                    case "1":
                        Console.Write("\n\nEnter Your Name : ");
                        string username = Console.ReadLine()!;

                        Console.Write("\nEnter Initial Amount : ");
                        float initialAmount = float.Parse(Console.ReadLine()!);

                        Accounts newAccount = new Accounts(username, initialAmount);
                        accountList.Add(newAccount);
                        break;

                    case "2":
                        Console.Write("\nEnter The Name Of Account Holder : ");
                        string depositAccountName = Console.ReadLine()!;

                        Accounts depositAccount = accountList.Find(acc => acc.Name.Equals(depositAccountName, StringComparison.OrdinalIgnoreCase))!;
                        if (depositAccount != null)
                        {
                            Console.Write("\nEnter Amount to Deposit : ");
                            float depositAmount = float.Parse(Console.ReadLine()!);
                            depositAccount.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case "3":
                        Console.Write("\nEnter The Name Of Account Holder : ");
                        string withdrawAccountName = Console.ReadLine()!;

                        Accounts withdrawAccount = accountList.Find(acc => acc.Name.Equals(withdrawAccountName, StringComparison.OrdinalIgnoreCase))!;
                        if (withdrawAccount != null)
                        {
                            Console.Write("\nEnter Amount to Withdraw : ");
                            float withdrawalAmount = float.Parse(Console.ReadLine()!);
                            withdrawAccount.Withdraw(withdrawalAmount);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Enter The sound :");
                        sound = Console.ReadLine()!;

                        w = new Whistle(sound);
                        break;
                    case "5":
                        w.Sound();
                        break;

                    case "6":
                        Console.WriteLine("Enter the name of product : ");
                        string name = Console.ReadLine()!;
                        Console.WriteLine("Enter the price of product : ");
                        double price = double.Parse(Console.ReadLine()!);
                        Console.WriteLine("Enter the Quantity of product : ");
                        int q = int.Parse(Console.ReadLine()!);
                        products = new Product(name, price, q);
                        products.PrintProduct();
                        break;

                    case "7":


                        
                        Console.WriteLine("Enter a initial value for Counter ");
                        int value = int.Parse(Console.ReadLine()!);
                        counter = new DecreasingCounter(value);
                        counter.PrintValue();
                        break;

                    case "8":
                        counter.decrement();
                        break;

                    case "9":
                        counter.Reset();
                        break;

                    case "10":
                        Console.WriteLine("Enter The initial Balance for Debt");
                        double initbalance = double.Parse(Console.ReadLine()!);
                        Console.WriteLine("Enter The initial Interest Rate ");
                        double interestRate = double.Parse(Console.ReadLine()!);
                        d = new Debt(initbalance, interestRate);
                        d.PrintBalance();
                        break;

                    case "11":
                        Console.WriteLine("How many years do you want to wait");
                        int years = int.Parse(Console.ReadLine()!);
                        while(years > 0)
                        {
                            d.WaitOneYear();
                            years--;
                        }
                        d.PrintBalance() ;
                        

                        break;

                    case "12":
                        Console.WriteLine("Enter the name of dog");
                        name = Console.ReadLine()!;
                        Console.WriteLine("Enter the number of Spots ");
                        int spots = int.Parse(Console.ReadLine()!);
                        dal = new Dalmatian(name, spots);
                        break;

                    case "13":
                        g.Increase();
                        Console.WriteLine("Increased! Value: " + g.Value);
                        break;
                    case "14":
                        g.Decrease();
                        Console.WriteLine("Decreased! Value: " + g.Value);
                        break;







                    case "exit":
                        Console.WriteLine("Bye Bye");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice.ToLower() != "exit");
        }
    }
}
