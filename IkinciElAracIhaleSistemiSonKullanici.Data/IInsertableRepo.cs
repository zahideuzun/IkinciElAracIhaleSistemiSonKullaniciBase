using IkinciElAracIhaleSistemiSonKullanici.Data.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkinciElAracIhaleSistemiSonKullanici.Data
{
    public interface IInsertableRepo<T> : IRepository<T> where T : class, IEntity
    {
        T Add(T item);
        List<T> AddRange(List<T> items);
    }
    
}
