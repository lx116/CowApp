using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CowApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : ContentPage
    {
        private int People = 0;
        private double _Propina = 0;
        private double Bill = 0;
        private double PagoPorPersona = 0;
        public PrincipalPage()
        {
            InitializeComponent();
        }

        async void Calcular_OnClicked(object sender, EventArgs e)
        {

            Result result = new Result();
            
            if (String.IsNullOrEmpty(PeopleCount.Text))
            {
                People = 0;
            }
            else
            {
                People = Int32.Parse(PeopleCount.Text);
                result.CantidadDePersonas = People;
            }

            if (String.IsNullOrEmpty(Propina.Text))
            {
                _Propina = 0;
            }
            else
            {
                _Propina = double.Parse(Propina.Text);
            }

            if (string.IsNullOrEmpty(BillCount.Text))
            {
                Bill = 0;
            }
            else
            {
                Bill = double.Parse(BillCount.Text);
            }
            
            if (_Propina > 0)
            {
                double tryTest = Bill + (Bill * (_Propina / 100));
                
                result.CuentaConPropina = tryTest;
                
                PagoPorPersona = tryTest / People;
                
                result.Propina = Bill * (_Propina / 100);
                result.PagoPorPersonasPropina = result.Propina / People;
            }
            else
            {
                PagoPorPersona = Bill / People;
            }
            
            result.Cuenta = Bill;
            result.CantidadDePersonas = People;
            result.PagoPorPersonas = PagoPorPersona;
            
            
            await Navigation.PushAsync(new ResultView(result));

        }
        
    }
}