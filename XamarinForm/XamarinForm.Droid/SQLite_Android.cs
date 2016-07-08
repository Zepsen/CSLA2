using System;
using Android.OS;
using Xamarin.Forms;
using System.IO;
using BusinessLibrary.Repo;
using XamarinForm.Droid;

[assembly: Dependency(typeof(SQLite_Android))]
namespace XamarinForm.Droid
{

    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "employeer.db";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }

}