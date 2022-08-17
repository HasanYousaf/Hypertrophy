using Hypertrophy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private void Exercise_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Exercise exerciseSelection = Exercise.SelectedItem as Exercise;

        }

        private void AddExercise_Clicked(object sender, EventArgs e)
        {

        }
    }
}