using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.source
{
    public interface IRepository<T>
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindbyId(Guid Id);
    }
}
