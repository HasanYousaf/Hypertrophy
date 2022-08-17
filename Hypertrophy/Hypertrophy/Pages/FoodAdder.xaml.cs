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
    public partial class FoodAdder : Popup
    {
        ObservableCollection<Food> _foodLog = new ObservableCollection<Food>();
        FoodRepository foodRepo = new FoodRepository();
        public FoodAdder()
        {
            InitializeComponent();
            _foodLog = foodRepo.FoodLog;
        }

        private void LogFood_Clicked(object sender, EventArgs e)
        {
            string foodNameInput = FoodNameInput.Text;
            double foodCaloriesInput = double.Parse(FoodCaloriesInput.Text);
            double foodProteinInput = double.Parse(FoodProteinInput.Text);
            double foodFatInput = double.Parse(FoodFatInput.Text);
            double foodCarbInput = double.Parse(FoodCarbInput.Text);

            foodRepo.AddFood(foodCaloriesInput, foodNameInput, foodProteinInput, foodFatInput, foodCarbInput);

            FoodAdderPopup.Dismiss(_foodLog);
        }
    }
}