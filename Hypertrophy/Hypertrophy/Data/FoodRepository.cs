using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Hypertrophy.Data
{
    public class FoodRepository
    {
        ObservableCollection<Food> _foodLog = new ObservableCollection<Food>();

        public FoodRepository()
        {
            _foodLog.Add(new Food(414, "Chicken Stir-Fry", 39.1, 3.3, 57.8));
            _foodLog.Add(new Food(519, "Turkey Burger", 33.5, 20.1, 48.2));
            _foodLog.Add(new Food(779, "Pan Pizza", 31.3, 27, 95.9));
            _foodLog.Add(new Food(130, "Milk 2% 1 Cup", 8, 12, 5));
            _foodLog.Add(new Food(70, "1 Large Egg", 6, 5, 0));
        }
        public Food AddFood(double _foodCalories, string _foodName, double _foodProtein, double _foodFat, double _foodCarb)
        {
            _foodLog.Add(new Food(_foodCalories, _foodName, _foodProtein, _foodFat, _foodCarb));
            return null;
        }

        public void UpdateFood(double _foodCalories, string _foodName, double _foodProtein, double _foodFat, double _foodCarb)
        {
            Food update = _foodLog.FirstOrDefault(foodLog => foodLog.FoodName == _foodName);
            if (update != null)
            {
                update.FoodCalories = _foodCalories;
                update.FoodName = _foodName;
                update.FoodProtein = _foodProtein;
                update.FoodFat = _foodFat;
                update.FoodCarb = _foodCarb;
            }
        }

        public ObservableCollection<Food> FoodLog => _foodLog;

        public void RemainingForDay(ObservableCollection<Food> FoodLog, double _calories)
        {
            double totalFoodCalories = 0;
            foreach (Food food in FoodLog)
            {
                totalFoodCalories += food.FoodCalories;
            }

        }
    }
}
