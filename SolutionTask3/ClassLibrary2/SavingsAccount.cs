using System;
using ClassLibrary1;

namespace ClassLibrary2
{
    public class SavingsAccount : Account
    {
        float interests;
        public SavingsAccount(string name, float balance, string gender, string houseno, string roadno, string area, string city, string pass,float interest) : base(name,balance,gender,houseno,roadno,area,city,pass)
        {
            this.interests = interest;
            this.Balance += (Balance / interests);
        }
        public float Interest
        {
            set { this.interests = value; }
            get { return interests; }
        }
        public void ShowSavingsDetails()
        {
            Console.WriteLine("Your Savings Account name: " + this.Name + "\nYour Savings Account Id: " + this.AccountId + "\nYour Savings Account Balance With " + interests + "% Interest: " + this.Balance);
            ShowAccountDetails();
        }
        public string Proparty()
        {
            return "Your Savings Account Total Proparty Is " + Balance;
        }
    }
}
