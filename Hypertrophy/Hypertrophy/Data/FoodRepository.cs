using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Hypertrophy.Data
{
    //Hasan Yousaf
    //FoodRepository is used to hold a static ObservableCollection called _foodLog along with the method for adding to _foodLog.
    //This is done by having the AddFood method return the Food object to a non-static ObservableCollection FoodLog.
    //FoodLog returns the added Food object to static _foodLog.
    public class FoodRepository
    {
        public static ObservableCollection<Food> _foodLog = new ObservableCollection<Food>();

        public ObservableCollection<Food> AddFood(double _foodCalories, string _foodName, double _foodProtein, double _foodFat, double _foodCarb)
        {
            FoodLog.Add(new Food(_foodCalories, _foodName, _foodProtein, _foodFat, _foodCarb));
            return FoodLog;
        }
        public ObservableCollection<Food> FoodLog {get { return _foodLog;} set { _foodLog = value; } }

    }
    }
