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
        public SettingPage()
        {
            InitializeComponent();
        }

        private async void SettingButtonClicked(object sender, EventArgs args)
        {
            // とりあえずログイン画面へ遷移
            await this.Navigation.PushModalAsync(new MainPage());
        }
    }
}