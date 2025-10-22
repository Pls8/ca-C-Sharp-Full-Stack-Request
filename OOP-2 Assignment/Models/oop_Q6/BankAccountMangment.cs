using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//OOP Assignment 6: Bank Account Management System

namespace ConsoleApp12_10_2025.Models
{
    public class BankAccountMangment
    {

         private static int totalAccount = 0;
         //decimal balance;



        public string accountNum { get; }
       
        public string ownerAcc { get; }
        public decimal Balance { get; private set; } 



        //constructer with threw exception
        // been change to be just IF ELSE,
        // there is error BankAccountMangment > non-nullable propties
        public BankAccountMangment(string accountNumber, string owner, decimal initBalance = 0) {

            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                Console.WriteLine("Error: Account number cannot be empty");
            }
            else { accountNum = accountNumber; }
            //throw new ArgumentNullException("Account Number cannot be empty");


            if (string.IsNullOrWhiteSpace(owner))
            {
                Console.WriteLine("Owner name cannot be empty");
            }
            else { ownerAcc = owner; }
            //throw new ArgumentNullException("Owner name cannot be empty");

            if (initBalance < 0)
            {
                Console.WriteLine("Balance cannot be - ");
            }
            else { Balance = initBalance;  }
            //throw new ArgumentOutOfRangeException("Balance cannot be - ");


            //accountNum = AccountNumber;
            //ownerAcc = owner;
            //Balance = initBalance;
            totalAccount++;
        }


        public void Deposit(decimal amount) {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be + ");
            }
            else { 
                Balance += amount;
                Console.WriteLine($"Deposited {amount}, Balance {Balance}");
            }
                //throw new ArgumentException("Deposit amount must be + ");

                //Balance += amount;
                //Console.WriteLine($"Deposited {amount}, Balance {Balance}");  
        }


        public void withDraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be +");
            }
            //throw new ArgumentException("Deposit amount must be + ");

            else if (amount > Balance) {
                Console.WriteLine("Not enough cash, stranger!");
            }
            else {
                Balance -= amount;
                Console.WriteLine($"Withdrew OMR.{amount} | Balance {Balance}");
            }
                //throw new ArgumentException("Not enough cash, stranger!");

                
        }




        public static void showTotalAccount() {
            Console.WriteLine($"Total Acounts: {totalAccount}");
        }

        public void displayAccountInfo() {
            Console.WriteLine($"{ownerAcc} Account number: {accountNum} | OMR.{Balance}");
        }

    }
}
