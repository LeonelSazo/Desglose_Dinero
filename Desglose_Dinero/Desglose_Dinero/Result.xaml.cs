using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Desglose_Dinero
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Result : ContentPage
    {
        public Result()
        {
            InitializeComponent();
        }


        private void Calcular_Clicked(object sender, EventArgs e)
        {
            var CAN_Mda = Decimal.Parse(Cant.Text);
            int M50, M25, M10, M5, M1;
            M50 = M25 = M10 = M5 = M1 = 0;
            var CAN = 0;
            CAN = Convert.ToInt32(Math.Truncate(CAN_Mda));

            int B200, B100, B50, B20, B10, B5;
            B200 = B100 = B50 = B20 = B10 = B5 = 0;
            CAN_Mda = (CAN_Mda - CAN) * 100;


            //Inicio de la operación de billetes
            if ((CAN >= 200))
            {
                B200 = (CAN / 200);
                CAN = CAN - (B200 * 200);
            }
            if ((CAN >= 100))
            {
                B100 = (CAN / 100);
                CAN = CAN - (B100 * 100);
            }
            if ((CAN >= 50))
            {
                B50 = (CAN / 50);
                CAN = CAN - (B50 * 50);
            }
            if ((CAN >= 20))
            {
                B20 = (CAN / 20);
                CAN = CAN - (B20 * 20);
            }
            if ((CAN >= 10))
            {
                B10 = (CAN / 10);
                CAN = CAN - (B10 * 10);
            }
            if ((CAN >= 5))
            {
                B5 = (CAN / 5);
                CAN = CAN - (B5 * 5);
            }


            //Inicio Calculo monedas
            if ((CAN_Mda >= 50))
            {
                M50 = ((int)(CAN_Mda / 50));            //Se le agrega el int ya que no se puede reallizar la operacion explicita de decimal a entero
                CAN_Mda = (CAN_Mda - (M50 * 50)); //Y al colocarle el int se vuelve en una operacion implicita

            }
            if ((CAN_Mda >= 25))
            {
                M25 = ((int)(CAN_Mda / 25));
                CAN_Mda = (CAN_Mda - (M25 *25));

            }
            if ((CAN_Mda >= 10))
            {
                M10 = ((int)(CAN_Mda / 10));
                CAN_Mda = (CAN_Mda - (M10 * 10));
            }
            if ((CAN_Mda >= 5))
            {
                M5 = ((int)(CAN_Mda / 5));
                CAN_Mda = ((int)(CAN_Mda - (M5 * 5)));

            }
            if ((CAN_Mda >= 1))
            {
               M1 = ((int)(CAN_Mda / 1));
                CAN_Mda = (CAN_Mda - (M1 * 1));

            }
            DisplayAlert("Desglose de Monedas", $"Monedas de Q0.50: {M50} \n Monedas de Q0.25: {M25}\n Monedas de Q0.10: {M10}\n Monedas de Q0.05: {M5}\n Monedas de Q0.01: {M1}", "Continuar");


            DisplayAlert("Desglose Billetes", $"Billetes de Q200:{B200} \n Billestes de Q100: {B100}\n Billetes de Q50: {B50} \n Billetes de Q20: {B20}" +
                $" \n Billetes de Q10: {B10}\n Billetes de Q5: {B5} \n Billetes de Q1: {CAN}", "Continuar para ver monedas");
        }

       

    }
}