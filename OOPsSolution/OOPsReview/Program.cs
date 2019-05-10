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
            //Creation of an instance using a greedy constructor
            FencePanel aGreedyInstance = new FencePanel(4.0, 6.8, "Private", 32.89);
            Console.WriteLine("Height is: " + aGreedyInstance.Height.ToString());
            Console.WriteLine("Width is: " + aGreedyInstance.Width.ToString());
            Console.WriteLine("Style is: " + aGreedyInstance.Style.ToString());
            Console.WriteLine("Price is: " + aGreedyInstance.Price.ToString() + "\n");
            //Using instances of classes

            string menuItem = "0";
            FenceEstimate CustomerFence = new FenceEstimate();
            //Placing data from the right side into the left side
            CustomerFence.Fence = aGreedyInstance;
            CustomerFence.Gates = null;
            string inputValue;
            Gate theGate = null;
            do
            {
                theGate = new Gate();
                Console.Write("Height: ");
                inputValue = Console.ReadLine();
                theGate.Height = double.Parse(inputValue);
                
                Console.Write("Width: ");
                inputValue = Console.ReadLine();
                theGate.Width = double.Parse(inputValue);
               
                Console.Write("Style: ");
                inputValue = Console.ReadLine();
                theGate.Style = (inputValue);
              
                Console.Write("Price: ");
                inputValue = Console.ReadLine();
                theGate.Price = double.Parse(inputValue);
                if (string.IsNullOrEmpty(inputValue))
                {
                    theGate.Price = null;
                }
                else
                {
                    theGate.Price = double.Parse(inputValue);
                }
                //The local instance of "Gate" needs to be saved into the FenceEstimate
                CustomerFence.Gates.Add(theGate);

                Console.Write("Another gate (Y or N): ");
                inputValue = Console.ReadLine();
                menuItem = inputValue.ToUpper().Equals("Y") ? "1" : "0";

            } while (menuItem != "0");

            Console.Write("Fence Length: ");
            inputValue = Console.ReadLine();
            double linearLength = double.Parse(inputValue);

            //Using the CustomeFence data, calculate the cost
            double NumberofPanels = CustomerFence.Fence.EstimatedNumberofPanels(linearLength);
            double FencePrice = Math.Ceiling(NumberofPanels) * double.Parse(CustomerFence.Fence.Price.ToString()); //Ceiling always rounds up; Floor rounds down; Round rounds?
            double gateCost = 0.0;
            foreach(Gate item in CustomerFence.Gates)
            {
                gateCost += double.Parse (item.Price.ToString());
            }

            Console.WriteLine("Total Fence Estimate");
            Console.WriteLine("Number of Panels: " + NumberofPanels.ToString());
            Console.WriteLine("Cost of Panels: " + FencePrice.ToString());
            Console.WriteLine("Number of Gates: " + CustomerFence.Gates.Count.ToString());
            Console.WriteLine("Cost of Gates: " + gateCost.ToString());
            Console.WriteLine("Total: " + (FencePrice + gateCost).ToString());

            Console.ReadLine();
        }//eom
    }///eoc

}//eon
