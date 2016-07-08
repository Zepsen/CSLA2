using SQLite;

namespace BusinessLibrary.Repo
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
