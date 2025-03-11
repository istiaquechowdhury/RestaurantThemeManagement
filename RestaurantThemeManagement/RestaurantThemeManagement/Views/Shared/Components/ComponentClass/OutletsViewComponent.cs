using Microsoft.AspNetCore.Mvc;
using RestaurantThemeManagement.Views.Shared.Components.Model;

namespace RestaurantThemeManagement.Views.Shared.Components.ComponentClass
{
    public class OutletsViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Getoutlets = GetOutlets();
            return View(Getoutlets);
        }
        private List<OutLets> GetOutlets ()
        {
            return new List<OutLets>
            {
                new OutLets {Address ="banani,chairmanbari-123",ImageUrl ="/images/map.jpg" },
                new OutLets {Address ="banani,chairmanbari-123",ImageUrl ="/images/map.jpg" },
                new OutLets {Address ="banani,chairmanbari-123",ImageUrl ="/images/map.jpg" }

            };
        }
    }
}
