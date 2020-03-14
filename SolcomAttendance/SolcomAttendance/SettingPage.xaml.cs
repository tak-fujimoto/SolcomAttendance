using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolcomAttendance
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        readonly AttendanceRepository _db = new AttendanceRepository();

        //参照設定
        Setting Setting;
        // 2020/03/14 武藤 ユーザー名の表示 STR
        //public SettingPage()
        public SettingPage(string name)
        // 2020/03/14 武藤 ユーザー名の表示 STR
        {
            InitializeComponent();

            Setting = new Setting(new SettingMaster());
            TimesStack.BindingContext = Setting;

            // 2020/03/14 武藤 ユーザー名の表示 STR
            ////DB取得_page1のname？SettingMasterのusername?
            // 勤怠画面から渡されたユーザー名の情報を設定し、表示する。
            label.Text = name;
            // 2020/03/14 武藤 ユーザー名の表示 END
        }

        private  void SettingButtonClicked(object sender, EventArgs args)
        {
            //変換
            Setting.UpdateSettingValue();

            //入力された情報をDBに書き込み
            _db.SaveItem_SettingMaster(Setting.Value);

            // ログイン画面へ遷移
            this.Navigation.PopModalAsync();
        }

        private void CancelButtonClicked(object sender, EventArgs args)
        {
            // ログイン画面へ遷移
            this.Navigation.PopModalAsync();
        }
    }
}