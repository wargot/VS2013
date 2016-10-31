/* Aleksandr Vargot
 * 24 Oct 2016
 * LabAssignment3.cs
 */

using System;

namespace LabAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("\n\n---------------------- LAB ASSIGNMENT #3 ----------------------\n\n");
            Console.WriteLine("Please select the lab part you wish to run:");
            Console.WriteLine("   1 - Run the lab program part 1");
            Console.WriteLine("   2 - Run the lab program part 2");
            Console.WriteLine("   3 - Exit the lab program!\n");
            Console.Write("Choice:  ");
            int choice = int.Parse(Console.ReadLine());

            //switch - to choose which sub-program to run
            switch (choice)
            {
                case 1:
                    Lab3Part1();
                    goto start;
                case 2:
                    Lab3Part2();
                    goto start;
                case 3:
                    Console.WriteLine("Good Bye!");
                    break;
                default:
                    Console.WriteLine("Error: Program stopped working...");
                    break;
            } // end of switch
        }

        public static void Lab3Part1()
        {
            Console.WriteLine("\n\n---------------------- PROGRAM PART 1 ----------------------\n\n");
            
            // Prompt for the Account Number
            Console.Write("Enter the account number: ");
            string inputText = Console.ReadLine();
            int acctNumber = int.Parse(inputText);

            // Prompt for the Account Type
            Console.Write("Enter the account type (C for checking and S for Savings:) ");
            inputText = Console.ReadLine();
            char acctType = char.Parse(inputText);

            //Prompt user for minimum balance
            Console.Write("Enter the minumum balance: ");
            inputText = Console.ReadLine();
            decimal minBalance = decimal.Parse(inputText);

            //Prompt user for current balance
            Console.Write("Enter the current balance: ");
            inputText = Console.ReadLine();
            decimal currBalance = decimal.Parse(inputText);

            //Final money amount after all bank's monthly fees\interest bonuses
            decimal monthStatement = 0;

            //switch - to process one of two types of accounts, and calculate final account amount of money
            switch (acctType)
             {
                 case 'C': //here we process calculations for checking account
                    if (currBalance < minBalance)
                    {
                        monthStatement = currBalance - 25;
                    }
                    else if (currBalance <= minBalance + 5000)
                    {
                        monthStatement = currBalance / 100 * 3 + currBalance;
                    }
                    else monthStatement = currBalance / 100 * 5 + currBalance;
                     break;
                 case 'S': //here we process calculations for savings account
                     if (currBalance < minBalance)
                         monthStatement = currBalance - 10;
                     else 
                         monthStatement = currBalance / 100 * 4 + currBalance;
                     break;
                 default:
                     break;
             } // end of switch
            Console.WriteLine("Your Current Monthly Statement Balance is : {0:C}", monthStatement);
        } // end of Lab3Part1


        public static void Lab3Part2()
        {
            Console.WriteLine("\n\n---------------------- PROGRAM PART 2 ----------------------\n\n");

            // Prompt the user for a number
            Console.Write("Enter a number in the 0-999 range: ");
            string inputText = Console.ReadLine();
            int number = int.Parse(inputText);

            //d2 for hundreds, d1 for tens, d0 for the rest amount
            int d0 = number % 10;
            int d1 = number / 10 % 10;
            int d2 = number / 100 % 10;

            string output = String.Empty; // same as ""

            switch (d2) //switch - to choose the hundred amount we have
            {
                case 0:
                    break;
                case 1:
                    output += "One hundred";
                    break;
                case 2:
                    output += "Two hundred";
                    break;
                case 3:
                    output += "Three hundred";
                    break;
                case 4:
                    output += "Four hundred";
                    break;
                case 5:
                    output += "Five hundred";
                    break;
                case 6:
                    output += "Six hundred";
                    break;
                case 7:
                    output += "Seven hundred";
                    break;
                case 8:
                    output += "Eight hundred";
                    break;
                case 9:
                    output += "Nine hundred";
                    break;
            } // end of switch 1

            switch (d1) //switch - to choose the tens amount we have
            {
                case 0:
                    break;
                case 1:
                    output += "Ten";
                    break;
                case 2:
                    output += " Twenty";
                    break;
                case 3:
                    output += " Thirty";
                    break;
                case 4:
                    output += " Forty";
                    break;
                case 5:
                    output += " Fifty";
                    break;
                case 6:
                    output += " Sixty";
                    break;
                case 7:
                    output += " Seventy";
                    break;
                case 8:
                    output += " Eighty";
                    break;
                case 9:
                    output += " Ninety";
                    break;
            } // end of switch 2

            switch (d0) //switch - to choose the last number we have to write
            {
                case 0:
                    break;
                case 1:
                    output += " One";
                    break;
                case 2:
                    output += " Two";
                    break;
                case 3:
                    output += " Three";
                    break;
                case 4:
                    output += " Four";
                    break;
                case 5:
                    output += " Five";
                    break;
                case 6:
                    output += " Six";
                    break;
                case 7:
                    output += " Seven";
                    break;
                case 8:
                    output += " Eight";
                    break;
                case 9:
                    output += " Nine";
                    break;
            } // end of switch 3
            Console.WriteLine(output); //result line printing to user screen
        } // end of Lab3Part2
    } //end of Program
} //THE END!
