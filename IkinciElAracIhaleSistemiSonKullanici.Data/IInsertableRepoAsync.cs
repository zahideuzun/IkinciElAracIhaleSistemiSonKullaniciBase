using IkinciElAracIhaleSistemiSonKullanici.Data.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IkinciElAracIhaleSistemi.Entities.Entities.Bases;

namespace IkinciElAracIhaleSistemiSonKullanici.Data
{
    public interface IInsertableRepoAsync<T> : IRepository<T> where T : class, IEntity
    {
        Task AddAsync(T item);
        Task AddRangeAsync(List<T> items);
    }
}
