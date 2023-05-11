using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkinciElAracIhaleSistemiSonKullanici.Data.Bases
{
    public interface IRepository<T> where T : class, IEntity
    {
        void MySaveChanges();
    }
    
}
