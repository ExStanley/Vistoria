using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace Vistoria.Modelo
{
    public class Unidade
    {
        [PrimaryKey, AutoIncrement]
        public int UnidadeId { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string CaminhoArquivoFoto { get; set; }
        //[OneToMany]
        //public List<Formulario> Formularios { get; set; }
        public Unidade(){}
        public Unidade(string codigo, string tipo, string descricao, string endereco, string cep)
        {
            Codigo = codigo;
            Tipo = tipo;
            Descricao = descricao;
            Endereco = endereco;
            CEP = cep;
        }
    }
}
