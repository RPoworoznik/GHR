using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Console is a reference to a system static class
            //Static classes are used by typing the class name 
            //Static classes do not store variable data
            //Static classes are used by everyone (are public and not private)
            //Methods of a static class will be placed after the object dot operator
            Console.WriteLine("Hello World");

            //Create an instane of a non-static class
            //**An object is a programmer/developer defined datatype
            //If one creates a declarative using just the class name, then this is only a "pointer" that can hold an instance of a class specified
            //Current value of aVariabel is "null"
            

            //If you use the "new" command with a class, the "new" command will "physically" create and instance of the class
            //When this statement is executed, the Default Constructor of the FencePanel class will be called on my behalf
            FencePanel anInstance = new FencePanel();
            anInstance.Height = 5.8;
            anInstance.Width = 8.0;
            anInstance.Style = "Neighbour Friendly";

            Console.WriteLine("Height is: " + anInstance.Height.ToString());
            Console.WriteLine("Width is: " + anInstance.Width.ToString());
            Console.WriteLine("Style is: " + anInstance.Style.ToString());
            Console.WriteLine("Price is: " + anInstance.Price.ToString() + "\n");

            FencePanel aGreedyInstance = new FencePanel(4.0, 6.8, "private", 32.89);
            Console.WriteLine("Height is: " + aGreedyInstance.Height.ToString());
            Console.WriteLine("Width is: " + aGreedyInstance.Width.ToString());
            Console.WriteLine("Style is: " + aGreedyInstance.Style.ToString());
            Console.WriteLine("Price is: " + aGreedyInstance.Price.ToString() + "\n");

            Console.ReadLine();
        }//eom
    }///eoc

}//eon
