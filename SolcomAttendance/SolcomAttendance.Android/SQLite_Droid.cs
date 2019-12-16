using System;
using System.IO;
using SQLite;
using SolcomAttendance.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace SolcomAttendance.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            //データベース名を指定
            const string sqliteFilename = "SolcomAttendance.db3";

            //Documentsフォルダパスを取得
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            //DBファイルのパスを指定
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}
