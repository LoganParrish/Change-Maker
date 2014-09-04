using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(0.99);
            ChangeMaker(3.18);
            ChangeMaker(12.93);
            ChangeMaker(50.0);
            ChangeMaker(9823.92);
            ChangeMaker(152.27);
            ChangeMaker(8675.09);
            ChangeMaker(164.32);
            Console.ReadKey();
        }
        static void ChangeMaker(double amount)
        {
            double hundreds = 100.0;
            double hundredAmount = 0;
            double fifties = 50.0;
            double fiftyAmount = 0;
            double twenties = 20.0;
            double twentyAmount = 0;
            double tens = 10.0;
            double tenAmount = 0;
            double fives = 5.0;
            double fiveAmount = 0;
            double dollars = 1.0;
            double dollarAmount = 0;
            double quarters = .25;
            double quarterAmount = 0;
            double dimes = .10;
            double dimeAmount = 0;
            double nickels = .05;
            double nickelAmount = 0;
            double pennies = .01;
            double penniesAmount = 0;
            double remainder = 0;

            //dividing the largest amount of bill we have by the amount, 
            //and again finding the remainder to pass on to the next bill amount
            hundredAmount = amount / hundreds;
            remainder = amount % hundreds;

            //repeating the process until the system can no longer fit in values
            fiftyAmount = remainder / fifties;
            remainder = remainder % fifties;

            //We're still going
            twentyAmount = remainder / twenties;
            remainder = remainder % twenties;

            //the looooooong and winding roooad
            tenAmount = remainder / tens;
            remainder = remainder % tens;

            //DUN DUN, DUN DUN
            fiveAmount = remainder / fives;
            remainder = remainder % fives;

            //THAT LEADS YOU TO YOUR DOOR
            dollarAmount = remainder / dollars;
            remainder = remainder % dollars;

            //WILL NEVER DISAPPEAR
            quarterAmount = remainder / quarters;
            remainder = remainder % quarters;

            //we're almost there
            dimeAmount = remainder / dimes;
            remainder = remainder % dimes;

            //almost
            nickelAmount = remainder / nickels;
            remainder = remainder % nickels;

            //Hey look, Pennies!
            penniesAmount = remainder / pennies;
            remainder = remainder % pennies;

            //PRINT IT ALL!
            Console.WriteLine("\n\n\n\n======================RUNNING CHANGEMAKER======================");
            Console.WriteLine("Your change is: " + Math.Floor(hundredAmount) + " hundreds, ");
            Console.WriteLine(Math.Floor(fiftyAmount) + " fifties,");
            Console.WriteLine(Math.Floor(twentyAmount) + " twenties, ");
            Console.WriteLine(Math.Floor(tenAmount) + " tens, ");
            Console.WriteLine(Math.Floor(fiveAmount) + " fives, ");
            Console.WriteLine(Math.Floor(dollarAmount) + " dolla bills, y'all, ");
            Console.WriteLine(Math.Floor(quarterAmount) + " quarters,");
            Console.WriteLine(Math.Floor(dimeAmount)+ " dimes,");
            Console.WriteLine(Math.Floor(nickelAmount) + " nickels,");
            Console.WriteLine( "and " + (Math.Round(penniesAmount)) + " pennies.");
                
        }
    }
}
