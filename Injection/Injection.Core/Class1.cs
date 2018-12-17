using System;
using System.Collections.Generic;

namespace Injection.Core
{
    public interface ICRUDRepository<TKey, TEntity>
    {
        void Add(TEntity entity);

        void Remove(TKey key);

        TEntity GetById(TKey key);

        IEnumerable<TEntity> GetAll();
    }
}
