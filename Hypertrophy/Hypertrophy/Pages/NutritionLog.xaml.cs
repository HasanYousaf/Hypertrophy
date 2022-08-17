using Hypertrophy.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hypertrophy.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NutritionLog : ContentPage
    {
        FoodRepository foodRepo = new FoodRepository();
        //ObservableCollection<Food> _foodLog = new ObservableCollection<Food>();

        public NutritionLog()
        {
            InitializeComponent();
            TotalCounter();
            Food.ItemsSource = FoodRepository._foodLog;
        }

        public void TotalCounter()
        {
            double totalCalories = 0;
            double totalProtein = 0;
            double totalFat = 0;
            double totalCarb = 0;
            foreach (Food food in FoodRepository._foodLog)
            {
                totalCalories += food.FoodCalories;
                totalProtein += food.FoodProtein;
                totalFat += food.FoodFat;
                totalCarb += food.FoodCarb;
            }
            TotalCalories.Text = $"Total calories: {totalCalories}";
            TotalProtein.Text = $"Total protein: {totalProtein}";
            TotalFat.Text = $"Total fat: {totalFat}";
            TotalCarb.Text = $"Total carbs: {totalCarb}";
        }

        private void Food_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Food foodSelection = Food.SelectedItem as Food;
            Navigation.PushAsync(new FoodDetailsPage(foodSelection));
        }

        private void AddFood_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new FoodAdder());
            
        }
    }
}