using Core.RepostoryAbstracts;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcreters
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        AppDbContext _appDb;
        public GenericRepository()
        {
            _appDb = new AppDbContext();
        }

        public void Add(T entity)
        {
            _appDb.Set<T>().Add(entity);
        }

        public int Commit()
        {
            return _appDb.SaveChanges();
        }

        public void Delete(T entity)
        {
            _appDb.Set<T>().Remove(entity);
        }

        public T Get(Func<T, bool>? predicate)
        {
            return predicate == null ? _appDb.Set<T>().FirstOrDefault() :
                                _appDb.Set<T>().Where(predicate).FirstOrDefault();
        }

        public List<T>  GetAll(Func<T, bool>? predicate)
        {
            return predicate == null ? _appDb.Set<T>().ToList() :
                                _appDb.Set<T>().Where(predicate).ToList();
        }

        
    }
}
