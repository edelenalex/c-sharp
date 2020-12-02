using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class BookSelectionForm : Form
    {
        private List<LibraryItem> _items;    // List of library items
        private List<int> isBookIndicies; // List of index values of items that are books

        public BookSelectionForm(List<LibraryItem> itemList)
        {
            InitializeComponent();

            _items = itemList;
            isBookIndicies = new List<int>();

        }

        internal int ItemIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected item combo box has been returned
            get
            {
                if (bookSelectCbo.SelectedIndex != -1)
                    return isBookIndicies[bookSelectCbo.SelectedIndex]; // Lookup correct index

                // Should never happen if validation works
                return -1;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Causes form to close and return OK result

        }

        private void BookSelectionForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _items.Count; ++i)
            {
                if (_items[i] is LibraryBook)
                {
                    bookSelectCbo.Items.Add($"{_items[i].Title}, {_items[i].CallNumber}");
                    isBookIndicies.Add(i); // Keep track of location

                }
            }
        }
    }
}
