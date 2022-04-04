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
    public partial class ResultView : ContentPage
    {
        public ResultView(Result result)
        {
            InitializeComponent();

            VTotal.Text = Convert.ToString(result.Cuenta);
            VPropina.Text = Convert.ToString(result.Propina);
            TotalPropina.Text = Convert.ToString(result.CuentaConPropina);
            Result.Text = Convert.ToString(result.PagoPorPersonas);
            PropinaPorPersona.Text = Convert.ToString(result.PagoPorPersonasPropina);
            CantidadPersonas.Text = Convert.ToString(result.CantidadDePersonas);
        }
        
    }
}