using Microsoft.AspNetCore.Mvc;
using RestaurantThemeManagement.Views.Shared.Components.Model;

namespace RestaurantThemeManagement.Views.Shared.Components.ComponentClass
{
    public class TopPicksViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var TopPicks = await GetTopPicks();
            return View(TopPicks);
        }


        private async Task< List<TopPicks>> GetTopPicks()
        {
            return await Task.FromResult(new List<TopPicks>
            {
                new TopPicks {Name = "Burger", ImageUrl ="/images/burger.jpg",Description ="Our Best Selling Food"},
                new TopPicks {Name = "Burger", ImageUrl ="/images/burger.jpg",Description ="Our Best Selling Food"},
                new TopPicks {Name = "Burger", ImageUrl ="/images/burger.jpg",Description ="Our Best Selling Food"},
                new TopPicks {Name = "Burger", ImageUrl ="/images/burger.jpg",Description ="Our Best Selling Food"},
                new TopPicks {Name = "Burger", ImageUrl ="/images/burger.jpg",Description ="Our Best Selling Food"},
                new TopPicks {Name = "Burger", ImageUrl ="/images/burger.jpg",Description ="Our Best Selling Food"},
     





            });
        }
    }
}
