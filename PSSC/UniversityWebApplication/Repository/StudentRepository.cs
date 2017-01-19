using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Common.Common;

namespace UniversityWebApplication.Repository
{
    public class StudentRepository : IRepository<Database.Studentt>
    {
       public PSSCEntities _studentContext=new PSSCEntities();

        public StudentRepository()
        {
            _studentContext = new PSSCEntities();
        }

        public IEnumerable<Studentt> List
        {
            get
            {
                return _studentContext.Studentts;
            }
        }

        public void Add(Studentt entity)
        {
            _studentContext.Studentts.Add(entity);
            _studentContext.SaveChanges();
        }

        public void Delete(Studentt entity)
        {
            _studentContext.Studentts.Remove(entity);
        }

        public Studentt FindbyId(Guid Id)
        {
            var result = (from r in _studentContext.Studentts where String.Equals(r.Numar_matricol,Id) select r).FirstOrDefault();
            return result;
        }

        public void Update(Studentt entity)
        {
            _studentContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _studentContext.SaveChanges();
        }
    }
}
