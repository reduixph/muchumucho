<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="muchomucho.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AVLINC WEBSITE</title>

    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <script src="scripts/bootstrap.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <center><h1>Ardee's Ventures and Logistics, Inc.</h1></center>
        <div class="container">
            <div>
                <label class="lbl"><strong>Environment</strong></label></div>
            <div>
                <asp:DropDownList ID="ddlType" CssClass="form-control" runat="server">
                    <asp:ListItem Selected="True" Value="0">Test</asp:ListItem>
                    <asp:ListItem Value="1">Production</asp:ListItem>
                </asp:DropDownList>
                <div>
                    <label class="lbl"><strong>System</strong></label></div>
            </div>
            <div>
                <asp:DropDownList ID="ddlSystem" CssClass="form-control" runat="server">
                    <asp:ListItem Selected="True" Value="0">Payroll</asp:ListItem>
                    <asp:ListItem Value="1">Accounting</asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />
            <div>
                <asp:Button CssClass="btn btn-primary" ID="btnLaunch" runat="server" Text="Launch System" OnClick="btnLaunch_Click" />
            </div>
        </div>

    </form>
</body>
</html>
