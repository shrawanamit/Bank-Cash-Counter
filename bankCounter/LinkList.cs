using System;
using System.Collections.Generic;
using System.Text;

namespace bankCounter
{
    public class LinkList<T>
    {
        class Node
        {
            public Node next;
            public string data;
            public CostumerRegistration costumerRegistration;

            public Node(CostumerRegistration costumerRegistration)
            {
                this.costumerRegistration = costumerRegistration;
            }


            public Node(string costumerRegistration)
            {
                data = costumerRegistration;
                next = null;
            }
        }

        Node head, temp;
        int count = 0;
        public void AddCostumerToQueue(CostumerRegistration costumerRegistration)
        {
                
            Node node = new Node(costumerRegistration);
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
                Console.WriteLine(currNode.data + " ");

                // Go to next node 
                currNode = currNode.next;
            }

        }
    }
}

