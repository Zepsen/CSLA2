using BusinessLibrary.Repo;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;
using XamarinForm.UWP;
using SQLite;
using System;

[assembly: Dependency(typeof(SQLite_UWP))]
namespace XamarinForm.UWP
{
    public class SQLite_UWP : ISQLite
    {
        public SQLite_UWP() { }
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "employeer.db";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }      
    }
}
