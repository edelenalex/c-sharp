// Program 1a
// CIS 200-01
// Grading ID: T1233
// Due: 2/12/2020

//This is an abstract public class derived from Library item will be parent class for all periodicals
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1a
{
    public abstract class LibraryPeriodical : LibraryItem
    {
        private int _volume;  //the item's volume
        private int _number;  //the item's Number

        // Precondition:  theVolume > 0, theNumber > 0 and theCopyrightYear >= 0,
        //                theTitle, theCallNumber, thePublisher may not be null or empty
        // Postcondition: The library item has been initialized with the specified
        //                values for title, publisher, copyright year, volume, number, and
        //                call number. The item is not checked out.
        public LibraryPeriodical(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, int theVolume, int theNumber) : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
        {
            Volume = theVolume;
            Number = theNumber;

            ReturnToShelf(); // Make sure book is not checked out
        }

        public int Volume
        {
            // Precondition:  None
            // Postcondition: The volume has been returned
            get
            {
                return _volume;
            }
            // Precondition:  value > 0
            // Postcondition: The volume has been set to the specified value
            set
            {
                if (value >= 1)
                    _volume = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Volume)}", value,
                        $"{nameof(Volume)} must be >= 1");
            }
        }

        public int Number
        {
            // Precondition:  None
            // Postcondition: The Number has been returned
            get
            {
                return _number;
            }
            set
            // Precondition:  value > 0
            // Postcondition: The Number has been set to the specified value
            {
                if (value >= 1)
                    _number = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Number)}", value,
                        $"{nameof(Number)} must be >= 1");
            }
        }

        // Precondition:  None
        // Postcondition: A string is returned representing the libary item's
        //                data on separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return base.ToString() + $"{NL}Volume: {Volume}{NL}Number: {Number}";
        }
    }
}
