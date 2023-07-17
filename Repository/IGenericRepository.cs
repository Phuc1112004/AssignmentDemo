using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemo.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);
        List<T> GetAll(List<string> includes = null);
        T GetById(int id);
    }
}
