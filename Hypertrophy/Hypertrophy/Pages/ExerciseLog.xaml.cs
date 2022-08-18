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
    //Hasan Yousaf
    //ExerciseLog displays Exercise objects stored in ObservableCollection _exerciseLog.
    //When AddExercise button is clicked, it opens popup ExerciseAdder to continue process to add Exercise.
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExerciseLog : ContentPage
    {
        ExerciseRepository exerciseRepo = new ExerciseRepository();
        public ExerciseLog()
        {
            InitializeComponent();
            Exercise.ItemsSource = ExerciseRepository._exerciseLog;
        }


        private void AddExercise_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new ExerciseAdder());
        }
    }
}