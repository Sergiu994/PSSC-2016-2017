using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.Exceptions
{
    public class InvalidCreditsValue : Exception
    {
        Credits credit;
        public InvalidCreditsValue()
        {
            if (credit.Count < 0)
            {
                throw new ArgumentException("Invalid value for credit");
            }

        }
    }
}
