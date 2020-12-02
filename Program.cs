// Program 0
//Grading ID: T1233
//Due: January 27, 2020
//CIS 200-01
// Starting Point

// File: Program.cs
// This file creates a simple test application class that creates
// an array of LibraryBook objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2011, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2001, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1986, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            2019, "ZZ24 4F");  // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2004, "AE842 7A"); // 5th test book
        LibraryPatron user1 = new LibraryPatron("John Doe", "12345");
        LibraryPatron user2 = new LibraryPatron("Jane Smith", "23456");
        LibraryPatron user3 = new LibraryPatron("Tom Foolery", "78945");

        List<LibraryBook> theBooks = new List<LibraryBook>(); // Test list of books

        //Add books to the list
        theBooks.Add(book1);
        theBooks.Add(book2);
        theBooks.Add(book3);
        theBooks.Add(book4);
        theBooks.Add(book5);

        WriteLine("Original list of books");
        WriteLine("----------------------");
        PrintBooks(theBooks);
        Pause();

        // Make changes
        book1.CheckOut(user1);
        book2.Publisher = "Borrowed Books";
        book3.CheckOut(user2);
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(user3);
        book5.CopyrightYear = 1234; // Attempt invalid year

        WriteLine("After changes");
        WriteLine("-------------");
        PrintBooks(theBooks);
        Pause();

        // Return the books
        book1.ReturnToShelf();
        book3.ReturnToShelf();
        book5.ReturnToShelf();

        WriteLine("After returning the books");
        WriteLine("-------------------------");
        PrintBooks(theBooks);
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(List<LibraryBook> theBooks)
    {
        foreach (LibraryBook b in theBooks)
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
