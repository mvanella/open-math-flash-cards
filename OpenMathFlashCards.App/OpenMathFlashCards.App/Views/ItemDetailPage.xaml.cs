using OpenMathFlashCards.App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace OpenMathFlashCards.App.Views
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