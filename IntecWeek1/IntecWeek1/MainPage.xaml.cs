using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntecWeek1
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

        //void OpenBotton(object obj, EventArgs clicked)
        //{
        //    var button = (Button)obj;
        //    cc.Text = aa.Text;
        //    cc.TextColor = button.BackgroundColor;
        //}
       async void ColorChanger(object obj, EventArgs evento)
        {
            var button = (Button)obj;
            Nombre.Text = Entrada.Text;
            Nombre.TextColor = button.BackgroundColor;
            await Navigation.PushAsync(new MyNewPage(button.BackgroundColor, button.Text));
            
        }
        
        
    }
}
