//Grading ID - N8817
//Section 75
//Due date - April 23, 2019
//This program will display tracking information for a package
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{

    class GroundPackageTestClass
    { 
    static void Main(string[] args)
        {
            
            GroundPackage gp1 = new GroundPackage(12345, 54321, 10, 20, 10, 50);
            GroundPackage gp2 = new GroundPackage(1111, 54321, 50, 50, 40, 150);
            GroundPackage gp3 = new GroundPackage(50000, 10000, 70, 50, 40, 250);
            GroundPackage gp4 = new GroundPackage(12345, 9999, 70.5, 50.65, 30, 78);
            GroundPackage gp5 = new GroundPackage(54321, 99723, 100, 85, 55, 120); // Create 5 objects of GroundPackage class

            GroundPackage[] packages = { gp1, gp2, gp3, gp4, gp5 }; // Create an array and store these objects in packages array

            DisplayPackages(packages); // Call function to display packages

            // Change gp1 and display it
            gp1.OriginZip = 55555;
            gp1.Length = 25.5;
            display(gp1);

            // Change gp2 and display it
            gp2.Length = -1;
            display(gp2);

        }

        //precondition - none
        //postcondition - display package info
        static void DisplayPackages(GroundPackage[] packages)
        {
            for (int i = 0; i < packages.Length; i++)
            {
                Console.WriteLine("Package " + (i + 1) + "\n-----------------------------"); //Iterate loop over packages array
                Console.WriteLine(packages[i]); // Display package number
                Console.WriteLine($"{"Shipping Cost",-20}: ${ packages[i].CalcCost()}"); // Display object at index i
                Console.WriteLine(); // Display shipping cost by calling function CalcCost
            }
        }

        //precondition - none
        //postcondition - calls shipping cost function and displays it
        static void display(GroundPackage package)
        {
            Console.WriteLine(package); // Display package
            Console.WriteLine($"{"Shipping Cost",-20}: ${ package.CalcCost()}"); // Display shipping cost by calling function
            Console.WriteLine();
        }
    }
}
        
