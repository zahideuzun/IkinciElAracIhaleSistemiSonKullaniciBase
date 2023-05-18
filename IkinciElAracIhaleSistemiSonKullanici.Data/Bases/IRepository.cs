using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IkinciElAracIhaleSistemi.Entities.Entities.Bases;

namespace IkinciElAracIhaleSistemiSonKullanici.Data.Bases
{
    public interface IRepository<T> where T : class, IEntity
    {
        void MySaveChanges();
    }
    
}
