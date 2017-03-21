using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistoria.Modelo;

namespace Vistoria.DAL
{
    public class BDContext
    {
        public BDContext(SQLiteConnection conexao)
        {
            conexao.CreateTable<Pergunta>();
            conexao.CreateTable<Unidade>();
            conexao.CreateTable<Formulario>();
        }
    }
}
