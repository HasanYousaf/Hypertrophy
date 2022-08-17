using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Hypertrophy.Data
{
    public class ExerciseRepository
    {
        public static ObservableCollection<Exercise> _exerciseLog = new ObservableCollection<Exercise>();
        //public ExerciseRepository()
        //{
        //    _exerciseLog.Add(new Exercise("Chest", "Barbell", "Bench Press"));
        //    _exerciseLog.Add(new Exercise("Cardio", "Aerobics", "Cardio"));
        //    _exerciseLog.Add(new Exercise("Shoulders", "Dumbbell", "Arnold Press"));
        //    _exerciseLog.Add(new Exercise("Back", "Machine", "Back Extension"));
        //    _exerciseLog.Add(new Exercise("Arms", "Bodyweight", "Bench Dip"));
        //    _exerciseLog.Add(new Exercise("Core", "Duration", "Side Plank"));
        //    _exerciseLog.Add(new Exercise("Chest", "Barbell", "Bench Press"));
        //    _exerciseLog.Add(new Exercise("Full Body", "Barbell", "Clean And Jerk"));
        //    _exerciseLog.Add(new Exercise("Chest", "Cable", "Pec Fly"));
        //    _exerciseLog.Add(new Exercise("Back", "Weighted", "Pull-up"));
        //}
        public ObservableCollection<Exercise> ExerciseLog { get { return _exerciseLog; } set { _exerciseLog = value; } }

        public ObservableCollection<Exercise> AddExercise(double _exerciseReps, double _exerciseWeight, string _exerciseName)
        {
            ExerciseLog.Add(new Exercise(_exerciseReps, _exerciseWeight, _exerciseName));
            return ExerciseLog;
        }

        //public void UpdateExercise(string _bodyPart, string _category, string _exerciseName)
        //{
        //    Exercise updateExercise = _exerciseLog.FirstOrDefault(exerciseLog => exerciseLog.ExerciseName == _exerciseName);
        //    if (updateExercise == null)
        //    {
        //        updateExercise.BodyPart = _bodyPart;
        //        updateExercise.Category = _category;
        //        updateExercise.ExerciseName = _exerciseName;
        //    }
        }

    }
//}
