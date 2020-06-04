using System;

namespace bankCounter
{
    class Bank
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Welcome TO Bank...!!!");

            while (true)
            {
                string accountNo,userInput;
                uint choice, amount, accountNumber;
                Console.Write("1. Add User\n2. Deposit Money\n3. With Drow Money\n4. Check Acount Balance\n5.Check Data of Each coustumer\n6.Exit\n");
                Console.WriteLine("\nSelect Your Choice : ");
                userInput = Console.ReadLine();
                choice = Convert.ToUInt32(userInput);
                Console.WriteLine(choice);

                switch (choice)
                {
                    case 1:
                        AddUser();
                        break;
                    case 2:
                        Console.WriteLine("Enter Acount number : ");
                        accountNo = Console.ReadLine();
                        accountNumber = Convert.ToUInt32(accountNo);
                        Console.WriteLine("Enter Amount To Be Deposit : ");
                        userInput = Console.ReadLine();
                        amount = Convert.ToUInt32(userInput);
                        Deposit(accountNumber, amount);
                        break;
                    case 3:
                        Console.WriteLine("Enter Amount To Be Withdrow : ");
                        userInput = Console.ReadLine();
                        amount = Convert.ToUInt32(userInput);
                        withdrow(amount);
                        break;
                    case 4:
                        Console.WriteLine("Enter Account Number To Search Coustermer Data: ");
                        userInput = Console.ReadLine();
                        accountNumber = Convert.ToUInt32(userInput);
                        CheckCoustemerData(accountNumber);
                        break;
                    case 5:
                        Console.WriteLine("All Coustumer Data : ");
                        PrintWholeCoustemerData();
                        break;
                    default:
                        Console.WriteLine("Enter correct input : ");
                        break;
                }
                if (choice == 6)
                {
                    Console.WriteLine("Thank You For Banking With Us..!!");
                    break;
                }
            }


        }
        
        private static void AddUser()
        {
            string accountNumber,userName, amountBalance, Mobumber, NumberOfcoustemer;
            uint amountNo, mobileNumber,amount,noOfcoustemer;
            Console.WriteLine("Enter no of custumer u want to add : ");
            NumberOfcoustemer = Console.ReadLine();
            noOfcoustemer = Convert.ToUInt32(NumberOfcoustemer);
            LinkList<CostumerData> list = new LinkList<CostumerData>();
            for (int i=0;i< noOfcoustemer; i++)
            {
                Console.WriteLine("coustomer no 1 : " +i);
                Console.WriteLine("Enter Account no : ");
                accountNumber = Console.ReadLine();
                amountNo = Convert.ToUInt32(accountNumber);
                Console.WriteLine("Enter User Name : ");
                userName = Console.ReadLine();
                Console.WriteLine("Enter Mobile No : ");
                Mobumber = Console.ReadLine();
                mobileNumber = Convert.ToUInt32(Mobumber);
                Console.WriteLine("Enter starting Amount : ");
                amountBalance = Console.ReadLine();
                amount = Convert.ToUInt32(amountBalance);
                list.AddCostumerToQueue(amountNo, userName, mobileNumber, amount);
            }
            list.PrintCostumerData();



        }
        private static void PrintWholeCoustemerData()
        {
            LinkList<CostumerData> list = new LinkList<CostumerData>();
            list.PrintCostumerData();
        }

        private static void CheckCoustemerData(uint accountNumber)
        {
            LinkList<CostumerData> list = new LinkList<CostumerData>();
            list.SearchCostumerData(accountNumber);

        }

        private static void Deposit(uint accountNumber,uint amount)
        {
            LinkList<CostumerData> list = new LinkList<CostumerData>();
            list.DepositAmount(accountNumber,amount);


        }

        private static void withdrow(int amount)
        {
           
        }
    }
    
}
