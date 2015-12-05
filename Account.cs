using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace phoney_warehouse
{
    class Account
    {
        private string accountnumber;
        private Customer accountOwner;
        protected int accountUsage;
        protected double accountFees;
        protected double accountCost;


        public string AccountNumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
        }
        public Customer AccountOwner
        {
            get { return accountOwner; }
            set { accountOwner = value; }
        }
        public virtual int AccountUsage
        {
            get { return accountUsage; }
            set { accountUsage = value; }
        }
        public virtual double AccountFees
        {
            get { return accountFees; }
            set { accountFees = value; }
        }
        public virtual double AccountCost
        {
            get { return AccountCost; }
            set { AccountCost = value; }
        }



    }
    class PayAsYouGoAccount : Account
    {

        double acccost = 0.10;
        override public double AccountCost
        {
            get { return accountCost; }
            set { accountCost = acccost; }
        }
    }
    class Saver : Account
    {
        double accfees = 10;
        int accusage = 200;
        double acccost = 0.20;
        override public double AccountFees
        {
            get { return accountFees; }
            set { accountFees = accfees; }
        }
        override public int AccountUsage
        {
            get { return accountUsage; }
            set { accountUsage = accusage; }
        }
        override public double AccountCost
        {
            get { return accountCost; }
            set { accountCost = acccost; }
        }
    }
    class Regular : Account
    {
        double accfees=20;
        int accusage=500;
        double acccost = 0.35;
        override public double AccountFees
        {
            get { return accountFees; }
           
            set { accountFees = accfees; }
          
        }
        override public int AccountUsage
        {
            get { return accountUsage; }
            set { accountUsage = accusage; }
        }
        override public double AccountCost
        {
            get { return accountCost; }
            set { accountCost = acccost; }
        }
    }

}
