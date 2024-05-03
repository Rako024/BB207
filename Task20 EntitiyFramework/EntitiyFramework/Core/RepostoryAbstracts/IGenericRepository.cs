using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepostoryAbstracts
{
    public interface IGenericRepository<T> where T : class,new()
    {
        void Add(T entity);
        void Delete(T entity);
        T Get(Func<T,bool>? predicate);
        List<T> GetAll(Func<T, bool>? predicate);
        int Commit();
    }
}
