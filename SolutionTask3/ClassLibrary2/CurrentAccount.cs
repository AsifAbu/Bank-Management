using System;
using ClassLibrary1;

namespace ClassLibrary2
{
    public class CurrentAccount : Account
    {
        float interestc;
        public CurrentAccount()
        {
            this.interestc = 0;
            this.Balance += (Balance / interestc);
        }
        public CurrentAccount(string name, float balance, string gender, string houseno, string roadno, string area, string city, string pass,float interest) : base(name,balance,gender,houseno,roadno,area,city,pass)
        {
            this.interestc = interest;
            this.Balance += (Balance / interestc);
        }
        public float Interest
        {
            set { this.interestc = value; }
            get { return interestc; }
        }
        public string InterestRate()
        {
            return "Your Account Adding Interest is " + interestc;
        }
        public void ShowCurrentDetails()
        {
            Console.WriteLine("Your Current Account name: " + this.Name + "\nYour Current Account Id: " + this.AccountId + "\nYour Current Account Balance: " + this.Balance);
            ShowAccountDetails();
        }
    }
}
