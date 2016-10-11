using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.interfaces;

namespace Models.source
{
    class Professor: Sectia,IProfessor
    {
        nume_Titlu titlu;
        string nume_profesor;

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

        public Professor(string Nume_facultate, string Nume_sectie,nume_Titlu Titlu, string Nume_profesor):base( Nume_facultate,  Nume_sectie)
         {
             nume_profesor = Nume_Profesor;
             titlu = titlul;
         } 

    }
}
