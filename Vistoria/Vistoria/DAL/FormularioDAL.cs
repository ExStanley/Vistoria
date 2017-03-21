using SQLite;
using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Vistoria.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Vistoria.DAL
{
    public class FormularioDAL : Repositorio<Formulario>
    {
        public override ObservableCollection<Formulario> GetAll()
        {
            return new ObservableCollection<Formulario>(conexao.Table<Formulario>());
        }

        public override Formulario GetId(int id)
        {
            return conexao.Table<Formulario>().Where(c => c.FormularioId == id).FirstOrDefault();
        }

        public override IEnumerable<Formulario> Search(Expression<Func<Formulario, bool>> predicate)
        {
            return conexao.Table<Formulario>().Where(predicate);
        }

        public override IEnumerable<Formulario> SelectAll()
        {
            return conexao.Table<Formulario>();
        }

        public ObservableCollection<Formulario> GetAllFixo()
        {
            ObservableCollection<Formulario> lista = new ObservableCollection<Formulario>();
            lista.Add(new Formulario("53A", "Casa", "Conclusão de obra", "Formulario de vistória de consluão de obra"));
            lista.Add(new Formulario("F1A", "Casa", "Conclusão de obra", "Formulario de vistória de consluão de obra"));
            lista.Add(new Formulario("F2A", "Casa", "Conclusão de obra", "Formulario de vistória de consluão de obra"));
            lista.Add(new Formulario("F3A", "Lote", "Conclusão de obra", "Formulario de vistória de consluão de obra"));
            lista.Add(new Formulario("F4A", "Lote", "Conclusão de obra", "Formulario de vistória de consluão de obra"));
            lista.Add(new Formulario("F5A", "Lote", "Conclusão de obra", "Formulario de vistória de consluão de obra"));
            lista.Add(new Formulario("F6A", "Apto", "Conclusão de obra", "Formulario de vistória de consluão de obra"));
            lista.Add(new Formulario("F7A", "Apto", "Conclusão de obra", "Formulario de vistória de consluão de obra"));
            lista.Add(new Formulario("F8A", "Apto", "Conclusão de obra", "Formulario de vistória de consluão de obra"));
            lista.Add(new Formulario("F9A", "Apto", "Conclusão de obra", "Formulario de vistória de consluão de obra"));
            return lista;
        }
    }
}
