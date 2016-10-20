using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student :IStudent
    {
        string numeStudent;
        string nrMatricol;
        string CNP;
        int anStudiu;

        public string NumeStudent
        {
            get { return numeStudent; }
            set { numeStudent = value; }
        }

        public string NrMatricol
        {
            get { return nrMatricol; }
            set { nrMatricol = value; }
        }

        public string Cnp
        {
            get { return CNP; }
            set { CNP = value; }
        }
        public int AnStudiu
        {
            get { return anStudiu; }
            set { anStudiu = value; }
        }

        public Student(string numeStudent, string nrMatricol, string Cnp, int anStudiu)
        {
            this.anStudiu = anStudiu;
            this.numeStudent = numeStudent;
            this.nrMatricol = nrMatricol;
            this.Cnp = Cnp;
        }
    }
}