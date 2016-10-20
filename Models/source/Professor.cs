using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.interfaces;

namespace Models.source
{
    class Professor:IProfessor
    {
        numeleTitlului Titlu;
        string numeProfesor;
        string curs;

        public string numeProfesor
        {
            get { return numeProfesor; }
            set { numeProfesor = value; }
        }

        public numeleTitlului Titlul
        {
            get { return Titlu; }
            set { Titlu = value; }
        }

        public string Curs
        {
            get { return curs; }
            set { curs = value; }
        }


        public Professor(numeleTitlului titlul, string numeProfesor, string Curs)
         {
             this.numeProfesor = numeProfesor;
             Titlu = titlul;
             curs = Curs;
         } 

    }
}
