using BusinessLibrary.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace BusinessLibrary.Repo
{

    class EmployeerRepo
    {
        SQLiteConnection database;

        public EmployeerRepo(string filename)
        {           
            if (Device.OS.ToString() == "Other")
            {
                database = new SQLiteConnection(filename);
            }
            else 
            {
                database = DependencyService.Get<ISQLite>().GetConnection();
            }

            database.CreateTable<Employeer>();
        }
        public IEnumerable<Employeer> GetItems()
        {

            return (from i in database.Table<Employeer>() select i).ToList();

        }
        public Employeer GetItem(int id)
        {
            return database.Get<Employeer>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Employeer>(id);
        }
        public int SaveItem(Employeer item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }

    }
}
