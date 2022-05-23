using Domnin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Domnin.Views
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