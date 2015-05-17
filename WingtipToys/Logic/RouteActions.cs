using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WingtipToys.Logic
{
    public class RouteActions
    {
        public void RegisterCustomRoutes(RouteCollection routes)
        {
            // Define Routes - name, url & physical url
            routes.MapPageRoute(
                    "ProductsByCategoryRoute",
                    "Category/{categoryName}",
                    "~/ProductList.aspx"
            );
            routes.MapPageRoute(
                    "ProductByNameRoute",
                    "Product/{productName}",
                    "~/ProductDetails.aspx"
            );
        }
    }
}