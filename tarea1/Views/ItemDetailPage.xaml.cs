using System.ComponentModel;
using tarea1.ViewModels;
using Xamarin.Forms;

namespace tarea1.Views
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