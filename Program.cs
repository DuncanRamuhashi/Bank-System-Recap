using Bank_System_Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {


                Console.WriteLine("=================================");
                Console.WriteLine("       BANK MANAGEMENT SYSTEM      ");
                Console.WriteLine("----------------------------------");


                //Name
                Console.WriteLine("Enter your name?");

                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Invalid name. Please try again.");
                    continue;
                }

                //ID Number
                Console.WriteLine("Enter your ID number?");
                string idNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(idNumber)) { 
                    Console.WriteLine("Invalid ID number. Please try again.");
                    continue;
                }

                //Account Type

                bool accountChoice;

                while (true) {

                    Console.WriteLine("Which type of account would you like to open?");
                    Console.WriteLine("1. Savings Account");
                    Console.WriteLine("2. Checking Account");

                    try
                    {
                        int choiceint = int.Parse(Console.ReadLine());
                        if (choiceint == 1)
                        {
                            accountChoice = true;
                            break;
                        }
                        else if (choiceint == 2)
                        {
                            accountChoice = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please try again.");

                        }
                    }
                    catch{
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                  
                   

                }


                //create customer
                Customer client = new Customer(
                    idNumber,
                    name,
                    accountChoice
                );

                // 
                Console.Clear();
                client.displayCustomerInfo();


                // Deposit money

                while (true)
                {

                    Console.WriteLine("How much you want to deposit?");
                    try
                    {
                        decimal deposit = decimal.Parse(Console.ReadLine());
                        client.Deposit(deposit);
                        Console.Clear();
                        client.displayCustomerInfo();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Only number characters are allowed");
                    }



                }



                //Withdraw money

                while (true) {
                    Console.WriteLine("How much you want to withdra");
                    try {

                       
                        decimal withdraw = decimal.Parse(Console.ReadLine());
                        client.Withdraw(withdraw);
                        Console.Clear();
                        client.displayCustomerInfo();
                        break;
                    } catch {

                        Console.WriteLine("Only number characters are allowed");
                    }
                
                }
                
                Console.WriteLine();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                break;
            }

            }
    }
}
