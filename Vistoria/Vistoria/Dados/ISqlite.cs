using SQLite;

namespace Vistoria.Dados
{
    public interface ISqlite
	{
		SQLiteConnection GetConnection();
	}
}
