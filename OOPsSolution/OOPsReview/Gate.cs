using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Gate
    {        
        public double Height { get; set; } 
        public double Width { get; set; }

        private string _Style;
      
        public string Style
        {
            get { return _Style; }
           
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
        
        public double? Price { get; set; }

        public Gate() { }
        
    
        public Gate(double height, double width, string style, double? price)
        {
            Height = height;
            Width = width;
            Style = style;
            Price = price;
        }
          
        //Read-only property contains NO "set{}"
        //Data used in this property is data that is currently in the instance of this class
        public double GateArea
        {
            get
            {
                return Height * Width;
            }
        }
    }
}
