using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDWorkshop
{
    public class StringOperations
    {

        public string ChangeToLJowerCase(string upper)
        {
            return upper.ToLower();
        }

        public string GetBirthday(string ssn)
        {
            var x = ssn.Substring(0, 4) + "-" + ssn.Substring(4, 2) + "-" + ssn.Substring(6, 2);
            return x;
        }
    }
}
