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
    public partial class PatronSelectionForm : Form
    {
        private List<LibraryPatron> _patrons;   // List of patrons

        public PatronSelectionForm(List<LibraryPatron> patronList)
        {
            InitializeComponent();

            _patrons = patronList;

        }
        private void PatronSelectionForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryPatron patron in _patrons)
                patronSelectCbo.Items.Add($"{patron.PatronName}, {patron.PatronID}");

        }

        internal int PatronIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected patron combo box has been returned
            get
            {
                return patronSelectCbo.SelectedIndex;
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK; // Causes form to close and return OK result



        }
    }
}
