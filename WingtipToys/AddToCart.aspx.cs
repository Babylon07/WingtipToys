using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using WingtipToys.Logic;



namespace WingtipToys
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the ProductID query string from 'ProductList.aspx'
            string rawId = Request.QueryString["productID"];
            int productId;
            
            // Check 'rawId' isnt null and parse to int 'productId '       
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId))
            {
                // Create a new ShoppinCartActions object and call AddToCart 
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }

            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a ProductId.");
                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a ProductId."); 
            }
            // Direct the user the ShoppingCart which will display thier items
            Response.Redirect("ShoppingCart.aspx"); 

        }
    }
}