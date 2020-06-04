using System;
using System.Collections.Generic;
using System.Text;

namespace bankCounter
{
    public class CostumerRegistration
    {
        string name;
        uint mobileNumber;
        uint balance;

        public CostumerRegistration(string name, uint mobileNumber, uint balance)
        {
            this.name = name;
            this.mobileNumber = mobileNumber;
            this.balance = balance;
        }

        public string GetName()
        {
            return name;
        }
        public uint GetBalance()
        {
            return balance;
        }

        public uint GetMobileNumber()
        {
            return mobileNumber;
        }
        


    }
}
