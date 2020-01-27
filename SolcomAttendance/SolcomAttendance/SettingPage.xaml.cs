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
            // とりあえずログイン画面へ遷移
            //await this.Navigation.PushModalAsync(new MainPage());

            //変換_エラー出る_参照できてない
            //Setting.UpdateSettingValue();

            //入力された情報をDBに書き込み_エラー出る
            //_db.SaveItem_SettingMaster(Setting.Value);


        }
    }
}