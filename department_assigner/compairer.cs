using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
//this class extends and implements the compairer 
//msf @black eagle @firo

namespace department_assigner
{
    internal class compairer : IComparer<student>
    {

        //implement the compair method 
        public int Compare(student x, student y)
        {
            if (x == null || y == null)
                return 0;
            //if not null continue compairing using compair to func
            
            //
           return  y.ave.CompareTo(x.ave);
        }
    }

} //end namespace 

