using Data.Context;
using Domain.Entities;

namespace Data.Repositories
{
    public abstract class BaseRepository<T> where T : BaseEntity
    {
        public BaseRepository(MediatorDataContext context)
        {
            Db = context;
        }

        protected MediatorDataContext Db { get; set; }

        public T GetById(int id) => Db.Set<T>().Where(e => e.Id == id).SingleOrDefault();
        public IEnumerable<T> GetAll() => Db.Set<T>().ToList();
        public T Add(T entity) => Db.Set<T>().Add(entity).Entity;
        public T Update(T entity) => Db.Set<T>().Update(entity).Entity;
        public T Delete(int id)
        {
            var dbSet = Db.Set<T>();
            var entity = dbSet.Find(id);
            return dbSet.Remove(entity).Entity;
        }
    }
}
