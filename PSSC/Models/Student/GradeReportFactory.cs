using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Models.Generics;
using Models.Subject;

namespace Models.Student
{
    class GradeReportFactory
    {
        public static readonly GradeReportFactory Instance = new GradeReportFactory();
        
        private GradeReportFactory()
        {
        
        }

        public GradeReport createGradeReport(Guid id, ReadOnlyCollection<KeyValuePair<SubjectInformation, SubjectSituation>> gradereport)
        {
            var gradeReport = new GradeReport(id,gradereport);
            return gradeReport;
        }

        public Student createStudent(Guid id,string regnumber, string name, int credits)
        {
            var student = new Student( new PlainText(name), new Credits(credits),new RegistrationNumber(regnumber));
            return student;
        }
    }
}
