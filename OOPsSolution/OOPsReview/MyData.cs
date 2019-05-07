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
    //For a class to hold data, do not make it static, unless you want everyone to have access to that data (read and change)

    public class myData
    {
        public int Height;
        public int Width;

    }
}
