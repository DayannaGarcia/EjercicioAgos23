using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnCalcular.Clicked += btnClicked;
		}

        private void btnClicked(object sender, EventArgs e)
        {
            double Total = double.Parse(tot.Text);
            double Propina = double.Parse(prop.Text);
            double NumeroPersona = double.Parse(numPer.Text);

            double ResPropina = (Total*Propina)/100;
            double ResTotal = ResPropina + Total;
            double ResPropPersona = ResPropina / NumeroPersona;
            double ResTotPersona = ResTotal / NumeroPersona;

            txtPropina.Detail = Propina.ToString("C");
            txtTotal.Detail = ResTotal.ToString("C");
            txtPropinaPer.Detail = ResPropPersona.ToString("C");
            txtTotalPer.Detail = ResTotPersona.ToString("C");
        }
    }
}
