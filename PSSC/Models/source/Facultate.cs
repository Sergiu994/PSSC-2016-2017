using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Facultate 
    {
        string nume_facultate;
        public string Nume_facultate
        {
            get { return nume_facultate; }
            set { nume_facultate = value; }
        }
        public Facultate(string Nume_facultate)
        {
            nume_facultate = Nume_facultate;
        }
    }
}