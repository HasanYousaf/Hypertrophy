﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hypertrophy.Data
{
    //Hasan Yousaf
    //Exercise class initalizes Exercise object along with string override method to display Exercise in ListView.
    //Exercise data is entered through public variables and set into private variables from there.
    public class Exercise
    {
        private double _exerciseReps;
        private double _exerciseWeight;
        private string _exerciseName;
        public double ExerciseReps { get { return _exerciseReps; } set { _exerciseReps = value; } }
        public double ExerciseWeight { get { return _exerciseWeight; } set { _exerciseWeight = value; } }
        public string ExerciseName { get { return _exerciseName; } set { _exerciseName = value; } }

        public Exercise(double _exerciseReps, double _exerciseWeight, string _exerciseName)
        {
            ExerciseReps = _exerciseReps;
            ExerciseWeight = _exerciseWeight;
            ExerciseName = _exerciseName;
        }

        public override string ToString()
        {
            return $"{_exerciseName} || Weight: {_exerciseWeight} || Reps: {_exerciseReps}";
        }

    }
}
