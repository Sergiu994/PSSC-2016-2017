using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.interfaces
{
    public enum numeleTitlului
    {
        Profesor,
        Conferentiar,
        Lector,
        Sef_lucrari,
        Asistent,
        Doctorand
    }

    interface IProfesor
    {
        string NumeProfesor
        {
            get;
            set;
        }
        numeleTitlului Titlul
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
