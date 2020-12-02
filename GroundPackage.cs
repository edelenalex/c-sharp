//Grading ID - N8817
//Section 75
//Due date - April 23, 2019
//This program will display tracking information about a package
using System;

namespace Program_4
{
    internal class GroundPackage
    {
       
        private int originZip; //int for packages zip code of origin
        private int destinatonZip; //int for the packages destination zip code
        private double length; //double variable for length of package
        private double width; //double variable for width of package
        private double height; //double variable for height of the package
        private double weight; //double variable for weight of the package

        // Constructor to initialize data members
        //precondition - none
        //postcondition - 
        public GroundPackage(int o, int d, double l, double w, double h, double lbs)
        {
            OriginZip = o;
            DestinatonZip = d;
            Length = l;
            Height = h;
            Width = w;
            Weight = lbs;

        }

        //Testing for valid inputs and setting variable values
        //precondition - none
        //postcondition - orginZip value set
        public int OriginZip
        {
            get { return originZip; }
            set
            {
                if (value >= 10000 && value <= 99999)  // If originating zip value is invalid, set it to default of 40202
                    originZip = value;
                else
                    originZip = 40202;
            }
        }

        //precondition - none
        //postcondition - destinationZip value set
        public int DestinatonZip
        {
            get { return destinatonZip; }
            set
            {
                if (value >= 10000 && value <= 99999)  // If destination zip value is invalid, set it to default of 90210
                    destinatonZip = value;
                else
                    destinatonZip = 90210;
            }
        }

        //precondition - none
        //postcondition - length value set
        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0) //If length value is invalid (negative number), set it a default of 1
                    length = value;
                else
                    length = 1.0;
            }
        }

        //precondition - none
        //postcondition - width value is set
        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0) //If width value is invalid (negative number), set it to a default of 1
                    width = value;
                else
                    width = 1.0;
            }
        }

        //precondition - none
        //postcondition - height value is set
        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0) //If height value is invalid (negative number), set it to a default of 1
                    height = value;
                else
                    height = 1.0;
            }
        }

        //precondition - none
        //postcondition - weight value is set
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0) //If weight value is invalid (negative number), set it to a default of 1
                    weight = value;
                else
                    weight = 1.0;
            }
        }

        public int ZoneDistance
        {
            get
            {
                int firstO = OriginZip / 10000; // Find first digit of origin zip
                int firstD = DestinatonZip / 10000; // Find first digit of destination zip
                return Math.Abs(firstO - firstD); // return absolute value of firstO - firstD
            }
        }

        public override string ToString()
        {
            return $"{"Origin ZipCode",-20}: {OriginZip}" + Environment.NewLine +
            $"{"Destination ZipCode",-20}: {DestinatonZip}" + Environment.NewLine +
            $"{"Length",-20}: {Length}" + Environment.NewLine +
            $"{"Height",-20}: {Height}" + Environment.NewLine +
            $"{"Width",-20}: {Width}" + Environment.NewLine +
            $"{"Weight",-20}: {Weight}";  // Use string interpolation to format strings
            // {"Origin ZipCode",-20} will set the string to left with width 20
            // same thing for all other strings
        }

        //precondition - none
        //postcondition - return calculated cost
        public double CalcCost()
        {
            // Calculate cost and return value
            double cost = .20 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * (Weight);
            return cost;

        }
    }
}
   