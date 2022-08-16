using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Hypertrophy.Data
{
    public enum ActivityLevel
    {
        Sedentary,
        LightlyActive,
        ModeratelyActive,
        VeryActive,
        ExtremelyActive
    }
    public enum Sex
    {
        Male,
        Female
    }
    public enum WeightUnit
    {
        Pounds,
        Kilograms
    }
    public enum RepWeight
    {
        Pounds,
        Kilograms
    }
    public enum HeightUnit
    {
        Centimeter,
        Inch
    }
    public class Calculator
    {
        private double _calories;
        private double _protein;
        private double _proteinPercentage;
        private double _carbPercentage;
        private double _fatPercentage;
        private double _carb;
        private double _fat;
        private double _height;
        private double _weight;
        private double _age;
        private double _repWeight;
        private double _numReps;
        private double _oneRepMax;
        private ActivityLevel _activityLevel;
        private Sex _sex;
        private double _tdee;
        private WeightUnit _weightUnit;
        private HeightUnit _heightUnit;
        private double _heightModifier;
        private double _weightModifier;
        private double _activityLevelModifier;
        public double Calories { get { return _calories; } set { _calories = value; } }
        public double Protein { get { return _protein; } set { _protein = value; } }
        public double ProteinPercentage { get { return _proteinPercentage; } set { _proteinPercentage = value; } }
        public double CarbPercentage { get { return _carbPercentage; } set { _carbPercentage = value; } }
        public double FatPercentage { get { return _fatPercentage; } set { _fatPercentage = value; } }
        public double Carb { get { return _carb; } set { _carb = value; } }
        public double Fat { get { return _fat; } set { _fat = value; } }
        public double Height { get { return _height; } set { _height = value; } }
        public double Weight { get { return _weight; } set { _weight = value; } }
        public double Age { get { return _age; } set { _age = value; } }
        public double RepWeight { get { return _repWeight; } set { _repWeight = value; } }
        public double NumReps { get { return _numReps; } set { _numReps = value; } }
        public double OneRepMax { get { return _oneRepMax; } set { _oneRepMax = value; } }
        public ActivityLevel ActivityLevel { get { return _activityLevel; } set { _activityLevel = value; } }
        public Sex Sex { get { return _sex; } set { _sex = value; } }
        public double TDEE { get { return _tdee; } set { _tdee = value; } }
        public WeightUnit WeightUnit { get { return _weightUnit; } set { _weightUnit = value; } }
        public HeightUnit HeightUnit { get { return _heightUnit; } set { _heightUnit = value; } }
        public double HeightModifier { get { return _heightModifier; } set { _heightModifier = value; } }
        public double WeightModifier { get { return _weightModifier; } set { _weightModifier = value; } }
        public double ActivityLevelModifier { get { return _activityLevelModifier; } set { _activityLevelModifier = value; } }

        public double GetHeightModifier(HeightUnit _heightUnit)
        {
            _heightModifier = 1;

            if (_heightUnit == HeightUnit.Inch)
                _heightModifier = 2.54;

            return _heightModifier;
        }

        public double GetWeightModifier(WeightUnit _weightUnit, double _weightModifier)
        {
            _weightModifier = 1;

            if (_weightUnit == WeightUnit.Pounds)
                _weightModifier = (1 / 2.2);

            return _weightModifier;
        }

        public double GetTDEE(HeightUnit _heightUnit, WeightUnit _weightUnit, Sex _sex, double _height, double _weight, double _age, ActivityLevel _activityLevel)
        {
            double bmr;
            _heightModifier = GetHeightModifier(_heightUnit);
            _weightModifier = GetWeightModifier(_weightUnit, _weightModifier);

            switch (_activityLevel)
            {
                case ActivityLevel.LightlyActive:
                    _activityLevelModifier = 1.375;
                    break;
                case ActivityLevel.ModeratelyActive:
                    _activityLevelModifier = 1.55;
                    break;
                case ActivityLevel.VeryActive:
                    _activityLevelModifier = 1.725;
                    break;
                case ActivityLevel.ExtremelyActive:
                    _activityLevelModifier = 1.9;
                    break;
                default:
                    _activityLevelModifier = 1.2;
                    break;

            }

            if (_sex == Sex.Female)
            {
                bmr = 655 + (9.6 * _weight * _weightModifier) + (1.8 * _height * _heightModifier) - (4.7 * _age);
                _tdee = bmr * _activityLevelModifier;
            }
            
            bmr = 66 + (13.7 * _weight * _weightModifier) + (5 * _height * _heightModifier) - (6.8 * _age);
            _tdee = bmr * _activityLevelModifier;


            return _tdee;
        }

        public double GetOneRepMax(double _repWeight, double _numReps)
        {
            _oneRepMax = _repWeight  * (1 + (_numReps / 30));

            return _oneRepMax;
        }

        public double GetProtein(double _calories, double _proteinPercentage)
        {
            double proteinCalories = _calories * _proteinPercentage;
            _protein = proteinCalories / 4;
            return _protein;
        }
        public double GetFat(double _calories, double _fatPercentage)
        {
            double fatCalories = _calories * _fatPercentage;
            _fat = fatCalories/8;
            return _fat;
        }
        public double GetCarb(double _calories, double _carbPercentage)
        {
            double carbCalories = _calories * _carbPercentage;
            _carb = carbCalories/4;
            return _carb;
        }


    }
}
