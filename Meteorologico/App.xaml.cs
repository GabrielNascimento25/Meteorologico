using Meteorologico.Views;
using static System.Net.Mime.MediaTypeNames;

namespace Meteorologico
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
