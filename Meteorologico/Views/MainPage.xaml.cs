using Meteorologico.ViewModel;
using Microsoft.Maui.Controls;

namespace Meteorologico.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new CidadeViewModel();
        }
    }
}
