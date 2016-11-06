using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.source;
using Models.Deanship;

namespace Models.Repository
{
    class StudyYearRepository : IRepository<StudyYear>
    {
        public IEnumerable<StudyYear> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(StudyYear entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(StudyYear entity)
        {
            throw new NotImplementedException();
        }

        public StudyYear FindbyId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(StudyYear entity)
        {
            throw new NotImplementedException();
        }
    }
}
