using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.interfaces
{
    public enum nume_Titlu
    {
        Profesor,
        Conferentiar,
        Lector,
        Sef_lucrari,
        Asistent,
        Doctorand
    }

    interface IProfessor
    {
        string Nume_Profesor
        {
            get;
            set;
        }
        nume_Titlu titlul
        {
            get;
            set;
        }

        string Curs
        {
            get;
            set;
        }

    }
}
