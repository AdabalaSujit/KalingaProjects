using module_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class BoxEqualityComparer : IEqualityComparer<documents>
    {
        public bool Equals(documents b1, documents b2)
        {
            if (b2 == null && b1 == null)
            {
                return true;
            }
            else if (b1 == null | b2 == null)
                return false;
            else if (b1.id == b2.id)
                return true;
            else
                return false;
        }

       public int GetHashCode(documents f)
        {
            int hCode = f.id;
            return hCode.GetHashCode();
        }
    }
    

    }

