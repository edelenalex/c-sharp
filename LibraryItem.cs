// Program 1a
// CIS 200-01
// Grading ID: T1233
// Due: 2/12/2020

//This is an abstract class library item that many other classe inside the library will be derived from
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_1a
{
    public abstract class LibraryItem
    {
        private string _title;  //The item's title
        private string _publisher;  //The item's author
        private int _copyrightYear; //The item's Copyright Year
        private int _loanPeriod;  //The item's Loan Period
        private string _callNumber;  //The item's call number

        // Precondition:  theCopyrightYear >= 0
        //                theTitle, thePublisher, theCallNumber may not be null or empty
        // Postcondition: The library item has been initialized with the specified
        //                values for title, loan period, publisher, copyright year, and
        //                call number. The item is not checked out.
        public LibraryItem(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber)
        {
            Title = theTitle;
            Publisher = thePublisher;
            CopyrightYear = theCopyrightYear;
            CallNumber = theCallNumber;
            LoanPeriod = theLoanPeriod;

            ReturnToShelf(); // Make sure book is not checked out
        }

        public string Title
        {
            // Precondition:  None
            // Postcondition: The title has been returned
            get
            {
                return _title;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The title has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Title)}", value,
                        $"{nameof(Title)} must not be null or empty");
                else
                    _title = value.Trim();
            }
        }

        public string Publisher
        {
            // Precondition:  None
            // Postcondition: The publisher has been returned
            get
            {
                return _publisher;
            }

            // Precondition:  None
            // Postcondition: The publisher has been set to the specified value
            set
            {
                // Since empty publisher is OK, just change null to empty string
                _publisher = (value == null ? string.Empty : value.Trim());
            }
        }

        public int CopyrightYear
        {
            // Precondition:  None
            // Postcondition: The copyright year has been returned
            get
            {
                return _copyrightYear;
            }

            // Precondition:  value >= 0
            // Postcondition: The copyright year has been set to the specified value
            set
            {
                if (value >= 0)
                    _copyrightYear = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                        $"{nameof(CopyrightYear)} must be >= 0");
            }
        }

        public string CallNumber
        {
            // Precondition:  None
            // Postcondition: The call number has been returned
            get
            {
                return _callNumber;
            }

            // Precondition:  None
            // Postcondition: The call number has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(CallNumber)}", value,
                        $"{nameof(CallNumber)} must not be null or empty");
                else
                    _callNumber = value.Trim();
            }
        }

        public int LoanPeriod
        {

            //Precondition:  None
            //Postcondition: The loan period has been returned
            get
            {
                return _loanPeriod;
            }

            //Precondition: None
            //Postcondition: The loan period has been set to the specified value
            set
            {
                if (value >= 0)
                    _loanPeriod = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(LoanPeriod)}", value,
                        $"{nameof(LoanPeriod)} must be >= 0");
            }
        }

        // Create HAS-A
        public LibraryPatron Patron
        {
            // Precondition:  None
            // Postcondition: The book's patron has been returned
            get;

            // Precondition:  None
            // Postcondition: The book's patron has been set to the specified value
            private set;
        }

        // Precondition:  thePatron != null
        // Postcondition: The book is checked out by the specified patron
        public void CheckOut(LibraryPatron thePatron)
        {
            if (thePatron != null)
                Patron = thePatron;
            else
                throw new ArgumentNullException($"{nameof(thePatron)}", $"{nameof(thePatron)} must not be null");
        }

        // Precondition:  None
        // Postcondition: The book is not checked out

        public void ReturnToShelf()
        {
            Patron = null; // Remove previously stored reference to patron
        }

        // Precondition:  None
        // Postcondition: true is returned if the book is checked out,
        //                otherwise false is returned
        public bool IsCheckedOut()
        {
            return Patron != null; // The item is checked out if there is a Patron
        }

        //Precondition: None negative int
        //Postcondition: To be determined by inherited classes
        public abstract decimal CalcFee(int daysLate);


        // Precondition:  None
        // Postcondition: A string is returned representing the libary item's
        //                data on separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            string checkedOutBy; // Holds checked out message

            if (IsCheckedOut())
                checkedOutBy = $"Checked Out By: {NL}{Patron}";
            else
                checkedOutBy = "Not Checked Out";

            return $"Title: {Title}{NL}Publisher: {Publisher}{NL}" +
                $"Copyright: {CopyrightYear}{NL}Call Number: {CallNumber}{NL}Status: {checkedOutBy}";
        }
    }
}
