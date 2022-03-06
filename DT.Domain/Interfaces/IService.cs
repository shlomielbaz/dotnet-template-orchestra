
using DT.Domain.General;

namespace DT.Domain.Interfaces
{
    public interface IService<T>
    {
        public IEnumerable<T> Get();
        public T Get(Guid id);
        public void Add(T model);
        public void Update(T model);
        public void Delete(T model);
    }
}
