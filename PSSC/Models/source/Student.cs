﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student :IStudent
    {
        string nume_student;
        string nr_matricol;
        string cnp;
        int an_studiu;
        List<Models.source.Situatia> note = new List<Models.source.Situatia>();

        public string Nume_student
        {
            get { return nume_student; }
            set { nume_student = value; }
        }

        public string Nr_matricol
        {
            get { return nr_matricol; }
            set { nr_matricol = value; }
        }

        public string CNP
        {
            get { return cnp; }
            set { cnp = value; }
        }
        public int An_studiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }

        public Student(string Nume_student, string Nr_matricol, string CNP, int An_studiu)
        {
            nume_student = Nume_student;
            nr_matricol = Nr_matricol;
            cnp = CNP;
            an_studiu = An_studiu;
        }
    }
}