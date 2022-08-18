using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Hypertrophy.Data
{
    //Hasan Yousaf
    //ExerciseRepository creates static Observable Collection _exerciseLog.
    //Data is added to _exerciseLog through AddExercise method which returns Exercise object to public ExerciseLog.
    //From there it is stored in static _exerciseLog.
    public class ExerciseRepository
    {
        public static ObservableCollection<Exercise> _exerciseLog = new ObservableCollection<Exercise>();
        public ObservableCollection<Exercise> ExerciseLog { get { return _exerciseLog; } set { _exerciseLog = value; } }

        public ObservableCollection<Exercise> AddExercise(double _exerciseReps, double _exerciseWeight, string _exerciseName)
        {
            ExerciseLog.Add(new Exercise(_exerciseReps, _exerciseWeight, _exerciseName));
            return ExerciseLog;
        }
    }
}
