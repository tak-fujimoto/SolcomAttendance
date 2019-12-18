using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;

namespace SolcomAttendance
{
    class AttendanceRepository
    {
        static readonly object Locker = new object();
        readonly SQLiteConnection _db;

        public AttendanceRepository()
        {
            //データベース接続
            _db = DependencyService.Get<ISQLite>().GetConnection();
            //テーブル作成
            _db.CreateTable<AttendanceMaster>();
            _db.CreateTable<SettingMaster>();
        }

        //一覧
        public IEnumerable<AttendanceMaster> GetItems()
        {
            lock (Locker)
            {
                return _db.Table<AttendanceMaster>();
            }
        }

        //更新・追加
        public int SaveItem(AttendanceMaster item)
        {
            lock (Locker)
            {
                //ID <> 0の場合は更新
                if (item.ID != 0)
                {
                    _db.Update(item);
                    return item.ID;
                }
                //追加
                return _db.Insert(item);
            }
        }
    }
}
