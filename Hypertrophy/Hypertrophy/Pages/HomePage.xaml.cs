using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hypertrophy.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void NutritionLog_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NutritionLog());
        }

        private void Calculator_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalculatorPage());
        }
    }
}