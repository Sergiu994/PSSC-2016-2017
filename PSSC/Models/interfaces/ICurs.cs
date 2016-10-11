using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum TipOra
    {
        Curs,
        Seminar,
        Laborator,
        Proiect
    }
    interface ICurs
    {
        TipOra Tip
        {
            get;
            set;
        }
        string Nume
        {
            get;
            set;
        }
        string profesor
        {
            get;
            set;
        }
        int An_predare
        {
            get;
            set;
        }

        string Sala
        {
            get;
            set;
        }
    }
}