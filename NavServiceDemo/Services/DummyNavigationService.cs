using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavServiceDemo.Services
{
    public class DummyNavigationService : INavigationService
    {
        private readonly INavigation _navigation;

        public DummyNavigationService(INavigation navigation)
        {
            _navigation = navigation ?? throw new ArgumentNullException(nameof(navigation));
        }

        public Task NavigateToAsync(Page page, bool modal = false, bool animate = true)
        {
            return page is null
                ? throw new ArgumentNullException(nameof(page))
                : modal ? _navigation.PushAsync(page, animate) : _navigation.PushModalAsync(page, animate);
        }

        public Task PopAsync(bool modal = false, bool animate = true)
        {
            return modal ? _navigation.PopModalAsync(animate) : _navigation.PopAsync(animate);
        }

        public Task PopToRootAsync(bool animate = true)
        {
            return _navigation.PopToRootAsync(animate);
        }
    }
}
