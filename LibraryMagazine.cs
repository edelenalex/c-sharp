// Program 1a
// CIS 200-01
// Grading ID: T1233
// Due: 2/12/2020

//This is a concrete class Magazine derived from the Periodical class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1a
{
    public class LibraryMagazine : LibraryPeriodical
    {
        // Precondition:  theVolume > 0, theNumber > 0 and theCopyrightYear >= 0,
        //                theTitle, theCallNumber, thePublisher may not be null or empty
        // Postcondition: The library item has been initialized with the specified
        //                values for title, publisher, copyright year, volume, number, and
        //                call number. The item is not checked out.
        public LibraryMagazine(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, int theVolume, int theNumber) : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theVolume, theNumber)
        {
            ReturnToShelf(); // Make sure book is not checked out
        }

        public override decimal CalcFee(int daysLate)
        {
            const decimal feeLimit = 20.00M; //$20 fee limit
            const decimal dailyFee = 0.25M; // $0.25 daily fee
            decimal totalFee;               //days late * daily fee

            totalFee = dailyFee * daysLate;

            if (totalFee <= feeLimit)
            {
                return totalFee;
            }
            else
                return feeLimit;
        }

    }
}
