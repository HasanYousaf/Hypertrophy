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
            try
            {
                double height = double.Parse(HeightInput.Text);
                double weight = double.Parse(WeightInput.Text);
                double age = double.Parse(AgeInput.Text);
                ActivityLevel activityLevel = (ActivityLevel)(ActivityLevelPicker.SelectedItem);
                Sex sex = (Sex)(SexPicker.SelectedItem);
                WeightUnit weightUnit = (WeightUnit)(WeightUnitPicker.SelectedItem);
                HeightUnit heightUnit = (HeightUnit)(HeightUnitPicker.SelectedItem);
                if (height > 1 && weight > 1 && age > 1)
                {
                    double tdee = calculator.GetTDEE(heightUnit, weightUnit, sex, height, weight, age, activityLevel);
                    TDEE.Text = $"Your TDEE is {tdee}";
                }
                else if (height < 1)
                    DisplayAlert("Invalid Input!", "Height cannot be less than 1!", "ok");
                else if (weight <= 0)
                    DisplayAlert("Invalid Input!", "Weight cannot be less than 0", "ok");
                else if (age < 1)
                    DisplayAlert("Invalid Input!", "Age cannot be less than 1!", "ok");

            }
            catch (Exception)
            {
                DisplayAlert("Invalid Input!", "Ensure all fields are filled correctly", "ok");
            }
        }

        private void Calculate1RM_Clicked(object sender, EventArgs e)
        {
            try
            {
                double repWeight = double.Parse(RepWeightInput.Text);
                double numReps = double.Parse(NumRepInput.Text);
                if (repWeight > 0 && numReps >= 0)
                {
                    double oneRepMax = calculator.GetOneRepMax(repWeight, numReps);
                    OneRepMax.Text = $"Your one rep max is {oneRepMax}";
                }
                else if (repWeight < 1)
                {
                    DisplayAlert("Invalid Input", "Weight cannot be less than 1!", "ok");
                }
                else if (numReps < 1)
                {
                    DisplayAlert("Invalid Input", "Reps cannot be less than 1!", "ok");
                }
            }
            catch (Exception)
            {
                DisplayAlert("Invalid Input", "Please ensure all fields are filled correctly", "ok");
            }
                
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
            try
            {
                double calorieInput = double.Parse(TDEEInput.Text);
                if (calorieInput > 0)
                {
                    if (ProteinStepper.Value + FatStepper.Value + CarbStepper.Value == 100)
                    {
                        double proteinPercentage = ProteinStepper.Value / 100;
                        double fatPercentage = FatStepper.Value / 100;
                        double carbPercentage = CarbStepper.Value / 100;
                        double gramsProtein = calculator.GetProtein(calorieInput, proteinPercentage);
                        double gramsFat = calculator.GetFat(calorieInput, fatPercentage);
                        double gramsCarb = calculator.GetCarb(calorieInput, carbPercentage);
                        GramsProtein.Text = $"{gramsProtein} grams of Protein";
                        GramsFat.Text = $"{gramsFat} grams of Fat";
                        GramsCarb.Text = $"{gramsCarb} grams of Carbs";
                    }
                    else
                        DisplayAlert("Invalid Input", "Your macro percentages must add to 100!", "ok");
                }
                else
                    DisplayAlert("Invalid Input", "Calories cannot be below 1", "ok");
            } catch (Exception)
            {
                DisplayAlert("Invalid Input", "Please ensure all fields are filled correctly", "ok");
            }
        }
    }
}