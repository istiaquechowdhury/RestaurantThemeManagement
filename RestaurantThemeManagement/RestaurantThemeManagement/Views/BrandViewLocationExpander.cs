using Microsoft.AspNetCore.Mvc.Razor;

public class BrandViewLocationExpander : IViewLocationExpander
{
    private const string BRAND_KEY = "CurrentBrand";

    public void PopulateValues(ViewLocationExpanderContext context)
    {
        context.Values[BRAND_KEY] = GetCurrentBrand(context.ActionContext.HttpContext);
    }

    public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
    {
        // Don't replace the default locations, just prioritize certain views
        var defaultLocations = viewLocations.ToList();

        if (!context.Values.TryGetValue(BRAND_KEY, out var brand))
            return defaultLocations;

        // Get the view name being requested
        var viewName = context.ViewName;

        // If we're looking for the "Index" view and brand is "KFC",
        // tell it to look for "Privacy" view first
        if (viewName == "Index" && brand == "KFC")
        {
            var newLocations = new List<string>();
            foreach (var location in defaultLocations)
            {
                // Replace "Index" with "Privacy" in the path patterns
                var modifiedLocation = location.Replace("{0}", "Privacy");
                newLocations.Add(modifiedLocation);
            }

            // Then add the original locations as fallbacks
            newLocations.AddRange(defaultLocations);
            return newLocations;
        }

        return defaultLocations;
    }

    private string GetCurrentBrand(HttpContext httpContext)
    {
        var configuration = httpContext.RequestServices.GetService<IConfiguration>();
        return configuration["BrandSettings:CurrentBrand"];
    }
}