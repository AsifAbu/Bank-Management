using System;

namespace ClassLibrary1
{
    public class Account
    {
        string name, accountId,password;
        float balance;
        static int count = 1;
        DateTime createDate;
        Address address;
        Gender gen;

        public Account()
        {
            this.name = "Guest-" + count;
            this.accountId = "GuestID-" + DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"); ;
            this.balance = 0;
            this.createDate = DateTime.Now;
            password = null;
            count++;
        }
        public Account(Account a)
        {
            this.name = a.name;
            this.accountId = a.accountId;
            this.balance = a.balance;
            this.gen = a.gen;
            this.password=a.password;
            count++;
        }
        public Account(string name, float balance, string gender, Address a,string pass)
        {
            this.name = name;
            this.accountId = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
            this.accountId += "" + count;
            this.balance = balance;
            this.createDate = DateTime.Now;
            this.address = a;
            this.password = pass;
            if (gender.ToUpper().Equals("F"))
            {
                this.gen = Gender.Female;
            }
            else if (gender.ToUpper().Equals("M"))
            {
                this.gen = Gender.Male;
            }
            else if (gender.ToUpper().Equals("B"))
            {
                this.gen = Gender.Common;
            }
            else
                this.gen = Gender.None;
        }
        public Account(string name, float balance, string gender,string houseno, string roadno, string area, string city,string pass)
        {
            this.name = name;
            this.accountId = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
            this.accountId += "" + count;
            this.balance = balance;
            this.createDate = DateTime.Now;
            this.password = pass;
            this.address = new Address(houseno, roadno, area, city);
            if (gender.ToUpper().Equals("F"))
            {
                this.gen = Gender.Female;
            }
            else if (gender.ToUpper().Equals("M"))
            {
                this.gen = Gender.Male;
            }
            else if (gender.ToUpper().Equals("B"))
            {
                this.gen = Gender.Common;
            }
            else
                this.gen = Gender.None;
        }
        private enum Gender : byte
        {
            Female,
            Male,
            Common,
            None
        }
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public string AccountId
        {
            set { this.accountId = value; }
            get { return accountId; }
        }
        public float Balance
        {
            set { this.balance = value; }
            get { return balance; }
        }
        public DateTime CreateDate
        {
            get { return createDate; }
        }
        public byte AccessGender
        {
            set
            {
                if (value == 0)
                    gen = Gender.Female;
                else if (value == 1)
                    gen = Gender.Male;
                else if (value == 2)
                    gen = Gender.Common;
                else
                    gen = Gender.None;
            }
            get
            {
                return (byte)gen;
            }
        }
        public string Password
        {
            set { password = value; }
            get { return null; }
        }
        public void ShowAccountDetails()
        {
            try
            {
                Console.WriteLine("Account Open Date: " + createDate + ",\nGender: " + gen);
                Console.Write("Address: ");
                address.AddressReturn();
            }
            catch
            {
                Console.Beep();
                Console.WriteLine("Try Catch Exception.");
            }
        }
        public void Withdraw(float ammount)
        {
            if (balance >= ammount && ammount>0)
            {
                this.balance -= ammount;
                Console.WriteLine("Your ammount Is Updated. Your Current balance Is: " + balance);
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Invalid input! Your Current Balance Is: " + balance);
            }
        }
        public void Deposit(float ammount)
        {
            if (ammount > 0)
            {
                this.balance += ammount;
                Console.WriteLine("Deposit SuccessFull. Current Accont Balance Is: " + balance);
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Invalid Input!");
            }
        }
        public void Transfer(float ammount, Account a)
        {
            if (balance >= ammount && ammount>0)
            {
                a.Balance += ammount;
                this.Balance -= ammount;
                Console.WriteLine("Your ammount Is Tranfared. Your Current balance Is: " + balance);
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Your ammount Is Law. Your Current Balance Is: " + balance);
            }
        }
    }
}
