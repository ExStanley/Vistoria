using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Vistoria.Modelo
{
    public class Pergunta
    {
        [PrimaryKey, AutoIncrement]
        public int PerguntaId { get; set; }
        public string Descricao { get; set; }
        public int Resposta { get; set; }

        //[ForeignKey(typeof(Formulario))]
        public int? FormularioId { get; set; }

        //[ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        //public Formulario Formulario { get; set; }
        public Pergunta(){}
        public Pergunta(string descricao, int resposta)
        {
            Descricao = descricao;
            Resposta = resposta;
        }
        public Pergunta(int id, string descricao)
        {
            PerguntaId = id;
            Descricao = descricao;
        }
    }
}
