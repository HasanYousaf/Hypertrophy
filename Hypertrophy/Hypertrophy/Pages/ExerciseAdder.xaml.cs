using Hypertrophy.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hypertrophy.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ExerciseAdder : Popup
    {
        ObservableCollection<Exercise> _exerciseLog = new ObservableCollection<Exercise>();
        ExerciseRepository exerciseRepo = new ExerciseRepository();
        public ExerciseAdder()
        {
            InitializeComponent();
            _exerciseLog = exerciseRepo.ExerciseLog;
        }

        private void LogExercise_Clicked(object sender, EventArgs e)
        {
            try
            {
                string exerciseNameInput = ExerciseNameInput.Text;
                double exerciseRepsInput = double.Parse(ExerciseRepsInput.Text);
                double exerciseWeightInput = double.Parse(ExerciseWeightInput.Text);
                exerciseRepo.AddExercise(exerciseRepsInput, exerciseWeightInput, exerciseNameInput);
                ExerciseAdderPopup.Dismiss(_exerciseLog);
            }
            catch (Exception)
            {
                ExerciseAdderError.Text = "Invalid Input! Please ensure all fields are entered correctly!";
            }
                
        }
    }
}