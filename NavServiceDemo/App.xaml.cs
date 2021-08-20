using GalaSoft.MvvmLight.Ioc;
using NavServiceDemo.Pages;
using NavServiceDemo.Services;
using Xamarin.Forms;

namespace NavServiceDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RootPage());

            SimpleIoc.Default.Register<INavigationService>(() => new DummyNavigationService(MainPage.Navigation));
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
