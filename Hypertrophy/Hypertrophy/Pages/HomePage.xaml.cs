using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hypertrophy.Pages
{
    //Hasan Yousaf
    //HomePage directs user to NutritionLog, Calculator, or ExerciseLog based on button clicked.
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

        private void ExerciseLog_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExerciseLog());
        }
    }
}