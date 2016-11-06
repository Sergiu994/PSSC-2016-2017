using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.source;
using Models.Student;
namespace Models.Repository
{
    class GradeReportRepository : IRepository<GradeReport>
    {
        public IEnumerable<GradeReport> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(GradeReport entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(GradeReport entity)
        {
            throw new NotImplementedException();
        }

        public GradeReport FindbyId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(GradeReport entity)
        {
            throw new NotImplementedException();
        }
    }
}
