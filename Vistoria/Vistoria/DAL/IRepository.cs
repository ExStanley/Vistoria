using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Vistoria.DAL
{
    interface IRepository<TEntity>: IDisposable where TEntity: class
    {
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        void Delete(TEntity obj);

    }
}
