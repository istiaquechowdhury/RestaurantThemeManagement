using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RestaurantThemeManagement.Views.Shared.Components.Model;

namespace RestaurantThemeManagement.Views.Shared.Components.ComponentClass
{
    public class CategoryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var GetCategory = GetCategories();
            return View(GetCategory);
        }

        private List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Name = "FastFood" },
                new Category { Name = "FastFood" },
                new Category { Name = "FastFood" },

            };
    }   }
}
