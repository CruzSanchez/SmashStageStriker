using SmashStageStriker.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SmashStageStriker.Views
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