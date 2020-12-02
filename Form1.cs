using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            const double senior = 90;
            const double junior = 60;
            const double sophmore = 30;
            char lastNameLtr;
            double creditHrs;
            string date;
            string time;
            const string upperClassAD = "11:30 am";
            const string upperClassEI = "2:00 pm";
            const string upperClassJO = "4:00 pm";
            const string upperClassPS = "8:30 am";
            const string upperClassTZ = "10:00 am";
            const string seniorDay = "Monday, Nov. 4th";
            const string juniorDay = "Tuesday, Nov. 5th";
            const string firstSophDay = "Wednesday, Nov. 6th";
            const string secondSophDay = "Thursday, Nov. 7th";
            const string firstFreshDay = "Friday, Nov. 8th";
            const string secondFreshDay = "Monday, Nov. 11th";
            const string underClassAB = "4:00 pm";
            const string underClassCD = "8:30 am";
            const string underClassEF = "10:00 am";
            const string underClassGI = "11:30 am";
            const string underClassJL = "2:00 pm";
            const string underClassMO = "4:00 pm";
            const string underClassPQ = "8:30 am";
            const string underClassRS = "10:00 am";
            const string underClassTV = "11:30 am";
            const string underClassWZ = "2:00 pm";
            


            if (char.TryParse(lastNameLtrTxt.Text, out lastNameLtr) && lastNameLtr >= 'A' && lastNameLtr <= 'Z')
            {
                if (double.TryParse(creditHrsTxt.Text, out creditHrs) && creditHrs >= 0)
                {
                    if (creditHrs > senior)
                    {
                        date = seniorDay;
                        if (lastNameLtr <= 'D')
                        {
                            time = upperClassAD;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'I')
                        {
                            time = upperClassEI;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'O')
                        {
                            time = upperClassJO;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'S')
                        {
                            time = upperClassPS;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else
                        {
                            time = upperClassTZ;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                    }
                    else if (creditHrs > junior)
                    {
                        date = juniorDay;
                        if (lastNameLtr <= 'D')
                        {
                            time = upperClassAD;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'I')
                        {
                            time = upperClassEI;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'O')
                        {
                            time = upperClassJO;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'S')
                        {
                            time = upperClassPS;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else
                        {
                            time = upperClassTZ;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                    }
                    else if (creditHrs > sophmore && lastNameLtr <= 'B' || lastNameLtr > 'O')
                    {
                        date = firstSophDay;
                        if (lastNameLtr >= 'W')
                        {
                            time = underClassWZ;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr >= 'T')
                        {
                            time = underClassTV;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr >= 'R')
                        {
                            time = underClassRS;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr >= 'P')
                        {
                            time = underClassPQ;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else
                        {
                            time = underClassAB;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                    }
                    else if (creditHrs > sophmore && lastNameLtr >= 'C' && lastNameLtr <= 'O')
                    {
                        date = secondSophDay;
                        if (lastNameLtr <= 'D')
                        {
                            time = underClassCD;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'F')
                        {
                            time = underClassEF;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'I')
                        {
                            time = underClassGI;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'L')
                        {
                            time = underClassJL;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else
                        {
                            time = underClassMO;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                    }
                    else if (creditHrs < sophmore && lastNameLtr <= 'B' || lastNameLtr >= 'P')
                    {
                        date = firstFreshDay;
                        if (lastNameLtr >= 'W')
                        {
                            time = underClassWZ;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr >= 'T')
                        {
                            time = underClassTV;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr >= 'R')
                        {
                            time = underClassRS;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr >= 'P')
                        {
                            time = underClassPQ;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else
                        {
                            time = underClassAB;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                    }
                    else
                    {
                        date = secondFreshDay;
                        if (lastNameLtr <= 'D')
                        {
                            time = underClassCD;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'F')
                        {
                            time = underClassEF;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'I')
                        {
                            time = underClassGI;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else if (lastNameLtr <= 'L')
                        {
                            time = underClassJL;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                        else
                        {
                            time = underClassMO;
                            dateTimeOutputLbl.Text = $"{date} @ {time}";
                        }
                    }
                }
                else MessageBox.Show("Enter a valid number of credit hours");
            }
                else MessageBox.Show("Enter a valid last initial");
        }
    }
}
