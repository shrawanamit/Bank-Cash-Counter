using System;

namespace bankCounter
{
    public class LinkList<T>
    {
        class Node
        {
            public Node next;
            public uint accountNumber;
            public string name;
            public uint mobileNumber;
            public uint balance;
            public Node(uint accountNumber, string name, uint mobileNumber, uint balance)
            {
                this.accountNumber = accountNumber;
                this.name = name;
                this.mobileNumber = mobileNumber;
                this.balance = balance;
            }
        }

        Node head, temp;
        
        public void AddCostumerToQueue(uint accountNumber, string name, uint mobileNumber, uint balance)
        {
                
            Node node = new Node( accountNumber,  name,  mobileNumber,  balance);
            if (head == null)
            {
                head = temp = node;
            }
            else
            {
                 temp.next = node;
                 temp = node;
            }
        }
        
        
        
        public void PrintCostumerData()
        {
            Node currNode =head;
            Console.WriteLine("CostumerData: ");

            
            while (currNode != null)
            {
                // Print the data at current node 
                Console.Write("Account Number : " + currNode.accountNumber + "\n" +
                              "User Name      : " + currNode.name + "\n" +
                              "Mobile Number  : " + currNode.mobileNumber + "\n" +
                              "Account Balance: " + currNode.balance + "\n\n");
                
                // Go to next node 
                currNode = currNode.next;
            }

        }
    }
}

