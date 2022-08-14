using System;
using System.Collections.Generic;
using System.Text;

namespace Hypertrophy.Data
{
        public enum ExerciseCategory
        {
            Barbell,
            Dumbbell,
            Machine,
            Cable,
            Weighted,
            Bodyweight,
            AssistedBodyweight,
            RepsOnly,
            Cardio,
            Duration,
            Other
        }

        public enum BodyPart
        {
            Core,
            Arms,
            Back,
            Chest,
            Legs,
            Shoulders,
            Olympic,
            FullBody,
            Cardio,
            Other
        }
    public class Exercise
    {
        public BodyPart BodyPart { get; set; }
        public ExerciseCategory Category { get; set; }
        public string ExerciseName { get; set; }
    }
}
