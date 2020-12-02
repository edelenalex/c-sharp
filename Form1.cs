//Grading ID: L5899
//Program 2
//Section: 75
//Due October 16, 2019
//This program will take a user's inputs of credit hours earned and last name initial and output the date they register for classes
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

        private void RegisterBtn_Click(object sender, EventArgs e)  //Click event button that starts the program
        {
            const double senior = 90; //Senior credit hourse designation
            const double junior = 60; //Junior credit hours designation
            const double sophmore = 30; //Sophmore credit hours designation
            char lastNameLtr; //User input variable for last name initial
            double creditHrs; //User input variable for credit hours
            string date; //Variable to store registration date for futre output
            string time; //variable to store registration time for future output 
            //Below Variables are upperclassmen registration time slots
            const string upperClassAD = "11:30 am";
            const string upperClassEI = "2:00 pm";
            const string upperClassJO = "4:00 pm";
            const string upperClassPS = "8:30 am";
            const string upperClassTZ = "10:00 am";
            //Below Variables are stored registration dates based on credit hourse for upperclassmen and credit hours and last name for underclassmen
            const string seniorDay = "Monday, Nov. 4th";
            const string juniorDay = "Tuesday, Nov. 5th";
            const string firstSophDay = "Wednesday, Nov. 6th";
            const string secondSophDay = "Thursday, Nov. 7th";
            const string firstFreshDay = "Friday, Nov. 8th";
            const string secondFreshDay = "Monday, Nov. 11th";
            //Below variables are times related to underclassmen registration based on last name initial
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
            


            if (char.TryParse(lastNameLtrTxt.Text, out lastNameLtr) && lastNameLtr >= 'A' && lastNameLtr <= 'Z') //Parsing and testing users initial input to make sure it is valid for further testing and decision making
            {
                if (double.TryParse(creditHrsTxt.Text, out creditHrs) && creditHrs >= 0) //Parsing and testing user credit hour input to make sure it is non-negative
                {
                    if (creditHrs >= senior) //Determining class based on credit hours
                    {
                        date = seniorDay;  //Setting registration date to Senior day
                       //Below if/else statements will determine the time to pair with the date based on the first initial of the users last name
                        if (lastNameLtr <= 'D')
                        {
                            time = upperClassAD;
                        }
                        else if (lastNameLtr <= 'I')
                        {
                            time = upperClassEI;
                        }
                        else if (lastNameLtr <= 'O')
                        {
                            time = upperClassJO;
                        }
                        else if (lastNameLtr <= 'S')
                        {
                            time = upperClassPS;
                        }
                        else
                        {
                            time = upperClassTZ;
                        }
                    }
                    else if (creditHrs >= junior) //Determining class based on credit hours
                    {
                        date = juniorDay; //Setting date for junior registeration
                        //Below if/else statements will determine the time to pair with the date based on the first initial of the users last name
                        if (lastNameLtr <= 'D')
                        {
                            time = upperClassAD;
                        }
                        else if (lastNameLtr <= 'I')
                        {
                            time = upperClassEI;
                        }
                        else if (lastNameLtr <= 'O')
                        {
                            time = upperClassJO;
                        }
                        else if (lastNameLtr <= 'S')
                        {
                            time = upperClassPS;
                        }
                        else
                        {
                            time = upperClassTZ;
                        }
                    }
                    else if (creditHrs >= sophmore && (lastNameLtr <= 'B' || lastNameLtr >= 'P')) //Determining which day underclassmen will register based on credit hours and name initial input
                    {
                        date = firstSophDay; //Setting date variable to sophmore day 1
                        //Below if/else statements will determine the time to pair with the date based on the first initial of the users last name
                        if (lastNameLtr >= 'W')
                        {
                            time = underClassWZ;
                        }
                        else if (lastNameLtr >= 'T')
                        {
                            time = underClassTV;
                        }
                        else if (lastNameLtr >= 'R')
                        {
                            time = underClassRS;
                        }
                        else if (lastNameLtr >= 'P')
                        {
                            time = underClassPQ;
                        }
                        else
                        {
                            time = underClassAB;
                        }
                    }
                    else if (creditHrs >= sophmore && lastNameLtr >= 'C' && lastNameLtr <= 'O') //Determining which day underclassmen will register based on credit hours and last name's first initial
                    {
                        date = secondSophDay; //Setting date to second sophmore day
                        //Below if/else statements will determine the time to pair with the date based on the first initial of the users last name
                        if (lastNameLtr <= 'D')
                        {
                            time = underClassCD;
                        }
                        else if (lastNameLtr <= 'F')
                        {
                            time = underClassEF;
                        }
                        else if (lastNameLtr <= 'I')
                        {
                            time = underClassGI;
                        }
                        else if (lastNameLtr <= 'L')
                        {
                            time = underClassJL;
                        }
                        else
                        {
                            time = underClassMO;
                        }
                    }
                    else if (lastNameLtr <= 'B' || lastNameLtr >= 'P')  //Will determine which of the two days freshmen will register
                    {
                        date = firstFreshDay;  //Date will be set based on credit hours and last name first initial for freshmen and sophmores
                        //Below if/else statements will determine the time to pair with the date based on the first initial of the users last name
                        if (lastNameLtr >= 'W')
                        {
                            time = underClassWZ;
                        }
                        else if (lastNameLtr >= 'T')
                        {
                            time = underClassTV;
                        }
                        else if (lastNameLtr >= 'R')
                        {
                            time = underClassRS;
                        }
                        else if (lastNameLtr >= 'P')
                        {
                            time = underClassPQ;
                        }
                        else
                        {
                            time = underClassAB;
                        }
                    }
                    else
                    {
                        date = secondFreshDay;  //setting date to the last day for freshmen to register
                        //Below if/else statements will determine the time to pair with the date based on the first initial of the users last name
                        if (lastNameLtr <= 'D')
                        {
                            time = underClassCD;
                        }
                        else if (lastNameLtr <= 'F')
                        {
                            time = underClassEF;
                        }
                        else if (lastNameLtr <= 'I')
                        {
                            time = underClassGI;
                        }
                        else if (lastNameLtr <= 'L')
                        {
                            time = underClassJL;
                        }
                        else
                        {
                            time = underClassMO;
                        }
                    }
                    dateTimeOutputLbl.Text = $"{date} @ {time}";  //Output to GUI text box showing the date and time for registration

                }
                else MessageBox.Show("Enter a valid number of credit hours"); //Error message to display for invalid number of credit hours
            }
                else MessageBox.Show("Enter a valid last initial");  //Error message to display for invalid last name initial
        }

    }
}
