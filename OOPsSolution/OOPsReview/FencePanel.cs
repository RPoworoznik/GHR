using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    //The default access permissions are private
    //If an outside user of this class wanted access to the class contents, then the access permissions need to be public
    //If this class was static, the class would not hold data
    //For a class to hold data, DO NOT make it static, unless you want everyone to have access to that data (read and change)

    public class FencePanel
    {
        //Properties: a property is associated with a single piece of data
        //A property has two sub-components: "get" and "set"
        //"Get" *returns* a value to the calling "client" (i.e., a method)
        //"Set" *recieves* a value from the calling client
        //The keyword used to represent incoming data is "value"
        //A property DOES NOT take in a parameter
        //There are two ways to code a property: Fully-Implemented and Auto-Implemented

        //Auto-implemented property: the property does not need a private data memeber to hold the actual data
        //The data storage will be managed by the system

        public double Height { get; set; } //{get; set;} changes the variable to an auto-implemented property inside another class
        public double Width { get; set; } //Properties are "gateways" between one class and another

        //Fully-implemented prperty: will have a private data member to hold the actual data
        //Usually, this coding form is used when additional logic/critera is associated with the data value
        //Since the property will be doing some actions against the data, you MUST supply a storage area (i.e., a variable)
        //This storage area is referred to as a "Private Data Member"

        //Private data member
        private string _Style;

        //Full-implemented property
        public string Style
        {
            get { return _Style; }
            //"Value" contains the incoming data to the property
            //The contents of value needs to be stored
            //Criteria: DO NOT store an empty string; store either "null" or the characters in the string
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Style = null;
                }
                else
                {
                    _Style = value;
                }         
            }
        }
        //A nullable numeric (xxx?) will contain either a null or a number
        //Therefore nullable numeric DO NOT need to be fully implemented, unless one has additional criteria to address
        public double? Price { get; set; }

        //Construtor(s): These are executed for the client/calling during the execution of the "new" command
        //The cleint/caller DOES NOT call a constructor directly
        //If no constructors are coded in a class definition, then the data storage within the class definition
        //  is set to the System defaults (string =. null; numerics = 0; bool => false, etc).
        //If one codes a contructor within the class definition, then the coder is responsible for ALL constructors
        //Syntax: public classname (list of parameters) {code}
        //There are two generally created contructors: 
        //Default: simulates the System default initialization of your data storage using their datatype
        //Greedy: This has a parameter list of all data storage items defined within the class definition

        //Default:
        public FencePanel()
        {
            //Optionally, you may wish to have your own default values for your storage items
        }

        //Greedy
        public FencePanel (double height, double width, string style, double? price)
        {
            Height = height;
            Width = width;
            Style = style;
            Price = price;
        }

        //Method (aka "Behaviour")
        public double EstimatedNumberofPanels(double linearlength)
        {
            
            double numberofpanels = linearlength / Width;
            return numberofpanels;
        }
    }
}
