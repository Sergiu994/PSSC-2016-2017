using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.source
{
    public enum Evaluare
    {
        Examen,
        Distribuita
    }
   
    class Materie
    {
         string numeMaterie;
         int nrCredite;
         Evaluare eval;
         Professor profesor;
         float proportie;
 
         public Materie(string numeMaterie, int nrCredite, Evaluare eval, Professor profesor, float proportie)
         {
             this.numeMaterie = numeMaterie;
             this.nrCredite = nrCredite;
             this.eval = eval;
             this.profesor = profesor;
             this.proportie = proportie;
         }

         public string NumeMaterie
         {
             get { return numeMaterie; }
             set { numeMaterie = value; }
         }
 
         public int NrCredite
         {
             get { return nrCredite; }
             set { nrCredite = value; }
         }
 
         public Evaluare Evaluare
         {
             get { return eval; }
             set { eval = value; }
         }
 
         public Professor Profesor
         {
             get { return profesor; }
             set { profesor = value; }
         }
          public float Proporitie
         {
             get { return proportie; }
             set { proportie = value; }
         }
    }
}
