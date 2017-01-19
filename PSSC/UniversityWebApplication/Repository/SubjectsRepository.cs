using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database;
using UniversityWebApplication.Repository;

namespace UniversityWebApplication.Repository
{
    class SubjectsRepository : IRepository<Database.Materia>
    {
        private static List<Models.Subject.Subject> _subjects = new List<Models.Subject.Subject>();
        private static Models.Professor.Subjects subjects = new Models.Professor.Subjects(_subjects);

        public PSSCEntities _subjectsContext = new PSSCEntities();

        public SubjectsRepository()
        {
            _subjectsContext = new PSSCEntities();
        }

        public IEnumerable<Materia> List
        {
            get
            {
                return _subjectsContext.Materias;
            }
        }

        public void Add(Materia entity)
        {
            _subjectsContext.Materias.Add(entity);
            _subjectsContext.SaveChanges(); ;
        }

        public void Delete(Materia entity)
        {
            var result = subjects.AllSubjects.FirstOrDefault(s => s.Equals(entity));

            if (result == null) throw new MissingMemberException();

            _subjectsContext.Materias.Remove(entity);
            Console.WriteLine("A subject was deleted.");
        }

        public Materia FindbyId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Materia entity)
        {
            throw new NotImplementedException();
        }
    }
}
