//Descednig By CopyRight number class.  This class will reverse the natural ascedning order of the library items

// Program 4
// CIS 200-01
// Due: 4/15/2020
// By: Grading ID- T1233

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    public class DescendingByCopyRight : Comparer<LibraryItem>
    {

        // Precondition:  None
        // Postcondition: Reverses natural ascedning order but this time by copyright year, so descending with the most recent copyright year first
        public override int Compare(LibraryItem itemX, LibraryItem itemY)
        {

            if(itemX.CopyrightYear.CompareTo(itemY.CopyrightYear) !=0)
            {
                return (-1) * itemX.CopyrightYear.CompareTo(itemY.CopyrightYear); // Reverses natural order, so descending
            }
            else
                return 0;         
        }

    
    }
}
