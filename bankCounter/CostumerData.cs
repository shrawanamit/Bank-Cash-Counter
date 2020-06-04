using System;
using System.Collections.Generic;
using System.Text;

namespace bankCounter
{
    public class CostumerData
    {
        uint accountNumber;
        string name;
        uint mobileNumber;
        uint balance;

        public CostumerData(uint accountNumber,string name, uint mobileNumber, uint balance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.mobileNumber = mobileNumber;
            this.balance = balance;
        }

        

    }
}
