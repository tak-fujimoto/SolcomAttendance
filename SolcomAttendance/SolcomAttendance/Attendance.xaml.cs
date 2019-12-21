using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamForms.Controls;

namespace SolcomAttendance
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        readonly AttendanceRepository _db = new AttendanceRepository();
        Monthly NowMonth;
        DisplayDay NowDay;

        public Page1(string name)
        {
            InitializeComponent();

            NowMonth = new Monthly(DateTime.Now);
            NowDay = new DisplayDay(NowMonth.GetDay(DateTime.Now));

            label.Text = name;
            SelectedDay.BindingContext = NowDay;
        }

        private void OnDateClickHandler(object sender, DateTimeEventArgs e)
        {
            var ClickedDay = NowMonth.GetDay(e.DateTime);

            NowDay.ChangeDay(ClickedDay);
        }

        /// <summary>
        /// 設定ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SettingButtonClicked(object sender, EventArgs args)
        {
            // 設定画面へ遷移
            this.Navigation.PushModalAsync(new SettingPage());
        }

        /// <summary>
        /// ログアウトボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void LogoutButtonClicked(object sender, EventArgs args)
        {
            // ログイン画面へ遷移
            this.Navigation.PopModalAsync();
        }

        /// <summary>
        /// 登録ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void RegisterButtonClicked(object sender, EventArgs args)
        {
            // 設定画面へ遷移
            // TODO STR
            NowDay.UpdateTime();

            // DBに勤怠データを書き込む
            _db.SaveItem(NowDay.Day);
            var a = _db.GetItems();
            // TODO END
        }

        /// <summary>
        /// 有給スイッチON時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPaidToggled(object sender, ToggledEventArgs e)
        {
            // 有給スイッチがONになった場合に備考欄に「有給休暇」を入力
            // TODO STR
            // TODO END
        }
    }
}