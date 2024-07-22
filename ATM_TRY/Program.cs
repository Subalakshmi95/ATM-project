using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ATM_TRY
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();

          
                    
       /* void Pswd_Check()
            {
                Console.WriteLine("WELCOME TO BANK OF INDIA");
                Console.WriteLine("\nINSERT YOUR ATM CARD");
                Console.WriteLine("\nENTER YOUR PASSWORD");
                int pswd = int.Parse(Console.ReadLine());
                if (pswd == 9999)
                {
                    Console.WriteLine("YOU HAVE ENTERED CORRECT PASSWORD");
                }
                else
                {
                    Console.WriteLine("YOU HAVE ENTERED INCORRECT PASSWORD");
                    Console.WriteLine("\n PLEASE ENTER CORRECT PASSWORD");

                }
            }
       */     bool b = true;
            while (b)
            {
                
                Console.WriteLine("ENTER YOUR CHOICE");
                Console.WriteLine("1.ENTER YOUR PASSWORD");
                Console.WriteLine("2.ACCOUNT DETAILS");
                Console.WriteLine("3.CHECK BALANCE");
                Console.WriteLine("4.DEPOSIT");
                Console.WriteLine("5.WITHDRAWAL");
                Console.WriteLine("6.exit");
               
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        
                        
                            Console.WriteLine("WELCOME TO BANK OF INDIA");
                            Console.WriteLine("\nINSERT YOUR ATM CARD");
                            Console.WriteLine("\nENTER YOUR PASSWORD");
                            int pswd = int.Parse(Console.ReadLine());
                            if (pswd == 9999)
                            {
                                Console.WriteLine("YOU HAVE ENTERED CORRECT PASSWORD");
                            }
                            else
                            {
                                Console.WriteLine("YOU HAVE ENTERED INCORRECT PASSWORD");
                                Console.WriteLine("\n PLEASE ENTER CORRECT PASSWORD");

                            }
                         break;

                    case 2:
                        p.Account_Details();
                        break;
                    case 3:
                        p.CHECK_BALANCE();
                        break;
                    case 4:

                        p.DEPOSIT();
                        break;
                    case 5:
                        p.WITHDRAWAL();
                        break;
                    case 6:
                        b = false;
                        break;
                    default:
                        Console.WriteLine("TRY AGAIN SORRY FOR THE INCONVENIENCE!");
                        break;
                }
            }

        }
        int Balance = 50000;
       /* void Pswd_Check()
        {
            Console.WriteLine("WELCOME TO BANK OF INDIA");
            Console.WriteLine("\nINSERT YOUR ATM CARD");
            Console.WriteLine("\nENTER YOUR PASSWORD");
            int pswd = int.Parse(Console.ReadLine());
            if (pswd == 9999)
            {
                Console.WriteLine("YOU HAVE ENTERED CORRECT PASSWORD");
            }
            else
            {
                Console.WriteLine("YOU HAVE ENTERED INCORRECT PASSWORD");
                Console.WriteLine("\n PLEASE ENTER CORRECT PASSWORD");

            }
        }*/


       public void Account_Details()
            {
                Console.WriteLine("ACCOUNT HOLDER'S NAME : SUBALAKSHMI \n ACCOUNT NUMBER : 45367892517654 \n IFSC CODE : 54687876 \n BRANCH : CHENNAI");
            }
       public void CHECK_BALANCE()
            {
                Console.WriteLine("YOUR CURRENT ACCOUNT BALANCE IS:" + Balance);
            }
       public void DEPOSIT()
            {
                Console.WriteLine("ENTER THE DEPOSIT AMOUNT :");
                int dep = int.Parse(Console.ReadLine());
                Balance += dep;

            Console.WriteLine($"YOUR DEPOSIT AMOUNT IS :{dep} AND CURRENT BALANCE IS : {Balance}");
        }
        void WITHDRAWAL()
        {
            Console.WriteLine("ENTER YOUR WITHDRAWAL AMOUNT:");
            int withdr = int.Parse(Console.ReadLine());
            if (withdr <= Balance)

            {
                Balance -= withdr;
                Console.WriteLine($"YOUR WITHDRAWAL AMOUNT IS:{withdr} and current balance is : {Balance}");

            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }

        }
    }





