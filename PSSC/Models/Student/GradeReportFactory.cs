using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Student
{
    class GradeReportFactory
    {
        public static readonly GradeReportFactory Instance = new GradeReportFactory();
        
        private GradeReportFactory()
        {
        
        }

        public GradeReport createGradeReport(GradeReport gradeReport)
        {
            return gradeReport;
        }
    }
}
