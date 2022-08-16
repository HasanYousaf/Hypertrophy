using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Hypertrophy.Data
{
    public class ExerciseRepository
    {
        ObservableCollection<Exercise> _exerciseLog = new ObservableCollection<Exercise>();
        public ExerciseRepository()
        {
            _exerciseLog.Add(new Exercise("Chest", "Barbell", "Bench Press"));
            _exerciseLog.Add(new Exercise("Cardio", "Aerobics", "Cardio"));
            _exerciseLog.Add(new Exercise("Shoulders", "Dumbbell", "Arnold Press"));
            _exerciseLog.Add(new Exercise("Back", "Machine", "Back Extension"));
            _exerciseLog.Add(new Exercise("Arms", "Bodyweight", "Bench Dip"));
            _exerciseLog.Add(new Exercise("Core", "Duration", "Side Plank"));
            _exerciseLog.Add(new Exercise("Chest", "Barbell", "Bench Press"));
            _exerciseLog.Add(new Exercise("Full Body", "Barbell", "Clean And Jerk"));
            _exerciseLog.Add(new Exercise("Chest", "Cable", "Pec Fly"));
            _exerciseLog.Add(new Exercise("Back", "Weighted", "Pull-up"));

        }
    }
}
