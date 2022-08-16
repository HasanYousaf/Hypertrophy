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
    public partial class CalculatorPage : TabbedPage
    {
        Calculator calculator = new Calculator();
        public CalculatorPage()
        {
            InitializeComponent();
            ActivityLevelPicker.ItemsSource = Enum.GetValues(typeof(ActivityLevel));
            SexPicker.ItemsSource = Enum.GetValues(typeof(Sex));
            WeightUnitPicker.ItemsSource = Enum.GetValues(typeof(WeightUnit));
            HeightUnitPicker.ItemsSource = Enum.GetValues(typeof(HeightUnit));
        }

        private void CalculateTDEE_Clicked(object sender, EventArgs e)
        {
            double height = double.Parse(HeightInput.Text);
            double weight = double.Parse(WeightInput.Text);
            double age = double.Parse(AgeInput.Text);
            ActivityLevel activityLevel = (ActivityLevel)(ActivityLevelPicker.SelectedItem);
            Sex sex = (Sex)(SexPicker.SelectedItem);
            WeightUnit weightUnit = (WeightUnit)(WeightUnitPicker.SelectedItem);
            HeightUnit heightUnit = (HeightUnit)(HeightUnitPicker.SelectedItem);

            double tdee = calculator.GetTDEE(heightUnit, weightUnit, sex, height, weight, age, activityLevel);
            TDEE.Text = $"Your TDEE is {tdee}";
        }

        private void Calculate1RM_Clicked(object sender, EventArgs e)
        {
            double repWeight = double.Parse(RepWeightInput.Text);
            double numReps = double.Parse(NumRepInput.Text);

            double oneRepMax = calculator.GetOneRepMax(repWeight, numReps);
            OneRepMax.Text = $"Your one rep max is {oneRepMax}";
        }

        private void ProteinStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ProteinValue.Text = $"Protein: {ProteinStepper.Value}%";
        }

        private void FatStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            FatValue.Text = $"Fat: {FatStepper.Value}%";

        }

        private void CarbStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            CarbValue.Text = $"Carbs: {CarbStepper.Value}%";

        }
        private void CalculateMacros_Clicked(object sender, EventArgs e)
        {
            double calorieInput = double.Parse(TDEEInput.Text);
            double proteinPercentage = ProteinStepper.Value/100;
            double fatPercentage = FatStepper.Value/100;
            double carbPercentage = CarbStepper.Value/100;
            double gramsProtein = calculator.GetProtein(calorieInput, proteinPercentage);
            double gramsFat = calculator.GetFat(calorieInput, fatPercentage);
            double gramsCarb = calculator.GetCarb(calorieInput, carbPercentage);
            GramsProtein.Text = $"{gramsProtein} grams of Protein";
            GramsFat.Text = $"{gramsFat} grams of Fat";
            GramsCarb.Text = $"{gramsCarb} grams of Carbs";
        }
    }
}