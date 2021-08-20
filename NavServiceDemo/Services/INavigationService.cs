using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavServiceDemo.Services
{
    public interface INavigationService
    {

        Task NavigateToAsync(Page page, bool modal = false, bool animate = true);
        Task PopAsync(bool modal = false, bool animate = true);
        Task PopToRootAsync(bool animate = true);
    }
}
