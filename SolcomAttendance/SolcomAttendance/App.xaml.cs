using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolcomAttendance
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // 2019/07/31 武藤 メイン画面確認用 STR
            //MainPage = new MainPage();
            MainPage = new Page1();
            // 2019/07/31 武藤 メイン画面確認用 END
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
