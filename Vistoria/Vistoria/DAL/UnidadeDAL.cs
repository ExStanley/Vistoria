using SQLite;
using System.Collections.ObjectModel;
using Vistoria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Vistoria.DAL
{
    public class UnidadeDAL : Repositorio<Unidade>
    {
        public override ObservableCollection<Unidade> GetAll()
        {
            return new ObservableCollection<Unidade>(conexao.Table<Unidade>());
        }

        public override Unidade GetId(int id)
        {
            return conexao.Table<Unidade>().Where(c => c.UnidadeId == id).FirstOrDefault();
        }

        public override IEnumerable<Unidade> Search(Expression<Func<Unidade, bool>> predicate)
        {
            return conexao.Table<Unidade>().Where(predicate);
        }

        public override IEnumerable<Unidade> SelectAll()
        {
            return conexao.Table<Unidade>();
        }

        public ObservableCollection<Unidade> GetAllFixo()
        {
            ObservableCollection<Unidade> lista = new ObservableCollection<Unidade>();
            //string codigo, string tipo, string descricao, string endereco, string cep
            lista.Add(new Unidade("53A", "Casa", "Casa com varanda", "509", "74917380"));
            lista.Add(new Unidade("53B", "Casa", "Casa com varanda", "509", "74917380"));
            lista.Add(new Unidade("53C", "Casa", "Casa com varanda", "509", "74917380"));
            lista.Add(new Unidade("53D", "Casa", "Casa com varanda", "509", "74917380"));
            lista.Add(new Unidade("53E", "Casa", "Casa com varanda", "509", "74917380"));
            lista.Add(new Unidade("53F", "Casa", "Casa com varanda", "509", "74917380"));
            lista.Add(new Unidade("53G", "Casa", "Casa com varanda", "509", "74917380"));
            lista.Add(new Unidade("53H", "Casa", "Casa com varanda", "509", "74917380"));
            return lista;
        }
    }
}
