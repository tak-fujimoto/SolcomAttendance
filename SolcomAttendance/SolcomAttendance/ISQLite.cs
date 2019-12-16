using SQLite;

namespace SolcomAttendance
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
