using Hypertrophy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hypertrophy.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseLog : ContentPage
    {
        ExerciseRepository exerciseRepo = new ExerciseRepository();
        public ExerciseLog()
        {
            InitializeComponent();
            AddExerciseExamples();
            Exercise.ItemsSource = ExerciseRepository._exerciseLog;
        }


        private void AddExerciseExamples()
        {
            exerciseRepo.AddExercise(6, 135, "Barbell Bench Press");
            exerciseRepo.AddExercise(8, 185, "Barbell Deadlift");
            exerciseRepo.AddExercise(10, 50, "Dumbbell Shoulder Press");
            exerciseRepo.AddExercise(6, 135, "Barbell Bent-Over Row");
        }
        private void Exercise_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Exercise exerciseSelection = Exercise.SelectedItem as Exercise;

        }

        private void AddExercise_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new ExerciseAdder());
        }
    }
}