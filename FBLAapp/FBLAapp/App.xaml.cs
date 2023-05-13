using FBLAapp.Services;
using FBLAapp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBLAapp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell(); //AppShell
            //MainPage = new NavigationPage(new AboutPage()); //Delete this in a sec
        }

        public class myConstants
        {
            public static int pointspoints=0;
            public static String name="";
            public static int gradeLevel = 0;
            public static String username = "";

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
