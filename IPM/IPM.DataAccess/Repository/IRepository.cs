using System.Collections.Generic;

namespace IPM.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetListPage(int pageNumber, int pageSize, string keySearch);
        bool Insert(T item);
        T GetOne(int id);
        bool Update(T item);
        bool Delete(int id);
        
    }
}