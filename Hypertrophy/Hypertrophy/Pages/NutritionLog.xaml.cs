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
            AddExamples();
            Food.ItemsSource = FoodRepository._foodLog;
            TotalCounter();
        }

        public void TotalCounter()
        {
            double totalCalories = 0;
            double totalProtein = 0;
            double totalFat = 0;
            double totalCarb = 0;
            foreach (Food food in foodRepo.FoodLog)
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

        private void AddExamples()
        {
            foodRepo.AddFood(414, "Chicken Stir-Fry", 39.1, 3.3, 57.8);
            foodRepo.AddFood(519, "Turkey Burger", 33.5, 20.1, 48.2);
            foodRepo.AddFood(779, "Pan Pizza", 31.3, 27, 95.9);
            foodRepo.AddFood(130, "Milk 2% 1 Cup", 8, 12, 5);
            foodRepo.AddFood(70, "1 Large Egg", 6, 5, 0);
        }

        private void Food_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Food foodSelection = Food.SelectedItem as Food;
            Navigation.PushAsync(new FoodDetailsPage(foodSelection));
        }

        private void AddFood_Clicked(object sender, EventArgs e)
        {
            FoodAdder foodAdder = new FoodAdder();
            Navigation.ShowPopup(foodAdder);
            Food.ItemsSource = FoodRepository._foodLog;
            TotalCounter();
            
        }
    }
}