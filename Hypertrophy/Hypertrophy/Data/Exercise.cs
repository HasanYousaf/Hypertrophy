using System;
using System.Collections.Generic;
using System.Text;

namespace Hypertrophy.Data
{
    //public enum ExerciseCategory
    //{
    //    Barbell,
    //    Dumbbell,
    //    Machine,
    //    Cable,
    //    Weighted,
    //    Bodyweight,
    //    AssistedBodyweight,
    //    RepsOnly,
    //    Cardio,
    //    Duration,
    //    Other
    //}

    //public enum BodyPart
    //{
    //    Core,
    //    Arms,
    //    Back,
    //    Chest,
    //    Legs,
    //    Shoulders,
    //    Olympic,
    //    FullBody,
    //    Cardio,
    //    Other
    //}
    public class Exercise
    {
        private string _bodyPart { get; set; }
        private string _category { get; set; }
        private string _exerciseName { get; set; }
        public string BodyPart { get { return _bodyPart; } set { _bodyPart = value; } }
        public string Category { get { return _category; } set { _category = value; } }
        public string ExerciseName { get { return _exerciseName; } set { _exerciseName = value; } }

        public Exercise(string _bodyPart, string _category, string _exerciseName)
        {
            BodyPart = _bodyPart;
            Category = _category;
            ExerciseName = _exerciseName;
        }

    }
}
