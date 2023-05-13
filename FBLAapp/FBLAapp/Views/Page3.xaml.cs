using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBLAapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();

          /*var gradeList = new List<int>();
            gradeList.Add(9);
            gradeList.Add(10);
            gradeList.Add(11);
            gradeList.Add(12);

            var pick = new Picker { Title = "Select grade level", TitleColor = Color.Blue };
            pick.ItemsSource = gradeList;
          */

        }





        
        private async void CreateAccntButton_Clicked(object sender, EventArgs e)
        {
            App.myConstants.username = Username.Text;
            App.myConstants.name = NameyName.Text;
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

    }
}