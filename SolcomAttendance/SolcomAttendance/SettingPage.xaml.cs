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

        public SettingPage()
        {
            InitializeComponent();

            Setting = new Setting(new SettingMaster());
            TimesStack.BindingContext = Setting;

            //DB取得_page1のname？SettingMasterのusername?

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