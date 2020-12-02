// Program 1a
// CIS 200-01
// Grading ID: T1233
// Due: 2/12/2020

//This is a concrete Music class derived from the MediaItems parent class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1a
{
    public class LibraryMusic : LibraryMediaItem
    {
        private string _artist;  //The item's artist
        private int _tracks;  //The item's track
        private MediaType _medium;  //The item's medium

        // Precondition:  theDuration and theCopyrightYear >= 0, theNumTracks >=1,
        //                theTitle, theCallNumber, theArtist may not be null or empty
        // Postcondition: The library music item has been initialized with the specified
        //                values for title, author, publisher, copyright year, artist, medium, number of tracks, and
        //                call number. The item is not checked out.
        public LibraryMusic(string theTitle, string thePublisher, int theCopyrightYear, int theLoanPeriod, string theCallNumber, double theDuration, string theArtist, MediaType theMedium, int theNumberOfTracks) : base( theTitle, thePublisher, theLoanPeriod, theCopyrightYear, theCallNumber, theDuration)
        {
            Artist = theArtist;
            Medium = theMedium;
            NumTracks = theNumberOfTracks;

            ReturnToShelf(); // Make sure book is not checked out
        }

        public string Artist
        {
            // Precondition:  None
            // Postcondition: The artist has been returned
            get
            {
                return _artist;
            }
            // Precondition:  value must not be null or empty
            // Postcondition: The arist has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    throw new ArgumentOutOfRangeException($"{nameof(Artist)}", value,
                        $"{nameof(Artist)} must not be null or empty");
                else
                    _artist = value.Trim();
            }
        }

        public int NumTracks
        {
            // Precondition:  None
            // Postcondition: The number of tracks has been returned
            get
            {
                return _tracks;
            }
            // Precondition:  value > 0
            // Postcondition: The number of tracks has been set to the specified value
            set
            {
                if (value > 0)
                    _tracks = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(NumTracks)}", value,
                        $"{nameof(NumTracks)} must be > 0");
            }
        }

        public override MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The copyright year has been returned
            get
            {
                return _medium;
            }
            // Precondition:  MediaType must match the listed enums
            // Postcondition: The medium has been set to the specified value
            set
            {
                if (Enum.IsDefined(typeof(MediaType), value))
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Medium)}", value,
                                            $"{nameof(Medium)} invalid media type");
            }
        }

        //Precondition: non-negative int
        //Postcondition: total fee value returned
        public override decimal CalcFee(int daysLate)
        {
            const decimal dailyFee = 0.50M; //Daily fee of $0.50
            const decimal feeLimit = 20.0M; //Max fee limit of $20
            decimal totalFee;               //Daily fee * days late

            totalFee = dailyFee * daysLate;

            if (totalFee <= feeLimit)
            {
                return totalFee;
            }
            else
                return feeLimit;
        }

        // Precondition:  None
        // Postcondition: A string is returned representing the libary item's
        //                data on separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return base.ToString() + $"{NL}Artist: {Artist}{NL}# of Tracks: {NumTracks}{NL}Medium: {Medium}";
        }
    }
}
