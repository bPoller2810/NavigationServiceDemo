using GalaSoft.MvvmLight.Ioc;
using MvvMHelpers.core;
using NavServiceDemo.Pages;
using NavServiceDemo.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavServiceDemo.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {

        private readonly INavigationService _navigationService;

        public ICommand PushPageCommand { get; }
        public ICommand PushPageModalCommand { get; }

        public MainPageViewModel()
        {
            _navigationService = SimpleIoc.Default.GetInstance<INavigationService>();

            PushPageCommand = new AsyncCommand(ExecutePushPageCommand);
            PushPageModalCommand = new AsyncCommand(ExecutePushPageModalCommand);
        }

        private Task ExecutePushPageCommand()
        {
            return _navigationService.NavigateToAsync(new NormalPage());
        }

        private Task ExecutePushPageModalCommand()
        {
            return _navigationService.NavigateToAsync(new ModalPage(), true);
        }

    }
}
