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

using static System.Console;

namespace VikingNS
{
    public class Viking : IView
    {
        public string Name { get; set; }
        public Global.Status Status { get; set; }
        public short Health { get; set; }
        public Global.Weapon Weapon { get; set; }
        public bool Shield { get; set; }
/********************************************************************
*** METHOD <Viking>
*********************************************************************
*** DESCRIPTION : Copy constructor for VikingNS class
*** INPUT ARGS : N/A
*** OUTPUT ARGS : N/A
*** IN/OUT ARGS : N/A
*** RETURN : N/A
********************************************************************/
        public Viking(Viking viking)
        {
            Name = viking.Name;
            Status = viking.Status;
            Health = viking.Health;
            Weapon = viking.Weapon;
            Shield = viking.Shield;
        }
/********************************************************************
*** METHOD <Viking>
*********************************************************************
*** DESCRIPTION : parametrized constructor for VikingNS class
*** INPUT ARGS : N/A
*** OUTPUT ARGS : N/A
*** IN/OUT ARGS : N/A
*** RETURN : N/A
********************************************************************/
        public Viking(
            string name = "Bjorn",
            Global.Status status = Global.Status.KARL,
            short health = 150,
            Global.Weapon weapon = Global.Weapon.AXE,
            bool shield = false
        )
        {
            Name = name;
            Status = status;
            Health = health;
            Weapon = weapon;
            Shield = shield;
        }
/********************************************************************
*** METHOD <ViewH>
*********************************************************************
*** DESCRIPTION : Displays the content of the object calling it in a Horizontal way
*** INPUT ARGS : N/A
*** OUTPUT ARGS : N/A
*** IN/OUT ARGS : N/A
*** RETURN : Void
********************************************************************/    
        public void ViewH()
        {
            WriteLine("Name\tStatus\tHealth\tWeapon\tShield");  // Dsipay the labes for the information to be displayed
            WriteLine("---------------------------------------"); // Display a boundary line
            WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
            Name, Status, Health, Weapon, Shield); 
        }
/********************************************************************
*** METHOD <ViewV>
*********************************************************************
*** DESCRIPTION : Displays the content of the object calling it in a Vertical way
*** INPUT ARGS : N/A
*** OUTPUT ARGS : N/A
*** IN/OUT ARGS : N/A
*** RETURN : Void
********************************************************************/  
        public void ViewV()
        {
            WriteLine("Name:\t {0, -10}", Name);
            WriteLine("Status:\t {0, -10}", Status);
            WriteLine("Health:\t {0, -10}", Health);
            WriteLine("Weapon:\t {0, -10}", Weapon);
            WriteLine("Shield:\t {0, -10}", Shield);
        }
    }
}