using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartwebsCrossPlatform.Portable.Controls
{
    class ExpandableGrid : Grid
    {
        static readonly Thickness IconMargin = new Thickness(9, 0);

        View content;
        public View Content
        {
            get => content;
            set
            {
                content = value;
                Children.Add(value, 0, 1);
            }
        }

        Label lblDesc = new Label();
        // 画面の右に">"を表示する
        Label icon = new Label { Text = ">", Margin = IconMargin, HorizontalOptions = LayoutOptions.End };

        public string Caption
        {
            set
            {
                lblDesc.Text = value;
            }
        }

        public ExpandableGrid()
        {
            RowDefinitions = new RowDefinitionCollection {
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = 0 },
            };
            ColumnDefinitions = new ColumnDefinitionCollection {
                new ColumnDefinition { Width = GridLength.Star },
            };
            Children.Add(lblDesc, 0, 0);
            Children.Add(icon, 0, 0);
            lblDesc.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(LabelClick) });
        }

        void LabelClick()
        {
            // RowDefinitions[0]は">"のこと
            // RowDefinitions[1]は中身のこと
            if (RowDefinitions[1].Height.IsAuto)
            {
                // RowDefinitions[1](中身)の高さを0にする
                RowDefinitions[1].Height = 0;
                //ExpandableLayout.HeightRequest = 0;
                icon.Text = ">";
            }
            else
            {
                // RowDefinitions[1](中身)の高さを自動で設定する
                RowDefinitions[1].Height = GridLength.Auto;
                icon.Text = "v";
            }
        }
    }
}