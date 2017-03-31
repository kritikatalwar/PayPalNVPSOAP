using PayPalAsp.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayPalAsp.net.Checkout
{
    public partial class CheckoutStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NVPAPICaller payPalCaller = new NVPAPICaller();
            string retMsg = "";
            string token = "";

            if ((Session["payment_amt"] != null) && (Session["currency_code"] != null))
            {
                string amt = Session["payment_amt"].ToString();
                string currency_code = Session["currency_code"].ToString();
                bool ret = payPalCaller.ShortcutExpressCheckout(amt, currency_code, ref token, ref retMsg);
                if (ret)
                {
                    Session["token"] = token;
                    Response.Redirect(retMsg);
                }
                else
                {
                    Response.Redirect("CheckoutError.aspx?" + retMsg);
                }
            }
            else
            {
                Response.Redirect("CheckoutError.aspx?ErrorCode=AmtMissing");
            }
        }
    }
}