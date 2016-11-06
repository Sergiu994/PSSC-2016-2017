using Models.Generics;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    //Aggregate Root
   //centralizeaza situatia pe o materie cu toate detaliile 
    public class GradeReport
    {
        private ReadOnlyCollection<KeyValuePair<SubjectInformation, SubjectSituation>> _gradeReport;
        private Guid _gradeReportID;

        public GradeReport(Guid ID,ReadOnlyCollection<KeyValuePair<SubjectInformation, SubjectSituation>> gradeReport)
        {
            _gradeReport = gradeReport;
            _gradeReportID = ID;
        }

        public SubjectSituation GetSubjectSituation(PlainText subjectName)
        {
            return _gradeReport.First(d => d.Key.Name == subjectName).Value;
        }
    }
}