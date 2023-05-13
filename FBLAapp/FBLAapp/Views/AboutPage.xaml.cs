using System;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBLAapp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

        //Points
        /*private async void TapGestureRecognizerThree_Tapped(object sender, EventArgs e)
        {
            PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
        }*/
        //Updates Info
        private async void TapGestureRecognizerUpdateInfo_Tapped(object sender, EventArgs e)
        {
            //Grade.Text=App.myConstants.gradeLevel.ToString();
            PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
            NameHome.Text = App.myConstants.name.ToString();
            User_Name.Text = "@"+App.myConstants.username.ToString();
            //NameHome.Text = App.myConstants.name.ToString();
        }

        async void Picture_Button_Clicked(object sender, EventArgs e)
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Please pick a photo"
            });

            var stream = await result.OpenReadAsync();

            resultImage.Source = ImageSource.FromStream(() => stream);
        }

        /*async void Picture_Button_Taken_Clicked(object sender, EventArgs e)
        {
            var result = await MediaPicker.CapturePhotoAsync();

            var stream = await result.OpenReadAsync();

            resultImage.Source = ImageSource.FromStream(() => stream);
        }
        */









    }
}