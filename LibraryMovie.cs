// Program 1a
// CIS 200-01
// Grading ID: T1233
// Due: 2/12/2020

//This is a derived concrete class from the Library Media Items parent class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1a
{
    class LibraryMovie : LibraryMediaItem
    {
        public enum MPAARatings { G, PG, PG13, R, NC17, U }; //MPAA rating types
        private MPAARatings _ratings; //MPAA ratings
        private MediaType _medium;  //Movie's Mediatype medium
        private string _director;  //Moive's director

        // Precondition:  theCopyrightYear >= 0, theDuration > 0,
        //                theTitle, the publisher, theCallNumber, theMedium, theDirector, the Rating, loan period may not be null or empty
        // Postcondition: The library item has been initialized with the specified
        //                values for title, loan period, publisher, copyright year, and
        //                call number, medium, director, rating. The item is not checked out.
        public LibraryMovie(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, double theDuration, string theDirector, MediaType theMedium, MPAARatings theRating) : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
        {
            Medium = theMedium;
            Director = theDirector;
            Rating = theRating;

            ReturnToShelf(); // Make sure item is not checked out
        }


        public string Director
        {
            //Precondition:  None
            //Postcondition: The Director has been returned
            get
            {
                return _director;
            }
            // Precondition:  None
            // Postcondition: The Director has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Director)}", value,
                        $"{nameof(Director)} must not be null or empty");
                else
                    _director = value.Trim();
            }
        }

        public override MediaType Medium
        {
            //Precondition:  None
            //Postcondition: The Medium has been returned
            get
            {
                return _medium;
            }
            // Precondition:  medium must be BLURAY, DVD, or VHS
            // Postcondition: The Medium has been set to the specified value
            set
            {
                if (Medium == MediaType.BLURAY || Medium == MediaType.DVD || Medium == MediaType.VHS)
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Medium)}", value,
                                            $"{nameof(Medium)} invalid media type");
            }
        }

        public MPAARatings Rating
        {
            // Precondition:  None
            // Postcondition: The rating has been returned
            get
            {
                return _ratings;
            }

            // Precondition:  Rating must be defined in the ENUM
            // Postcondition: The Rating has been set to the specified value
            set
            {
                if (Enum.IsDefined(typeof(MPAARatings), value))
                    _ratings = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Rating)}", value,
                        $"{nameof(Rating)} invalid MPAA Rating");
            }
        }

        //Precondition: non-negative int
        //Postcondition: total fee value returned
        public override decimal CalcFee(int daysLate)
        {
            const decimal dailyLowFee = 1.00M;  //Daily fee for VHS and DVD
            const decimal dailyHiFee = 1.50M;  //Daily fee for BLURAY
            const decimal feeLimit = 25.00M;  //Maximum allowed fee
            decimal feeTotal;   //fee * days late

            if (Medium == MediaType.BLURAY)
            {
                feeTotal = dailyHiFee * daysLate;
            }
            else
            {
                feeTotal = daysLate * dailyLowFee;
            }

            if (feeTotal <= feeLimit)
            {
                return feeTotal;
            }
            else
            {
                return feeLimit;
            }
        }

        // Precondition:  None
        // Postcondition: A string is returned representing the libary item's
        //                data on separate lines

        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return base.ToString() + $"{NL}Director: {Director}{NL}Medium: {Medium}{NL}Rating: {Rating}";
        }

    }
}