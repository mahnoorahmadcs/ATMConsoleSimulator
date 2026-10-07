using System;

class ATM
{

    static int correctPIN = 1234;
    static double balance = 5000;

    static void CheckBalance(double balance)
    {
        Console.WriteLine("Current Balance: Rs. " + balance);
    }

    static double Deposit(double balance, double amount)
    {
        balance = balance + amount;
        Console.WriteLine("Deposit successful. New balance: Rs. " + balance);
        return balance;
    }

    static double Withdraw(double balance, double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds. Your balance is Rs. " + balance);
        }
        else
        {
            balance = balance - amount;
            Console.WriteLine("Withdrawal successful. New balance: Rs. " + balance);
        }

        return balance;
    }

    static void Main()
    {
        int attempts = 0;
        bool authenticated = false;

        
        while (attempts < 3)
        {
            Console.Write("Enter PIN: ");
            int enteredPIN = Convert.ToInt32(Console.ReadLine());

            if (enteredPIN == correctPIN)
            {
                authenticated = true;
                Console.WriteLine("Welcome! Your current balance is Rs. " + balance);
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Incorrect PIN.");
            }
        }

       
        if (!authenticated)
        {
            Console.WriteLine("Card locked. Too many incorrect attempts.");
            return;
        }

       
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine();
            Console.WriteLine("1) Check Balance");
            Console.WriteLine("2) Deposit");
            Console.WriteLine("3) Withdraw");
            Console.WriteLine("4) Exit");
            Console.Write("Choose an option: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CheckBalance(balance);
            }
            else if (choice == 2)
            {
                Console.Write("Enter deposit amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                balance = Deposit(balance, amount);
            }
            else if (choice == 3)
            {
                Console.Write("Enter withdrawal amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                balance = Withdraw(balance, amount);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thank you for using the ATM.");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}

