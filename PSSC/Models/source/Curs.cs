using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Curs : ICurs
    {
        TipOra tip;
        string nume;
        string cadru_didactic;
        int an_predare;
        string sala;
        public TipOra Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string profesor
        {
            get { return cadru_didactic; }
            set { cadru_didactic = value; }
        }
        public int An_predare
        {
            get { return an_predare; }
            set { an_predare = value; }
        }

        public string Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        public Curs(TipOra Tip, string Nume, string profesor, int An_predare)
        {
            tip = Tip;
            nume = Nume;
            cadru_didactic = profesor;
            an_predare = An_predare;
        }
    }
}