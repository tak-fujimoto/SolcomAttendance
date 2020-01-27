using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;

namespace SolcomAttendance
{
    public class AttendanceRepository
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

        // 初期取得
        public List<AttendanceMaster> GetMonth(string UserName, DateTime ArgTargetMonth)
        {
            lock (Locker)
            {
                var cmd = new SQLiteCommand(_db);
                var targetMonth = new DateTime(ArgTargetMonth.Year, ArgTargetMonth.Month, 1);
                var NextMonth = targetMonth.AddMonths(1);

                cmd.CommandText = "SELECT * FROM AttendanceMaster WHERE UserID = '" + UserName + "' AND WorkDate >= Datetime('" + targetMonth.ToString().Substring(0, targetMonth.ToString().Length - 3) + "') AND WorkDate < Datetime('" + NextMonth.ToString().Substring(0, NextMonth.ToString().Length - 3) + "')";
                var ret = cmd.ExecuteQuery<AttendanceMaster>();
                return ret;
            }
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
        /// <summary>

        /// 一覧(設定画面)※全出力

        /// </summary>

        /// <returns></returns>

        public IEnumerable<SettingMaster> GetItems_SettingMaster()

        {

            lock (Locker)

            {

                return _db.Table<SettingMaster>();

            }

        }
        /// <summary>

        /// 更新・追加(設定画面)

        /// </summary>

        /// <param name="item"></param>

        /// <returns></returns>

        public int SaveItem_SettingMaster(SettingMaster item)

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
