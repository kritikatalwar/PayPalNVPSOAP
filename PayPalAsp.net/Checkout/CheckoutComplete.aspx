<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckoutComplete.aspx.cs" Inherits="PayPalAsp.net.Checkout.CheckoutComplete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="container main">
        <h1><span>Checkout Complete</span></h1>
        <div role="form" class="form-horizontal">
            <div class="form-group">
                <div class="col-md-2">
                    <label class="control-label">Payment Transaction ID:</label>
                </div>
                <div class="col-md-6">
                    <label class="control-label">
                        <asp:Label ID="TransactionId" CssClass="control-label" runat="server"></asp:Label>
                    </label>
                </div>
            </div>
        </div>
        <h3>Thank You!</h3>
        <div class="col-sm-2">
            <asp:LinkButton ID="lnkRedirectToDashBoard" CssClass="btn btn-primary btn-block" PostBackUrl="~/account/dashboard" runat="server">Go To DashBoard</asp:LinkButton>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
