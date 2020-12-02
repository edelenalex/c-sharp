// Program 3
// CIS 200-01
// Due: 4/3/2020
// By: T1233

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, and a
// Report menu with Patron List, Item List, and Checked Out Items items.

// Extra Credit - Check Out and Return only show relevant items

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace LibraryItems
{
    public partial class Prog2Form : Form
    {
        private Library _lib; // The library
        private BinaryFormatter formatter = new BinaryFormatter();  //object for serializing in binary format
        private FileStream output;  //stream for writing to a file
        private BinaryFormatter reader = new BinaryFormatter(); //object for desrializing in binary format
        private FileStream input; //Stream for reading from a file


        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library
        public Prog2Form()
        {
            InitializeComponent();

            _lib = new Library(); // Create the library

            // Insert test data - Magic numbers allowed here
            _lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14, "ZZ25 3G", "Andrew Wright");
            _lib.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21, "AB73 ZF", "IP Thief");
            _lib.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG);
            _lib.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            _lib.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            _lib.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            _lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2017, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            _lib.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2019, 14, "MA53 9A", 16, 7);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2019, 14, "MA53 9B", 16, 8);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2019, 14, "MA53 9C", 16, 9);
            _lib.AddLibraryMagazine("     VB Magazine    ", "    UofL Mags   ", 2018, 14, "MA21 5V", 1, 1);

            // Add 5 Patrons
            _lib.AddPatron("Ima Reader", "12345");
            _lib.AddPatron("Jane Doe", "11223");
            _lib.AddPatron("   John Smith   ", "   654321   ");
            _lib.AddPatron("James T. Kirk", "98765");
            _lib.AddPatron("Jean-Luc Picard", "33456");
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Program 3{NL}By: T1233{NL}CIS 200-01{NL}Spring 2020",
                "About Program 3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons;     // List of patrons
            string NL = Environment.NewLine; // NewLine shortcut

            patrons = _lib.GetPatronsList();

            reportTxt.Text = $"Patron List - {patrons.Count} patrons{NL}{NL}";

            foreach (LibraryPatron p in patrons)
                reportTxt.AppendText($"{p}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;         // List of library items
            string NL = Environment.NewLine; // NewLine shortcut

            items = _lib.GetItemsList();

            reportTxt.Text = $"Item List - {items.Count} items{NL}{NL}";

            foreach (LibraryItem item in items)
                reportTxt.AppendText($"{item}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;         // List of library items
            string NL = Environment.NewLine; // NewLine shortcut

            items = _lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            reportTxt.Text = $"Checked Out Items - {checkedOutItems.Count()} items{NL}{NL}";

            foreach (LibraryItem item in checkedOutItems)
                reportTxt.AppendText($"{item}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                _lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    _lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items
            List<LibraryPatron> patrons; // List of patrons

            items = _lib.GetItemsList();
            patrons = _lib.GetPatronsList();

            if (((items.Count - _lib.GetCheckedOutCount()) == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(items, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.CheckOut(checkoutForm.ItemIndex, checkoutForm.PatronIndex);
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items

            items = _lib.GetItemsList();

            if ((_lib.GetCheckedOutCount() == 0)) // Must have items to return
                MessageBox.Show("Must have items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(items); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.ReturnToShelf(returnForm.ItemIndex);
                }

                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        private void PatronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons; // List of patrons

            patrons = _lib.GetPatronsList();

            if ((patrons.Count() == 0))
                MessageBox.Show("Must have a patron to edit!");
            else
            {
                PatronSelectionForm patronSelectionForm = new PatronSelectionForm(patrons);
                DialogResult result = patronSelectionForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK)
                {
                   LibraryPatron p =  _lib._patrons[patronSelectionForm.PatronIndex];
                    PatronForm pf = new PatronForm();
                    pf.PatronName = p.PatronName;
                    pf.PatronID = p.PatronID;

                    DialogResult result1 =  pf.ShowDialog();

                    if (result1 == DialogResult.OK)
                    {
                        p.PatronName = pf.PatronName;
                        p.PatronID = pf.PatronID;
                    }

                }
                patronSelectionForm.Dispose();
            }



        }

        private void SaveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creating a dialgo box enabling users to save file
            DialogResult resultSave;  
            string fileNameSave; //name of file to save data

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;  //let user create file

                //retrieve the results of the dialog box
                resultSave = fileChooser.ShowDialog();
                fileNameSave = fileChooser.FileName;  //get specific file name
            }

            if (resultSave == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileNameSave))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //save file via FileStream if user specified valid type
                    try
                    {
                        //open file with write access
                        output = new FileStream(fileNameSave, FileMode.OpenOrCreate, FileAccess.Write);
                        //write record to FileStream (serialize _lib object)
                        formatter.Serialize(output, _lib);  
                    }
                    finally
                    {
                        output?.Close();  //close FileStream
                    }
               }
            }
        }

        private void OpenLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create and show dialog box enabling user to open file
            DialogResult resultOpen; //result of the openFileDialog
            string fileNameOpen;  //name of the file containing data

            using(OpenFileDialog fileChooserOpen = new OpenFileDialog())
            {
                resultOpen = fileChooserOpen.ShowDialog();
                fileNameOpen = fileChooserOpen.FileName;  //get specified name
            }
            if (resultOpen == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileNameOpen))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        input = new FileStream(fileNameOpen, FileMode.Open, FileAccess.Read);  //create Filestream to obtain read access
                        _lib = (Library) reader.Deserialize(input);
                    }
                    finally
                    {
                        input?.Close();  //close FileStream
                    }
                }
            }
        }

        private void BookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items
            items = _lib.GetItemsList();

            if ((items.Count() == 0))
                MessageBox.Show("Must have a book to edit!");
            else
            {
                BookSelectionForm bookSelectForm = new BookSelectionForm(items); // The return dialog box form
                DialogResult result = bookSelectForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK)
                {
                    LibraryBook b = (LibraryBook) _lib._items[bookSelectForm.ItemIndex];
                    BookForm bf = new BookForm();
                    bf.ItemTitle = b.Title;
                    bf.ItemPublisher = b.Publisher;
                    bf.ItemCopyrightYear = b.CopyrightYear.ToString();
                    bf.ItemLoanPeriod = b.LoanPeriod.ToString();
                    bf.ItemCallNumber = b.CallNumber;
                    bf.BookAuthor = b.Author;

                    DialogResult result1 = bf.ShowDialog();

                    if (result1 == DialogResult.OK)
                    {
                        b.Title = bf.ItemTitle;
                        b.Publisher = bf.ItemPublisher;
                        b.CopyrightYear = int.Parse(bf.ItemCopyrightYear);
                        b.LoanPeriod = int.Parse(bf.ItemLoanPeriod);
                        b.CallNumber = bf.ItemCallNumber;
                        b.Author = bf.BookAuthor;
                    }


                }
                bookSelectForm.Dispose();

            }


        }
    }
}
