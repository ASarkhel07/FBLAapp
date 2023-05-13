using FBLAapp.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var loggedin = true;
            if (loggedin)
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            //await Navigation.PushAsync(new AboutPage(), true);
            App.myConstants.name = UserName_LoginPage.Text;

        }

        private async void RegisterButton_Clicked(object sender, EventArgs e )
        {
            await Shell.Current.GoToAsync($"//{nameof(Page3)}"); //registration page
        }
    }
}