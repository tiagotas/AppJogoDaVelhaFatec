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

        private async void Button_Clicked(object sender, EventArgs e)
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

            // Verificando se a primeira linha teve vencedor.
            if(btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlert("🏆", "O X ganhou", "OK");
                zerar();

            } else if(btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") {
                await DisplayAlert("🏆", "O O ganhou", "OK");
                zerar();
            }

            // Verificando se a segunda linha teve vencedor.
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                await DisplayAlert("🏆", "O X ganhou", "OK");
                zerar();

            }
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                await DisplayAlert("🏆", "O O ganhou", "OK");
                zerar();
            }

            // Verificando se a terceira linha teve vencedor.
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("🏆", "O X ganhou", "OK");
                zerar();

            }
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("🏆", "O O ganhou", "OK");
                zerar();
            }

            // Verificando se a primeira coluna teve vencedor.
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                await DisplayAlert("🏆", "O X ganhou", "OK");
                zerar();

            }
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("🏆", "O O ganhou", "OK");
                zerar();
            }

            // Verificando se a segunda coluna teve vencedor.
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                await DisplayAlert("🏆", "O X ganhou", "OK");
                zerar();

            }
            else if (btn11.Text == "O" && btn21.Text == "O" && btn10.Text == "O")
            {
                await DisplayAlert("🏆", "O O ganhou", "OK");
                zerar();
            }

            // Verificando se a terceira coluna teve vencedor.
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("🏆", "O X ganhou", "OK");
                zerar();

            }
            else if (btn12.Text == "O" && btn22.Text == "O" && btn12.Text == "O")
            {
                await DisplayAlert("🏆", "O O ganhou", "OK");
                zerar();
            }

            // Verificando se a diagonal teve vencedor.
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("🏆", "O X ganhou", "OK");
                zerar();

            }
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("🏆", "O O ganhou", "OK");
                zerar();
            }

            // Verificando se a diagonal 2 teve vencedor.
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                await DisplayAlert("🏆", "O X ganhou", "OK");
                zerar();

            }
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("🏆", "O O ganhou", "OK");
                zerar();
            }
        }

        void zerar()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;

            btn11.Text = "";
            btn11.IsEnabled = true;

            btn12.Text = "";
            btn12.IsEnabled = true;

            btn20.Text = "";
            btn20.IsEnabled = true;

            btn21.Text = "";
            btn21.IsEnabled = true;

            btn22.Text = "";
            btn22.IsEnabled = true;

            btn30.Text = "";
            btn30.IsEnabled = true;

            btn31.Text = "";
            btn31.IsEnabled = true;

            btn32.Text = "";
            btn32.IsEnabled = true;
        }
    }
}
