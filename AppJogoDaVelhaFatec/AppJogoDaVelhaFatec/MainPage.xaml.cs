using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoDaVelhaFatec
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            } else { 
                btn.Text = "O";
                vez = "X";
            }

            if(btn10.Text == "X" &&
               btn11.Text == "X" &&
               btn12.Text == "X")
            {
                DisplayAlert("🏆", "O X ganhou", "OK");
            } else if(btn10.Text == "O" &&
                      btn11.Text == "O" &&
                      btn12.Text == "O") {
                DisplayAlert("🏆", "O O ganhou", "OK");
            }
        }
    }
}
