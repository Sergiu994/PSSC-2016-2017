using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.source
{
    class Situatia
    {
        int notaParcurs;
        int notaExamen;
        int prezenta;
        Materie materie;

        public Situatia(int notaParcurs, int notaExamen, int prezenta, Materie materie)
        {
            this.notaParcurs = notaParcurs;
            this.notaExamen = notaExamen;
            this.prezenta = prezenta;
            this.materie = materie;
        }

        public int NotaParcurs
        {
            get { return notaParcurs; }
            set { notaParcurs = value; }
        }

        public int NotaExamen
        {
            get { return notaExamen; }
            set { notaExamen = value; }
        }

        public int Prezenta
        {
            get { return prezenta; }
            set { prezenta = value; }
        }

        public Materie Materie
        {
            get { return materie; }
            set { materie = value; }
        }
    }
}
