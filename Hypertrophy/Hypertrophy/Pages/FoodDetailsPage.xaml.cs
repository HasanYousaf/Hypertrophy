using Hypertrophy.Data;
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
    public partial class FoodDetailsPage : ContentPage
    {
        public FoodDetailsPage(Food food)
        {
            InitializeComponent();
            FoodCalories.Text = $"Calories: {food.FoodCalories}";
            FoodName.Text = $"Name: {food.FoodName}";
            FoodProtein.Text = $"Protein: {food.FoodProtein}";
            FoodFat.Text = $"Fat: {food.FoodFat}";
            FoodCarb.Text = $"Carbs: {food.FoodCarb}";
        }

        private void DeleteFood_Clicked(object sender, EventArgs e)
        {

        }
    }
}