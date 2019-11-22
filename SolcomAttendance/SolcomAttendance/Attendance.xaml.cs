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
    }
}