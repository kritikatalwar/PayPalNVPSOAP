<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PayPalAsp.net.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="paypalpay">
            <div class="form-group">
                <div class="col-sm-offset-2 col-md-6">
                    <asp:ImageButton ID="btnCheckout" runat="server" ImageUrl="https://www.paypal.com/en_US/i/btn/btn_xpressCheckout.gif"
                        Width="145" AlternateText="Check out with PayPal"
                        BackColor="Transparent" BorderWidth="0" OnClick="btnCheckout_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
