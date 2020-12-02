// Program 1a
// CIS 200-01
// Grading ID: T1233
// Due: 2/12/2020

//This is a abstract derived class from the abstract class LibraryItem
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1a
{
    public abstract class LibraryMediaItem : LibraryItem
    {
        public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL }; //MultiMedia types
        private double _duration; //Media items duration

        // Precondition:  theCopyrightYear >= 0, theDuration > 0,
        //                theTitle, the publisher, theCallNumber, loan period may not be null or empty
        // Postcondition: The library item has been initialized with the specified
        //                values for title, loan period, publisher, copyright year, and
        //                call number. The item is not checked out.
        public LibraryMediaItem(string theTitle, string thePublisher, int theLoanPeriod, int theCopyrightYear, string theCallNumber, double theDuration) : base(theTitle, thePublisher, theLoanPeriod, theCopyrightYear, theCallNumber)
        {
            Duration = theDuration;

            ReturnToShelf(); // Make sure item is not checked out
        }



        public double Duration
        {
            // Precondition:  None
            // Postcondition: The duration has been returned
            get
            {
                return _duration;
            }
            // Precondition:  value >= 0
            // Postcondition: The duration year has been set to the specified value
            set
            {
                if (value >= 0)
                    _duration = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Duration)}", value,
                        $"{nameof(Duration)} must be >= 0");
            }
        }

        public abstract MediaType Medium { get; set; } //Auto-implentaion of MediaType Medium 

        // Precondition:  None
        // Postcondition: A string is returned representing the libary item's
        //                data on separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return base.ToString() + $"{NL}Duration: {Duration}";
        }


    }
}
