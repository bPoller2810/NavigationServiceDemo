using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavServiceDemo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        private void HandleAppearing(object sender, EventArgs args)
        {
            _vm.IsModal = true;
        }
    }
}