/********************************************************************
*** NAME : Kaleab Zerihun
*** CLASS : CSc 346
*** ASSIGNMENT : Assignment 2
*** DUE DATE : 02-26-24
*** INSTRUCTOR : GAMRADT
*********************************************************************
*** DESCRIPTION : Use Visual Studio Code to create a user-defined Abstract Data Type (ADT) using C# classes named Viking and
Global along with an interface named IView and an appropriate set of C# files as discussed in class ***
********************************************************************/

using System;
using static System.Console;
using static VikingNS.Global.Status;
using static VikingNS.Global.Weapon;

namespace VikingNS
{
    class Program
    {
/********************************************************************
*** METHOD Main
*********************************************************************
*** DESCRIPTION : Creates an object for Viking and prints the contents
of the object both vertically and horizontally. After that it creates another
object of the viking class and then displays another content of the class. 
*** INPUT ARGS : N/A
*** OUTPUT ARGS : N/A
*** IN/OUT ARGS : N/A
*** RETURN : Void
********************************************************************/
        static void Main()
        {
            Viking viking1 = new Viking();  // Create an object
            // Display its content
            WriteLine("First Horizontal"); 
            viking1.ViewH();
            WriteLine(" ");
            WriteLine("First Vertical");
            viking1.ViewV();
            WriteLine(" ");

            Viking viking2 = new Viking("Ragnar", JARL, 250, SWORD, true); // Create another object
            //Display its content
             WriteLine("Second Horizontal");
            viking2.ViewH();
            WriteLine(" ");
            WriteLine("Second Vertical");
            viking2.ViewV();
            WriteLine(" ");
        }
    }
}
