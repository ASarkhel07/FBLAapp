using FBLAapp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FBLAapp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}