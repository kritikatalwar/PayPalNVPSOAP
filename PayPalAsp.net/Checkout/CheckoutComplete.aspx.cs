using PayPalAsp.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayPalAsp.net.Checkout
{
    public partial class CheckoutComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                VerifyPayment();
            }
        }
        #region--Verify Payment--
        public void VerifyPayment()
        {
            NVPAPICaller payPalCaller = new NVPAPICaller();
            string retMsg = "";
            string token = "";
            string PayerID = "";
            NVPCodec decoder = new NVPCodec();
            token = Session["token"].ToString();
            string currency_code = Session["currency_code"].ToString();
            bool ret = payPalCaller.GetCheckoutDetails(token, ref PayerID, ref decoder, ref retMsg);
            if (ret)
            {
                // Verify total payment amount as set on CheckoutStart.aspx.
                try
                {
                    decimal paymentAmountOnCheckout = Convert.ToDecimal(Session["payment_amt"].ToString());
                    decimal paymentAmoutFromPayPal = Convert.ToDecimal(decoder["AMT"].ToString());
                    if (paymentAmountOnCheckout != paymentAmoutFromPayPal)
                    {
                        Response.Redirect("CheckoutError.aspx?" + "Desc=Amount%20total%20mismatch.");
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("CheckoutError.aspx?" + "Desc=Amount%20total%20mismatch.");
                }

            }
            string finalPaymentAmount = Session["payment_amt"].ToString();
            bool res = payPalCaller.DoCheckoutPayment(finalPaymentAmount, currency_code, token, PayerID, ref decoder, ref retMsg);
            if (res)
            {
                // Retrieve PayPal confirmation value.
                string PaymentConfirmation = decoder["PAYMENTINFO_0_TRANSACTIONID"].ToString();
                TransactionId.Text = PaymentConfirmation;

            }
            else
            {
                Response.Redirect("CheckoutError.aspx?" + retMsg);
            }
        }
        #endregion
    }
}