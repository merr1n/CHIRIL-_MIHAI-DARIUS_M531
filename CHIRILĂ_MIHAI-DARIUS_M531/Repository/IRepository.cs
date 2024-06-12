using System.Linq.Expressions;

namespace CHIRILĂ_MIHAI_DARIUS_M531.Repository
{
    public interface IRepository<T> where T : class
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAll(string[] entitiesToInclude);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}