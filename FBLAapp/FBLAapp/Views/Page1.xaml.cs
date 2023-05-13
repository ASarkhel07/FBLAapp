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
    public partial class Page1 : ContentPage
    {
        static int points = 0;
        static int limit1 = 0;
        static int limit2 = 0;
        static int limit3 = 0;
        static int limit4 = 0;
        static int limit5 = 0;
        static int limit6 = 0;
        static int limit7 = 0;
        static int limit8 = 0;
        static int limit9 = 0;
        static int limit10 = 0;

        Boolean hasAttended = false;
        Boolean hasAttended2 = false;
        Boolean hasAttended3 = false;
        Boolean hasAttended4 = false;
        Boolean hasAttended5 = false;
        Boolean hasAttended6 = false;
        Boolean hasAttended7 = false;
        Boolean hasAttended8 = false;
        Boolean hasAttended9 = false;
        Boolean hasAttended10 = false;

        public Page1()
        {
            InitializeComponent();
        }
      

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if(hasAttended==false)
            {
                App.myConstants.pointspoints++;
                PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
                await DisplayAlert("Congrats!", "Points Earned: " + App.myConstants.pointspoints, "Continue");
                hasAttended = true;
            }
            limit1++;

            //Only Can Click Once
            if (hasAttended==true && limit1>1)
            {
                await DisplayAlert("Sorry!", "You have already attended this event", "Continue");
            }


            //Free Lunch
            if(App.myConstants.pointspoints==10)
            {
                await DisplayAlert("You win a Free Lunch!", "Lunch Pass Aquired", "Redeem");
            }

            //Homework Pass
            if(App.myConstants.pointspoints==25)
            {
                await DisplayAlert("You win a Homework Pass!", "Homework Pass Acquired", "Redeem");
            }

            //Sweatshirt
            if(App.myConstants.pointspoints==50)
            {
                await DisplayAlert("You win a SBHS Sweatshirt!", "Acquire your clothing In-Person at the school store", "Reedem");
            }
        }//=> (sender as Button).Text = "Click again!";

        async void OnButtonClicked_2(object sender, EventArgs e)
        {
            if (hasAttended2 == false)
            {
                App.myConstants.pointspoints+=2;
                PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
                await DisplayAlert("Congrats!", "Points Earned: " + App.myConstants.pointspoints, "Continue");
                hasAttended2 = true;
            }
            limit2++;

            //Only Can Click Once
            if (hasAttended2 == true && limit2 > 1)
            {
                await DisplayAlert("Sorry!", "You have already attended this event", "Continue");
           
            }
           

            //Free Lunch
            if (App.myConstants.pointspoints == 10)
            {
                await DisplayAlert("You win a Free Lunch!", "Lunch Pass Aquired", "Redeem");
            }

            //Homework Pass
            if (App.myConstants.pointspoints == 20)
            {
                await DisplayAlert("You win a Homework Pass!", "Homework Pass Acquired", "Redeem");
            }

            //Sweatshirt
            if (App.myConstants.pointspoints == 30)
            {
                await DisplayAlert("You win a SBHS Sweatshirt!", "Acquire your clothing In-Person at the school store", "Reedem");
            }

        }

        async void OnButtonClicked_3(object sender, EventArgs e)
        {
            if (hasAttended3 == false)
            {
                App.myConstants.pointspoints+=3;
                PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
                await DisplayAlert("Congrats!", "Points Earned: " + App.myConstants.pointspoints, "Continue");
                hasAttended3 = true;
            }
            limit3++;

            //Only Can Click Once
            if (hasAttended3 == true && limit3 > 1)
            {
                await DisplayAlert("Sorry!", "You have already attended this event", "Continue");

            }

            //Free Lunch
            if (App.myConstants.pointspoints == 10)
            {
                await DisplayAlert("You win a Free Lunch!", "Lunch Pass Aquired", "Redeem");
            }

            //Homework Pass
            if (App.myConstants.pointspoints == 25)
            {
                await DisplayAlert("You win a Homework Pass!", "Homework Pass Acquired", "Redeem");
            }

            //Sweatshirt
            if (App.myConstants.pointspoints == 50)
            {
                await DisplayAlert("You win a SBHS Sweatshirt!", "Acquire your clothing In-Person at the school store", "Reedem");
            }

        }

        async void OnButtonClicked_4(object sender, EventArgs e)
        {
            if (hasAttended4 == false)
            {
                App.myConstants.pointspoints+=4;
                PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
                await DisplayAlert("Congrats!", "Points Earned: " + App.myConstants.pointspoints, "Continue");
                hasAttended4 = true;
            }
            limit4++;

            //Only Can Click Once
            if (hasAttended4 == true && limit4 > 1)
            {
                await DisplayAlert("Sorry!", "You have already attended this event", "Continue");
               
            }

            //Free Lunch
            if (App.myConstants.pointspoints == 10)
            {
                await DisplayAlert("You win a Free Lunch!", "Lunch Pass Aquired", "Redeem");
            }

            //Homework Pass
            if (App.myConstants.pointspoints == 25)
            {
                await DisplayAlert("You win a Homework Pass!", "Homework Pass Acquired", "Redeem");
            }

            //Sweatshirt
            if (App.myConstants.pointspoints == 50)
            {
                await DisplayAlert("You win a SBHS Sweatshirt!", "Acquire your clothing In-Person at the school store", "Reedem");
            }

        }

        async void OnButtonClicked_5(object sender, EventArgs e)
        {
            if (hasAttended5 == false)
            {
                App.myConstants.pointspoints+=5;
                PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
                await DisplayAlert("Congrats!", "Points Earned: " + App.myConstants.pointspoints, "Continue");
                hasAttended5 = true;
            }
            limit5++;

            //Only Can Click Once
            if (hasAttended5 == true && limit5 > 1)
            {
                await DisplayAlert("Sorry!", "You have already attended this event", "Continue");
            
            }

            //Free Lunch
            if (App.myConstants.pointspoints == 10)
            {
                await DisplayAlert("You win a Free Lunch!", "Lunch Pass Aquired", "Redeem");
            }

            //Homework Pass
            if (App.myConstants.pointspoints == 25)
            {
                await DisplayAlert("You win a Homework Pass!", "Homework Pass Acquired", "Redeem");
            }

            //Sweatshirt
            if (App.myConstants.pointspoints == 50)
            {
                await DisplayAlert("You win a SBHS Sweatshirt!", "Acquire your clothing In-Person at the school store", "Reedem");
            }

        }

        async void OnButtonClicked_6(object sender, EventArgs e)
        {
            if (hasAttended6 == false)
            {
                App.myConstants.pointspoints+=1;
                PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
                await DisplayAlert("Congrats!", "Points Earned: " + App.myConstants.pointspoints, "Continue");
                hasAttended6 = true;
            }
            limit6++;

            //Only Can Click Once
            if (hasAttended6 == true && limit6 > 1)
            {
                await DisplayAlert("Sorry!", "You have already attended this event", "Continue");
            }

            //Free Lunch
            if (App.myConstants.pointspoints == 10)
            {
                await DisplayAlert("You win a Free Lunch!", "Lunch Pass Aquired", "Redeem");
            }

            //Homework Pass
            if (App.myConstants.pointspoints == 25)
            {
                await DisplayAlert("You win a Homework Pass!", "Homework Pass Acquired", "Redeem");
            }

            //Sweatshirt
            if (App.myConstants.pointspoints == 50)
            {
                await DisplayAlert("You win a SBHS Sweatshirt!", "Acquire your clothing In-Person at the school store", "Reedem");
            }

        }

        async void OnButtonClicked_7(object sender, EventArgs e)
        {
            if (hasAttended7 == false)
            {
                App.myConstants.pointspoints+=2;
                PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
                await DisplayAlert("Congrats!", "Points Earned: " + App.myConstants.pointspoints, "Continue");
                hasAttended7 = true;
            }
            limit7++;

            //Only Can Click Once
            if (hasAttended7 == true && limit7 > 1)
            {
                await DisplayAlert("Sorry!", "You have already attended this event", "Continue");
            }

            //Free Lunch
            if (App.myConstants.pointspoints == 10)
            {
                await DisplayAlert("You win a Free Lunch!", "Lunch Pass Aquired", "Redeem");
            }

            //Homework Pass
            if (App.myConstants.pointspoints == 25)
            {
                await DisplayAlert("You win a Homework Pass!", "Homework Pass Acquired", "Redeem");
            }

            //Sweatshirt
            if (App.myConstants.pointspoints == 50)
            {
                await DisplayAlert("You win a SBHS Sweatshirt!", "Acquire your clothing In-Person at the school store", "Reedem");
            }

        }

        async void OnButtonClicked_8(object sender, EventArgs e)
        {
            if (hasAttended8 == false)
            {
                App.myConstants.pointspoints+=3;
                PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
                await DisplayAlert("Congrats!", "Points Earned: " + App.myConstants.pointspoints, "Continue");
                hasAttended8 = true;
            }
            limit8++;

            //Only Can Click Once
            if (hasAttended8 == true && limit8 > 1)
            {
                await DisplayAlert("Sorry!", "You have already attended this event", "Continue");
            }

            //Free Lunch
            if (App.myConstants.pointspoints == 10)
            {
                await DisplayAlert("You win a Free Lunch!", "Lunch Pass Aquired", "Redeem");
            }

            //Homework Pass
            if (App.myConstants.pointspoints == 25)
            {
                await DisplayAlert("You win a Homework Pass!", "Homework Pass Acquired", "Redeem");
            }

            //Sweatshirt
            if (App.myConstants.pointspoints == 50)
            {
                await DisplayAlert("You win a SBHS Sweatshirt!", "Acquire your clothing In-Person at the school store", "Reedem");
            }

        }

        async void OnButtonClicked_9(object sender, EventArgs e)
        {
            if (hasAttended9 == false)
            {
                App.myConstants.pointspoints+=4;
                PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
                await DisplayAlert("Congrats!", "Points Earned: " + App.myConstants.pointspoints, "Continue");
                hasAttended9 = true;
            }
            limit9++;

            //Only Can Click Once
            if (hasAttended9 == true && limit9 > 1)
            {
                await DisplayAlert("Sorry!", "You have already attended this event", "Continue");
            }

            //Free Lunch
            if (App.myConstants.pointspoints == 10)
            {
                await DisplayAlert("You win a Free Lunch!", "Lunch Pass Aquired", "Redeem");
            }

            //Homework Pass
            if (App.myConstants.pointspoints == 25)
            {
                await DisplayAlert("You win a Homework Pass!", "Homework Pass Acquired", "Redeem");
            }

            //Sweatshirt
            if (App.myConstants.pointspoints == 50)
            {
                await DisplayAlert("You win a SBHS Sweatshirt!", "Acquire your clothing In-Person at the school store", "Reedem");
            }

        }

        async void OnButtonClicked_10(object sender, EventArgs e)
        {
            if (hasAttended10 == false)
            {
                App.myConstants.pointspoints+=5;
                PointLabel.Text = "Points Earned: " + App.myConstants.pointspoints.ToString();
                await DisplayAlert("Congrats!", "Points Earned: " + App.myConstants.pointspoints, "Continue");
                hasAttended10 = true;
            }
            limit10++;

            //Only Can Click Once
            if (hasAttended10 == true && limit10 > 1)
            {
                await DisplayAlert("Sorry!", "You have already attended this event", "Continue");
            }

            //Free Lunch
            if (App.myConstants.pointspoints == 10)
            {
                await DisplayAlert("You win a Free Lunch!", "Lunch Pass Aquired", "Redeem");
            }

            //Homework Pass
            if (App.myConstants.pointspoints == 25)
            {
                await DisplayAlert("You win a Homework Pass!", "Homework Pass Acquired", "Redeem");
            }

            //Sweatshirt
            if (App.myConstants.pointspoints == 50)
            {
                await DisplayAlert("You win a SBHS Sweatshirt!", "Acquire your clothing In-Person at the school store", "Reedem");
            }

        }




    }

    
}