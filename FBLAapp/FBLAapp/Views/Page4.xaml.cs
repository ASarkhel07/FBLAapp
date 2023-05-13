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
    public partial class Page4 : ContentPage
    {
        private int rank=0;
        public Page4()
        {
            InitializeComponent();
        }
        async void UserRanking_Clicked(object sender, EventArgs e)
        {
            if(App.myConstants.pointspoints==30)
            {   
                rank=1;
                await DisplayAlert("Great Job!", "Your Ranking: " + rank, "Continue");
            }
            if(App.myConstants.pointspoints==29)
            {   
                rank=2;
                await DisplayAlert("Great Job!", "Your Ranking: " + rank, "Continue");
            }
            if(App.myConstants.pointspoints==28)
            {   
                rank=3;
                await DisplayAlert("Great Job!", "Your Ranking: " + rank, "Continue");
            }
            if(App.myConstants.pointspoints==27)
            {   
                rank=4;
                await DisplayAlert("Great Job!", "Your Ranking: " + rank, "Continue");
            }
            if(App.myConstants.pointspoints<=26)
            {   
                rank=5;
                await DisplayAlert("Great Job!", "Your Ranking: " + rank, "Continue");
            }
        }

        private async void TapGestureRecognizerQuaterlyReport_Tapped(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(1,5);

            if(num==1)
            {
                await DisplayAlert("Quarterly Winners", "Grade 9: Dave Smith, Grade 10: Armaan Sarkhel, Grade 11: Roger Wayne, Grade 12: Bruce Harris", "Continue");
            }
            if(num==2)
            {
                await DisplayAlert("Quarterly Winners", "Grade 9: John Adam, Grade 10: Ganeshan Venu, Grade 11: Roger Wayne, Grade 12: Bruce Harris", "Continue");
            }
            if(num==3)
            {
                await DisplayAlert("Quarterly Winners", "Grade 9: John Adam, Grade 10: Armaan Sarkhel, Grade 11: Roger Wayne, Grade 12: Bruce Harris", "Continue");
            }
            if(num==4)
            {
                await DisplayAlert("Quarterly Winners", "Grade 9:  Dave Smith, Grade 10: Ganeshan Venu, Grade 11: Roger Wayne, Grade 12: Bruce Harris", "Continue");
            }




        }
    }
}