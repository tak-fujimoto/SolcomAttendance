using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SolcomAttendance
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnClickEvent(object sender, EventArgs e)
        {
            // クラスのインスタンスを作成
            LoginUtil loginUtil = new LoginUtil();

            // getterに設定する
            loginUtil.username = username.Text;

            // getter「loginUtil.username」を引数に
            // LoginUtilクラスのCustomUserNameメソッドを呼び出し
            // 戻り値を変数「name」に格納する
            string name = loginUtil.CustomUserName(loginUtil.username);

            // 変数「name」を引数に勤怠画面に遷移する
            // ※この変数「name」がアカウント名として表示される
            Navigation.PushModalAsync(new Page1(loginUtil.username));
        }
    }
}
