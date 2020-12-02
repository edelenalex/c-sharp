//Grading ID: L5899
//Section: 75
//Program 1
//Due: September 24, 2019
//This GUI program will take users inputs of room measurements and calculate the minimum amount of paint needed to cover the room and how many gallons to purchase.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        //This event will take the users inputs and store them as the below listed variables and then run calculations and output the results
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            //Declaring all input, output and calculation variables
            const int doorSubtractor = 21;
            const int windowSubtractor = 12;
            const int coverage = 400;
            double lengthOfWalls;
            double heightOfWalls;
            int doorNum;
            int windowNum;
            int coatNum;
            double squareFt;
            double totalMinPaint;
            int gallonsToBuy;

            //Parsing inputs from the GUI form for further calculations
            lengthOfWalls = double.Parse(wallLengthTxt.Text);
            heightOfWalls = double.Parse(wallHeightTxt.Text);
            doorNum = int.Parse(numDoorsTxt.Text);
            windowNum = int.Parse(numWindowsTxt.Text);
            coatNum = int.Parse(numCoatsTxt.Text);

            //Calculating the minimum paint needed and the number of gallons to puchase
            squareFt = (lengthOfWalls * heightOfWalls) - (doorNum * doorSubtractor) - (windowNum * windowSubtractor);
            totalMinPaint = (squareFt * coatNum) / coverage;
            gallonsToBuy = (int)Math.Ceiling(totalMinPaint);

            //Output to the GUI form post calulations
            minGallonsOutputLbl.Text = $"{totalMinPaint:F1}";
            gallonsToBuyOutputLbl.Text = $"{gallonsToBuy}";
        }
    }
}
