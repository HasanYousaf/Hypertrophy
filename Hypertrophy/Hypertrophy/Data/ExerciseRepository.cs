using System;
using System.Collections.Generic;
using System.Text;

namespace Hypertrophy.Data
{
    public class ExerciseRepository
    {
        public List<Exercise> GetExercises()
        {
            return new List<Exercise>()
            {
                new Exercise
                {
                    ExerciseName = "Aerobics",
                    BodyPart = BodyPart.Cardio,
                    Category = ExerciseCategory.Cardio
                },
                new Exercise
                {
                    ExerciseName = "Arnold Press",
                    BodyPart = BodyPart.Shoulders,
                    Category = ExerciseCategory.Dumbbell
                },
                new Exercise
                {
                    ExerciseName = "Back Extension",
                    BodyPart = BodyPart.Back,
                    Category = ExerciseCategory.Bodyweight
                },
                new Exercise
                {
                    ExerciseName = "Bench Dip",
                    BodyPart = BodyPart.Arms,
                    Category = ExerciseCategory.Bodyweight
                },
                new Exercise
                {
                    ExerciseName = "Bench Press",
                    BodyPart = BodyPart.Chest,
                    Category = ExerciseCategory.Barbell
                },
                new Exercise
                {
                    ExerciseName = "Close-Grip Bench Press",
                    BodyPart = BodyPart.Chest,
                    Category = ExerciseCategory.Barbell
                },
            };
        }
    }
}
