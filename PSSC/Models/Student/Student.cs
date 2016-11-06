using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    //Entity
    public class Student
    {
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }
        public Guid studentID { get; internal set; }

        public Student(Guid ID,RegistrationNumber regNumber, PlainText name)
        {
            RegNumber = regNumber;
            Name = name;
            studentID=ID;
        }

        public Student(Guid ID,RegistrationNumber regNumber, PlainText name, Credits credits)
            : this(ID,regNumber, name)
        {
            Credits = credits;
        }
    }
}
