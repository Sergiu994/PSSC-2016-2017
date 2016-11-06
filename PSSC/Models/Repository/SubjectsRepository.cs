using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.source;

namespace Models.Repository
{
    class SubjectsRepository : IRepository<Subject.Subject>
    {
        public IEnumerable<Subject.Subject> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Subject.Subject entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Subject.Subject entity)
        {
            throw new NotImplementedException();
        }

        public Subject.Subject FindbyId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Subject.Subject entity)
        {
            throw new NotImplementedException();
        }
    }
}
