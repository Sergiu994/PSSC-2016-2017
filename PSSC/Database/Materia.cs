//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    using Common.Common;

    public partial class Materia:IEntity
    {
        public int ID_Materie { get; set; }
        public string Nume_materie { get; set; }
        public Nullable<int> Numar_credite { get; set; }
        public string Tipul_evaluarii { get; set; }
        public Nullable<double> Proportia { get; set; }
        public string IDProfesor { get; set; }
    }
}