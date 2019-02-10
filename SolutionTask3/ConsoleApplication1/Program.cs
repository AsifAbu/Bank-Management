using System;
using ClassLibrary1;
using ClassLibrary2;

namespace ClassLibrary1
{
    class Program
    {
        public static void WellcomeBank()
        {
            Console.WriteLine("\n\t\t\t\t\t===========================");
            Console.WriteLine("\t\t\t\t\tWellcome To Bank Management");
            Console.WriteLine("\t\t\t\t\t===========================\n");
        }
        public static void TakeDecession()
        {
            Console.WriteLine("\t\t\t\tWhat Do You Want: ");
            Console.WriteLine("\t\t\t\t\t1=> Open New Account.");
            Console.WriteLine("\t\t\t\t\t2=> Log In");
            Console.WriteLine("\t\t\t\t\t0=> Exit.");
        }
        public static void Login1()
        {
            Console.WriteLine("\n\t\t\t\t\tWhat Do You Want: ");
            Console.WriteLine("\t\t\t\t\t\t1=> Check Balance");
            Console.WriteLine("\t\t\t\t\t\t2=> Withdraw Money");
            Console.WriteLine("\t\t\t\t\t\t3=> Transfar Money");
            Console.WriteLine("\t\t\t\t\t\t4=> See Details of Your Account");
            Console.WriteLine("\t\t\t\t\t\t0=> Log out");
            Console.Write("Your Answer: ");
            
        }
        static void Main(string[] args)
        {
            string accname, gender, pas,interest;
            float balance;
            string houseNo, roadNo, area, city;

            WellcomeBank();
            PointMain:
            TakeDecession();
            Console.Write("Your Answer: ");
            int dec=int.Parse(Console.ReadLine());
            SavingsAccount sacc = new SavingsAccount("asif-acc1", 10000, "M", "28", "11", "Nikunjo-2", "Dhaka","1122",20);
            SavingsAccount sacc2 = new SavingsAccount("asif-acc2", 50000, "M", "0", "0", "Gopalpur", "Rajshahi", "1122", 10);
            switch (dec)
            {
                case 1:
                Point2:
                    Console.Clear();
                    WellcomeBank();
                    Console.WriteLine("\t\t\t\t\tWhich Type Account You Want To?");
                    Console.WriteLine("\t\t\t\t\t\t1=>Savings Account");
                    Console.WriteLine("\t\t\t\t\t\t2=>Current Account");
                    Console.WriteLine("\t\t\t\t\t\t0=>Back");int t;
                    Console.Write("Your Answer: ");
                    t=int.Parse(Console.ReadLine());
                    if (t == 1)
                    {
                        //SavingsAccount sacc = new SavingsAccount("asif-acc1", 10000, "M", "28", "11", "Nikunjo-2", "Dhaka", "1122", 20);
                        //SavingsAccount sacc2 = new SavingsAccount("asif-acc2", 50000, "M", "0", "0", "Gopalpur", "Rajshahi", "1122", 10);
                        Console.WriteLine("Type User Name: ");
                        accname = Console.ReadLine();
                        Console.WriteLine("Type Your Initial Balance: ");
                        balance = float.Parse(Console.ReadLine());
                        Console.WriteLine("Type Account Interest In Percent%: ");
                        interest =Console.ReadLine();
                        Console.WriteLine("Type Your Gender (M/F/B): ");
                        gender = Console.ReadLine();
                        Console.WriteLine("Type House Number: ");
                        houseNo = Console.ReadLine();
                        Console.WriteLine("Type Road Number: ");
                        roadNo = Console.ReadLine();
                        Console.WriteLine("Type Area: ");
                        area = Console.ReadLine();
                        Console.WriteLine("Type City: ");
                        city = Console.ReadLine();
                        Console.WriteLine("Type Password: ");
                        pas = Console.ReadLine();

                        string s = "0";
                        string s1 = "";
                        if (accname != s && accname != s1)
                        {
                            if (balance != 0)
                            {
                                if (gender != s && gender != s1)
                                {
                                    if (houseNo != s && houseNo != s1)
                                    {
                                        if (roadNo != s && roadNo != s1)
                                        {
                                            if (area != s && area != s1)
                                            {
                                                if (city != s && city != s1)
                                                {
                                                    if (interest != s1)
                                                    {
                                                        SavingsAccount ac3 = new SavingsAccount(accname, balance, gender, houseNo, roadNo, area, city, pas, 10);
                                                        Console.Clear();
                                                        Console.WriteLine("Registration Successfully.");
                                                        Console.WriteLine("Savings Account Created.");
                                                        WellcomeBank();
                                                        goto PointMain;
                                                    }
                                                    else
                                                        Console.WriteLine("Registration Un-Successfull..!!");
                                                }
                                                else
                                                    Console.WriteLine("Registration Un-Successfull..!!");
                                            }
                                            else
                                                Console.WriteLine("Registration Un-Successfull..!!");
                                        }
                                        else
                                            Console.WriteLine("Registration Un-Successfull..!!");
                                    }
                                    else
                                        Console.WriteLine("Registration Un-Successfull..!!");
                                }
                                else
                                    Console.WriteLine("Registration Un-Successfull..!!");
                            }
                            else
                                Console.WriteLine("Registration Un-Successfull..!!");
                        }
                        else
                            Console.WriteLine("Registration Un-Successfull..!!");
                        Main(args);
                    }
                    else if (t == 2)
                    {
                        Console.WriteLine("Type User Name: ");
                        accname = Console.ReadLine();
                        Console.WriteLine("Type Your Initial Balance: ");
                        balance = float.Parse(Console.ReadLine());
                        Console.WriteLine("Type Account Interest In Percent%: ");
                        interest = Console.ReadLine();
                        Console.WriteLine("Type Your Gender (M/F/B): ");
                        gender = Console.ReadLine();
                        Console.WriteLine("Type House Number: ");
                        houseNo = Console.ReadLine();
                        Console.WriteLine("Type Road Number: ");
                        roadNo = Console.ReadLine();
                        Console.WriteLine("Type Area: ");
                        area = Console.ReadLine();
                        Console.WriteLine("Type City: ");
                        city = Console.ReadLine();
                        Console.WriteLine("Type Password: ");
                        pas = Console.ReadLine();

                        string s = "0";
                        string s1 = "";
                        if (accname != s && accname != s1)
                        {
                            if (balance != 0)
                            {
                                if (gender != s && gender != s1)
                                {
                                    if (houseNo != s && houseNo != s1)
                                    {
                                        if (roadNo != s && roadNo != s1)
                                        {
                                            if (area != s && area != s1)
                                            {
                                                if (city != s && city != s1)
                                                {
                                                    if (interest != s1)
                                                    {
                                                        CurrentAccount ac3 = new CurrentAccount(accname, balance, gender, houseNo, roadNo, area, city, pas, 10);
                                                        Console.Clear();
                                                        Console.WriteLine("Registration Successfully.");
                                                        Console.WriteLine("Current Account Created.");
                                                        WellcomeBank();
                                                        goto PointMain;
                                                    }
                                                    else
                                                        Console.WriteLine("Registration Un-Successfull..!!");
                                                }
                                                else
                                                    Console.WriteLine("Registration Un-Successfull..!!");
                                            }
                                            else
                                                Console.WriteLine("Registration Un-Successfull..!!");
                                        }
                                        else
                                            Console.WriteLine("Registration Un-Successfull..!!");
                                    }
                                    else
                                        Console.WriteLine("Registration Un-Successfull..!!");
                                }
                                else
                                    Console.WriteLine("Registration Un-Successfull..!!");
                            }
                            else
                                Console.WriteLine("Registration Un-Successfull..!!");
                        }
                        else
                            Console.WriteLine("Registration Un-Successfull..!!");
                        Main(args);
                    }
                    else if (t == 0)
                    {
                        Console.Clear();
                        goto PointMain;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                        goto Point2;
                    }

                    break;

                case 2:
                    string id, pass;
                    
                    Console.Write("Type Your ID: ");
                    id=Console.ReadLine();
                    Console.Write("Type Your Password: ");
                    pass=Console.ReadLine();
                    if (id.Equals(sacc.Name) || id.Equals(sacc2.Name)) //if(id.Equals(sacc.Id) || id.Equals(sacc2.Id))
                    {
                        if (pass.Equals("1122"))
                        {
                            Console.Clear();
                            Console.WriteLine("Login SuccessFull...");
                            WellcomeBank();
                        Point3:
                            Login1();
                            int d = int.Parse(Console.ReadLine());
                            if (d == 1)
                            {
                                Console.WriteLine("Your Account Balance Is: " + sacc.Balance);
                                goto Point3;
                            }
                            else if (d == 2)
                            {
                                Console.Write("Enter How Much Money You Want To Withdrew: ");
                                sacc.Withdraw(float.Parse(Console.ReadLine()));
                                goto Point3;
                            }
                            else if (d == 3)
                            {
                                Console.Write("Enter How Much Money You Want To Transfer To 'Ac2' Account: ");
                                sacc.Transfer(float.Parse(Console.ReadLine()), sacc2);
                                goto Point3;
                            }
                            else if (d == 4)
                            {
                                sacc.ShowSavingsDetails();
                                goto Point3;
                            }
                            else if (d == 0)
                            {
                                Console.Clear();
                                Main(args);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input!");
                                Console.WriteLine("Try Again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Password Is Incorrect!");
                            goto PointMain;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID Number Is Incorrect!");
                        Main(args);
                    }
                
                break;
                case 0:
                    Environment.Exit(0);

                break;
                default:
                Console.Beep();
                Console.Clear();
                Console.WriteLine("Invalid Input!");
                Main(args);
                break;
            }
            
        }
    }
}
