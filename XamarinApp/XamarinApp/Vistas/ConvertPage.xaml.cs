using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConvertPage : ContentPage
    {
        public double metros;
        public double pulgadas;
        public ConvertPage()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            metros = Convert.ToDouble(txtInput.Text);
            pulgadas = metros * 39.3701;
        }

        private async void btnVolver_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                this.Calcular();
                txtResult.Text = Convert.ToString(this.pulgadas) + " pulgadas";
            }
            else DisplayAlert("Error", "Por favor ingrese un número", "Aceptar");
        }
    }
}