using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using Vistoria.Droid;
using Vistoria.Dados;

[assembly: Dependency(typeof(SQLite_android))]
namespace Vistoria.Droid
{
    public class SQLite_android : ISqlite
    {
        public SQLite_android()
        {

        }

        public SQLiteConnection GetConnection()
        {
            var fileName = "Vistoria.db3";
            string folder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, fileName);
            var connection = new SQLiteConnection(path);
            //connection.Execute("DROP TABLE Unidade");
            return connection;
        }


    }
}
