using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vistoria.Dados;
using Xamarin.Forms;

namespace Vistoria.DAL
{
    public abstract class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private SQLiteConnection con = DependencyService.Get<ISqlite>().GetConnection();
        protected SQLiteConnection conexao;

        public Repositorio()
        {
            conexao = con;
            new BDContext(con);
            //conexao.CreateTable<TEntity>();
        }
        public TEntity Add(TEntity obj)
        {
            conexao.Insert(obj);
            GetAll();
            return obj;
        }

        public void Delete(TEntity obj)
        {
            conexao.Delete(obj);
        }

        public void Dispose()
        {
            conexao.Dispose();
            GC.SuppressFinalize(this);
        }

        public abstract ObservableCollection<TEntity> GetAll();
        public abstract IEnumerable<TEntity> SelectAll();

        public abstract TEntity GetId(int id);

        public abstract IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);

        public TEntity Update(TEntity obj)
        {
            conexao.Update(obj);
            return obj;
        }
    }
}
