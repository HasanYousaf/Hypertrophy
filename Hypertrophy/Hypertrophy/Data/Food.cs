using System;
using System.Collections.Generic;
using System.Text;

namespace Hypertrophy.Data
{
    public class Food
    {
        private double _foodCalories;
        private string _foodName;
        private double _foodProtein;
        private double _foodFat;
        private double _foodcarb;
        public double FoodCalories { get { return _foodCalories; } set { _foodCalories = value; } }
        public string FoodName { get { return _foodName; } set { _foodName = value; } }
        public double FoodProtein { get { return _foodProtein; } set { _foodProtein = value; } }
        public double FoodFat { get { return _foodFat; } set { _foodFat = value; } }
        public double FoodCarb { get { return _foodcarb; } set { _foodcarb = value; } }

        public Food(double _foodCalories, string _foodName, double _foodProtein, double _foodFat, double _foodcarb)
        {
            FoodCalories = _foodCalories;
            FoodName = _foodName;
            FoodProtein = _foodProtein;
            FoodFat = _foodFat;
            FoodCarb = _foodcarb;
        }

        public override string ToString()
        {
            return string.Format("Food Calories: {0}, Food Name: {1}, Food Protein: {2}, Food Fat: {3}, Food Carb: {4}", FoodCalories, FoodName, FoodProtein, FoodFat, FoodCarb);
        }
    }
}
