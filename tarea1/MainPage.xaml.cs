using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tarea1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sumar_Clicked(object sender, EventArgs e)
        
        {
           
            int n1 = Convert.ToInt32 (num1.Text);
            int n2 = Convert.ToInt32 (num2.Text);
            int suma = n1 + n2;

            DisplayAlert("El resultado es: ", suma.ToString(),"Regresar");

        }

        private void restar_Clicked(object sender, EventArgs e)
        
        {
            
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int resta = n1 - n2;

            DisplayAlert("El resultado es: ", resta.ToString(), "Regresar");

        }

        private void dividir_Clicked(object sender, EventArgs e)
        
        {
            
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int divide = n1 / n2;

            DisplayAlert("El resultado es: ", divide.ToString(), "Regresar");

        }

        private void multiplicar_Clicked(object sender, EventArgs e)
       
        {
            
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int multiplica = n1 * n2;

            DisplayAlert("El resultado es: ", multiplica.ToString(), "Regresar");

        }
    }
}