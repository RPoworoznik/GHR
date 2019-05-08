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
            FencePanel aVariable = null;

            //If you use the "new" command with a class, the "new" command will "physically" create and instance of the class
            FencePanel anInstance = new FencePanel();
            if (aVariable == null)
            {
                Console.WriteLine("aVariable has nothing in it");   
            }
            if (anInstance == null)
            {
                Console.WriteLine("anInstance has nothing in it");               
            }
            Console.ReadLine();
        }//eom
    }///eoc

}//eon
