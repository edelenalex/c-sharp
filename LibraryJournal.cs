// Program 1a
// CIS 200-01
// Grading ID: T1233
// Due: 2/12/2020

//This is a concrete class derived from the Periodical parent class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1a
{
    public class LibraryJournal : LibraryPeriodical
    {
        private string _discipline; //the item's disicpline
        private string _editor;  //the item's editor

        // Precondition:  theVolume > 0, theNumber > 0 and theCopyrightYear >= 0,
        //                theTitle, theCallNumber, thePublisher may not be null or empty
        // Postcondition: The library item has been initialized with the specified
        //                values for title, publisher, copyright year, volume, number, and
        //                call number. The item is not checked out.
        public LibraryJournal(string theTitle, string thePublisher, int theCopyright, int theLoanPeriod, string theCallNumber, int theVolume, int theNumber, string theDiscipline, string theEditor) : base(theTitle, thePublisher, theCopyright, theLoanPeriod, theCallNumber, theVolume, theNumber)
        {
            Discipline = theDiscipline;
            Editor = theEditor;

            ReturnToShelf(); // Make sure book is not checked out
        }

        public string Editor
        {
            // Precondition:  None
            // Postcondition: The Editor has been returned
            get
            {
                return _editor;
            }
            // Precondition:  value must not be null or empty
            // Postcondition: The editor has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Editor)}", value,
                        $"{nameof(Editor)} must not be null or empty");
                else
                    _editor = value.Trim();
            }
        }

        public string Discipline
        {
            // Precondition:  None
            // Postcondition: The Discipline has been returned
            get
            {
                return _discipline;
            }
            // Precondition:  value must not be null or empty
            // Postcondition: The Discipline has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Discipline)}", value,
                        $"{nameof(Discipline)} must not be null or empty");
                else
                    _discipline = value.Trim();
            }
        }

        //Precondition: non-negative int
        //Postcondition: total fee value returned
        public override decimal CalcFee(int daysLate)
        {
            decimal totalFee;
            const decimal fee = 0.75M;

            totalFee = daysLate * fee;
            return totalFee;
        }

        // Precondition:  None
        // Postcondition: A string is returned representing the libary item's
        //                data on separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return base.ToString() + $"{NL}Discipline: {Discipline}{NL}Editor: {Editor}";
        }
    }
}
