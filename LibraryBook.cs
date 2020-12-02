// Program 1a
// CIS 200-01
// Grading ID: T1233
// Due: 2/12/2020

//This is a concrete derived class from library item
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1a
{
    class LibraryBook : LibraryItem
    {
       
        private string _author; //The book's author

        // Precondition:  theCopyrightYear >= 0
        //                theTitle, theAuthor, thePublisher, theCallNumber may not be null or empty
        // Postcondition: The library book has been initialized with the specified
        //                values for title, author, publisher, copyright year, and
        //                call number. The item is not checked out.
        public LibraryBook(string theTitle, string theAuthor, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber) : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
        {
            Author = theAuthor;

            ReturnToShelf(); // Make sure book is not checked out
        }

        public string Author
        {
            // Precondition:  None
            // Postcondition: The Author has been returned
            get
            {
                return _author;
            }
            // Precondition:  value must not be null or empty
            // Postcondition: The Author has been set to the specified value
            set
            {
                    if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                        throw new ArgumentOutOfRangeException($"{nameof(Author)}", value,
                            $"{nameof(Author)} must not be null or empty");
                    else
                        _author = value.Trim();
            }
        }

        //Precondition: non-negative int
        //Postcondition: total fee value returned
        public override decimal CalcFee(int daysLate)
        {
            const decimal dailyFee = 0.25M; //daily late fee
            decimal totalFee;   //days late * daily fee

            totalFee = dailyFee * daysLate;

            return totalFee;
        }

        // Precondition:  None
        // Postcondition: A string is returned representing the libary item's
        //                data on separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return base.ToString() + $"{NL}Author: {Author}";
        }


    }
}
