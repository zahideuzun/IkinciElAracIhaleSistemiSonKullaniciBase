using IkinciElAracIhaleSistemiSonKullanici.Data.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkinciElAracIhaleSistemiSonKullanici.Data
{
    public interface ISelectableRepo<T> : IRepository<T> where T : class, IEntity
    {
        List<T> GetAll();
        T GetById(object id);
        List<T> GetBy(Func<T, bool> condition);
    }
}
