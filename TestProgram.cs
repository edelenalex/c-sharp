// Program 1a
// CIS 200-01
// Grading ID: T1233
// Due: 2/12/2020

//This is a modification of the test program from Program 0 solutions with additions specific to Program 1a, it will list the library inventory, 
//  make some changes, and check some items out
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_1a
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            LibraryItem book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
    2010, 0, "ZZ25 3G");  // 1st test book
            LibraryItem movie1 = new LibraryMovie("Harriet Pooter", "Stealer Books",
                2000, 0, "AG773 ZF", 189.00, "Michael Bay", LibraryMovie.MediaType.BLURAY, LibraryMovie.MPAARatings.R); // 1st movie test 
            LibraryItem cd1 = new LibraryMusic("The Color Mauve", "Beautiful Books Ltd.",
                1985, 0, "JJ438 4T", 79, "Adele", LibraryMediaItem.MediaType.CD, 17); // CD test 
            LibraryItem magazine1 = new LibraryMagazine("The Guan Guide to SQL", "UofL Press",
                2016, 0, "ZZ24 4F", 1, 4);    // Magazine test 
            LibraryItem book5 = new LibraryBook("    The Big Book of Doughnuts   ", "   Homer Simpson   ", "   Doh Books   ",
                2001, 0, "   AE842 7A   "); // 5th test book - Trims?
            LibraryItem cSharpQterly = new LibraryJournal("C# Quarterly", "C Sharp Press", 2014, 0, "QRT2014", 4, 20, "Computer Science", "Dr. Wright"); //Journal Test
            LibraryItem book2 = new LibraryBook("Extreme Ownership", "Jocko Willink and LiefBabin", "St. Matrin's Press", 2015, 0, "978-1-250"); //Test Book 2
            LibraryItem movie2 = new LibraryMovie("The Usual Suspects", "Mirmax", 1995, 0, "555897989", 106.00, "Bryan Singer", LibraryMovie.MediaType.VHS, LibraryMovie.MPAARatings.R);  //Test Movie #2
            LibraryItem cd2 = new LibraryMusic("2001", "Interscope", 2001, 0, "8988787984", 86, "Dr. Dre", LibraryMusic.MediaType.CD, 15); //Test CD 2
            LibraryItem magazine2 = new LibraryMagazine("Time", "Andy Rooney", 1978, 0, "254547", 42, 23); //test magazine 2
            LibraryItem jounral2 = new LibraryJournal("Planet Earth", "The Discrovery Channel", 2009, 0, "5654123557", 8, 24, "Nature", "Second"); //Test Journal #2
            LibraryMagazine magazine3 = new LibraryMagazine("Time", "Andy Rooney", 1978, 0, "7897845", 2, 32); //Same magazine different edition and volume

            LibraryPatron patron1 = new LibraryPatron("Ima Reader", "123456"); // 1st test patron
            LibraryPatron patron2 = new LibraryPatron("Jane Doe", "112233");  // 2nd test patron
            LibraryPatron patron3 = new LibraryPatron("   John Smith   ", "   654321   "); // 3rd test patron - Trims?
            LibraryPatron patron4 = new LibraryPatron("Tiger Woods", "6922251"); //4th test patron
            LibraryPatron patron5 = new LibraryPatron("John Daly", "251448"); //5th test patron

            List<LibraryItem> theItems = new List<LibraryItem> { book1, movie1, cd1, magazine1, book5 , cSharpQterly, book2, movie2, cd2, magazine2, jounral2, magazine3}; // Test list of items

            WriteLine("Original list of books");
            WriteLine("----------------------");
            PrintBooks(theItems);
            Pause();

            // Check out books
            book1.CheckOut(patron1);
            cSharpQterly.CheckOut(patron3);
            book2.CheckOut(patron4);
            cd2.CheckOut(patron4);
            cd1.CheckOut(patron5);
            book5.CheckOut(patron2);
            movie1.CheckOut(patron5);

            var checkedOut =
                from i in theItems
                where i.Patron != null
                select i;

            foreach (var i in checkedOut)
            {
                WriteLine($"Currenlty Checked out books: \n");
                WriteLine($"{i} \n");
                WriteLine($"Total Checked out: {checkedOut.Count()}");
            }

            var media =
                from thing in checkedOut
                where thing.Medium
                select thing;

            foreach(var thing in media)
            {
                WriteLine($"")
            }

            var oneAndOnly = 
                from one in theItems
                where one 

           // try
            //{
           //     movie1.CheckOut(null); // Attempt invalid patron
           // }
            //catch (ArgumentNullException ex)
            //{
              //  WriteLine("Caught invalid patron sent to CheckOut");
                //WriteLine(ex.Message);
            //}

            //WriteLine("Recent Check outs: ");
            //WriteLine("-------------");
            //PrintBooks(theBooks);
            //Pause();

            // Return the books
            //book1.ReturnToShelf();
            //cd1.ReturnToShelf();
            //book5.ReturnToShelf();
            //cSharpQterly.ReturnToShelf();

           // WriteLine("After returning the books");
           // WriteLine("-------------------------");
           // PrintBooks(theBooks);
        }

        // Precondition:  None
        // Postcondition: The books have been printed to the console
        public static void PrintBooks(List<LibraryItem> books)
        {
            foreach (LibraryItem b in books)
            {
                WriteLine(b);
                WriteLine();
            }
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Clear(); // Clear screen
        }

    }
}

