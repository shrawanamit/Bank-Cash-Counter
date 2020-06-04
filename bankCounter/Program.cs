using System;

namespace bankCounter
{
    class Bank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO Bank...!!!");
            string userInput;
            int choice = 0, amount, accountNumber;
            Console.Write("1. Add User\n2. Deposit Money\n3. With Drow Money\n4. Check Acount Balance\n");
            Console.WriteLine("\nSelect Your Choice : ");
            userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            Console.WriteLine(choice);

            switch (choice)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    Console.WriteLine("Enter Amount To Be Deposit : ");
                    userInput = Console.ReadLine();
                    amount = Convert.ToInt32(userInput);
                    Deposit(amount);
                    break;
                case 3:
                    Console.WriteLine("Enter Amount To Be Withdrow : ");
                    userInput = Console.ReadLine();
                    amount = Convert.ToInt32(userInput);
                    withdrow(amount);
                    break;
                case 4:
                    Console.WriteLine("Enter Account Number To Search : ");
                    userInput = Console.ReadLine();
                    accountNumber = Convert.ToInt32(userInput);
                    CheckBalance(accountNumber);
                    break;
            }


        }

        private static void AddUser()
        {
            string userName, userAmount, number;
            uint amount, mobileNumber;
            Console.WriteLine("Enter User Name : ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter Mobile No : ");
            number = Console.ReadLine();
            mobileNumber = Convert.ToUInt32(number);
            Console.WriteLine("Enter starting Amount : ");
            userAmount = Console.ReadLine();
            amount = Convert.ToUInt32(userAmount);
            LinkList<CostumerRegistration> list = new LinkList<CostumerRegistration>();
            list.AddCostumerToQueue(new CostumerRegistration(userName, mobileNumber,amount));
            list.PrintCostumerData();

        }

        private static void CheckBalance(int accountNumber)
        {
            
        }

        private static void Deposit(int amount)
        {
           
        }

        private static void withdrow(int amount)
        {
           
        }
    }
    
}
