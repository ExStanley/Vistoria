using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Vistoria.Modelo;

namespace Vistoria.DAL
{
    public class PerguntaDAL: Repositorio<Pergunta>
    {
        public PerguntaDAL() { }

        public override ObservableCollection<Pergunta> GetAll()
        {
            return new ObservableCollection<Pergunta>(conexao.Table<Pergunta>());
        }

        public override Pergunta GetId(int id)
        {
            return conexao.Table<Pergunta>().Where(c => c.PerguntaId == id).FirstOrDefault();
        }

        public override IEnumerable<Pergunta> Search(Expression<Func<Pergunta, bool>> predicate)
        {
            return conexao.Table<Pergunta>().Where(predicate);
        }

        public override IEnumerable<Pergunta> SelectAll()
        {
            return conexao.Table<Pergunta>();
        }

        public ObservableCollection<Pergunta> GetAllFixo()
        {
            ObservableCollection<Pergunta> lista = new ObservableCollection<Pergunta>();
            //string codigo, string tipo, string descricao, string endereco, string cep
            lista.Add(new Pergunta(1, "Estado de conservação da pintura" ));
            lista.Add(new Pergunta(2, "Possui energia"));
            lista.Add(new Pergunta(3, "Despesa de água"));
            lista.Add(new Pergunta(4, "Conservação da casa"));
            lista.Add(new Pergunta(5, "Conservação do piso"));
            lista.Add(new Pergunta(6, "Possui portaria"));
            return lista;
        }
    }
}
