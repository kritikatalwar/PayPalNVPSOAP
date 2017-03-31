<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckoutError.aspx.cs" Inherits="PayPalAsp.net.Checkout.CheckoutError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="Errorcode" class="text-danger">        
  Error Code:<%=Request.QueryString.Get("ErrorCode")%><br/>
  <%=Request.QueryString.Get("Desc")%><br/>
  <%=Request.QueryString.Get("Desc2")%>            
</div>
    </div>
    </form>
</body>
</html>
