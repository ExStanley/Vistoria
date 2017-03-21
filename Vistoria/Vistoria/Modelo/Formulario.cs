using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace Vistoria.Modelo
{
    public class Formulario
    {
        [PrimaryKey, AutoIncrement]
        public int FormularioId { get; set; }
        public DateTime DataVistoria { get; set; }
        public string Codigo { get; set; }
        public string TipoImovel { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        //[ForeignKey(typeof(Unidade))]
        public int? UnidadeId { get; set; }

        //[ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        //public Unidade Unidade { get; set; }

        //[OneToMany]
        //public List<Pergunta> Perguntas { get; set; }
        public Formulario(){}
        public Formulario(string codigo, string tipoImovel, string nome, string descricao)
        {
            Codigo = codigo;
            TipoImovel = tipoImovel;
            Nome = nome;
            Descricao = descricao;
        }
    }
}
