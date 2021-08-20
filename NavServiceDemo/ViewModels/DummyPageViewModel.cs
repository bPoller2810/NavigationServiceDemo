using GalaSoft.MvvmLight.Ioc;
using MvvMHelpers.core;
using NavServiceDemo.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavServiceDemo.ViewModels
{
    public class DummyPageViewModel : BaseViewModel
    {

        private readonly INavigationService _navigationService;


        private bool _isModal;
        public bool IsModal
        {
            get => _isModal;
            set => Set(ref _isModal, value);
        }


        public ICommand PopPageCommand { get; }

        public DummyPageViewModel()
        {
            _navigationService = SimpleIoc.Default.GetInstance<INavigationService>();

            PopPageCommand = new AsyncCommand(ExecutePopPageCommand);
        }

        private Task ExecutePopPageCommand()
        {
            return _navigationService.PopAsync(IsModal);
        }

    }
}
