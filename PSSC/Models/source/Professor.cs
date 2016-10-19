using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.interfaces;

namespace Models.source
{
    class Professor:IProfessor
    {
        nume_Titlu titlu;
        string nume_profesor;
        string curs;
        public string Nume_Profesor
        {
            get { return nume_profesor; }
            set { nume_profesor = value; }
        }

        public nume_Titlu titlul
        {
            get { return titlu; }
            set { titlu = value; }
        }

        public string Curs
        {
            get { return curs; }
            set { curs = value; }
        }


        public Professor(nume_Titlu titlu, string Nume_profesor,string Curs)
         {
             nume_profesor = Nume_Profesor;
             titlu = titlul;
             curs = Curs;
         } 

    }
}
