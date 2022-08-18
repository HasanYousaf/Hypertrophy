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
    //Hasan Yousaf
    //FoodAdder page is opened from NutritionLog via AddFood button.
    //When LogFood button is clicked, AddFood method is used to add Food object to ObservableCollection FoodLog from where it is stored in static _foodLog.
    //In lieu of DisplayAlert, FoodAdderError populates when input is invalid to let the user know to check their values.
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
            try
            {
                string foodNameInput = FoodNameInput.Text;
                double foodCaloriesInput = double.Parse(FoodCaloriesInput.Text);
                double foodProteinInput = double.Parse(FoodProteinInput.Text);
                double foodFatInput = double.Parse(FoodFatInput.Text);
                double foodCarbInput = double.Parse(FoodCarbInput.Text);

                foodRepo.AddFood(foodCaloriesInput, foodNameInput, foodProteinInput, foodFatInput, foodCarbInput);

                FoodAdderPopup.Dismiss(_foodLog);
            }
            catch (Exception)
            {
                FoodAdderError.Text = "Invalid Input! Please ensure all fields are filled correctly!";
            }
        }
    }
}