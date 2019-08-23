using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntecWeek1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyNewPage : ContentPage
    {
        public MyNewPage(Color color, string text )
        {
            InitializeComponent();
            this.BackgroundColor = color;
            LabelNew.Text = text;
            
        }

    }
}