using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using Vistoria.iOS;

[assembly: Dependency(typeof(SQLite_ios))]
namespace Vistoria.iOS
{   
	public class SQLite_ios :ISqlite
	{
		public SQLite_ios()
		{
			
		}

		public SQLiteConnection GetConnection()
		{
			var fileName = "Vistoria.db3";
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(documents, "..", "Library", fileName);

			return new SQLiteConnection(path);
		}


	}
}
