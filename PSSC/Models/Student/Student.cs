using Models.Generics;

namespace Models.Student
{
    //Entity
    public class Student
    {
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }
       // public Guid studentID { get; internal set; }


        public Student()
        { }
        public Student(RegistrationNumber regNumber, PlainText name)
        {
            RegNumber = regNumber;
            Name = name;
        }

        public Student( PlainText name, Credits credits,RegistrationNumber regNumber)
            : this(regNumber, name)
        {
            Credits = credits;
        }
    }
}
