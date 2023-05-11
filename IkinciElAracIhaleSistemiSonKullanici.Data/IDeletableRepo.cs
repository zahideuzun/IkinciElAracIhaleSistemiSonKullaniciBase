﻿using IkinciElAracIhaleSistemiSonKullanici.Data.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkinciElAracIhaleSistemiSonKullanici.Data
{
    public interface IDeletableRepo<T> : IRepository<T> where T : class, IEntity
    {
        void Delete(T item);
    }
    
}
