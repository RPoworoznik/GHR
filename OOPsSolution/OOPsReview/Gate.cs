using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Gate
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
              
        public Gate()
        {
            
        }
    
        public Gate(double height, double width, string style, double? price)
        {
            Height = height;
            Width = width;
            Style = style;
            Price = price;
        }
       
        public double EstimatedNumberofPanels(double linearlength, double gatewidth, int numberofgates)
        {
            double totalgatewidth = gatewidth * numberofgates;
            double fencewidth = linearlength - totalgatewidth;
            double numberofpanels = fencewidth / Width;
            return numberofpanels;
        }
    }
}
