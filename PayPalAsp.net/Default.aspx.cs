using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayPalAsp.net
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCheckout_Click(object sender, ImageClickEventArgs e)
        {            
                Session["payment_amt"] = "20";
                Session["currency_code"] = "USD";
                Response.Redirect("~/Checkout/CheckoutStart.aspx");
        }
    }
}