using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    class Equal_override
    {
        public override bool Equals(Object p)
        {

            if (this.GetType() == p.GetType()) 
            {
                return true;
            }

            return false;

        }


    }
}
