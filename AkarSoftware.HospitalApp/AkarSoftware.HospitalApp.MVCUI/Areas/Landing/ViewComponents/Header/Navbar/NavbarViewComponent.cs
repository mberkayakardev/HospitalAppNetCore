using AkarSoftware.HospitalApp.Core.Utilities.Result.ComplexTypes;
using AkarSoftware.HospitalApp.Managers.Abstract;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.HospitalApp.MVCUI.Areas.Landing.ViewComponents.Header.Navbar
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly ILandingService _landingService;
        private readonly INotyfService _ToastNotification;

        public NavbarViewComponent(ILandingService landingService, INotyfService toastNotification)
        {
            _landingService = landingService;
            _ToastNotification = toastNotification;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _landingService.GetLandingNavigationMenus();

            if (result.Status != ResultStatus.Success)
                _ToastNotification.Error(result.Messages);

            return View(result.Data);
        }
    }
}
