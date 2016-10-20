using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.interfaces;

namespace Models.source
{
    public class Profesor:IProfesor
    {
        numeleTitlului titlul;
        string numeProfesor;
        string curs;

        public string NumeProfesor
        {
            get { return numeProfesor; }
            set { numeProfesor = value; }
        }

        public numeleTitlului Titlul
        {
            get { return titlul; }
            set { titlul = value; }
        }

        public string Curs
        {
            get { return curs; }
            set { curs = value; }
        }


        public Profesor(numeleTitlului titlul, string numeProfesor, string curs)
         {
             this.titlul = titlul;
             this.numeProfesor = numeProfesor;
             this.curs = curs;
         } 

    }
}
