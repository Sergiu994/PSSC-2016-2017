using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface IStudent 
    {
        string NumeStudent
        {
            get;
            set;
        }
        string NrMatricol
        {
            get;
            set;
        }
        string Cnp
        {
            get;
            set;
        }
        int AnStudiu
        {
            get;
            set;
        }
    }
}