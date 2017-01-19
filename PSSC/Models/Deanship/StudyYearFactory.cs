using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Deanship
{
    class StudyYearFactory
    {
        public static readonly StudyYearFactory Instance = new StudyYearFactory();

        private StudyYearFactory()
        {
        }

        public StudyYear createStudyYear(List<Subject.Subject> subjects)
        {
            var studyYear = new StudyYear(subjects);     
            return studyYear;
        }
    }
}
