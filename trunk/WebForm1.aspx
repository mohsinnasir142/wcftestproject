<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Communicator.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="tbWebServiceURL" runat="server" Width="550px" placeholder="URL OF WEB SERVICE"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Height="54px" Width="500px"  placeholder="INPUT ID" />
    <br /><br />
    <asp:TextBox ID="TextBox2" runat="server" Height="54px" Width="500px"  placeholder="INPUT NAME" />
    <br /><br />
    <asp:Button ID="btnCallPOSTwebService" runat="server" Text="Call POST web service" Width="150" onclick="btnCallPOSTwebService_Click" />
    <br />
    <asp:TextBox ID="txtResult" runat="server" Height="70px" TextMode="MultiLine" Width="500px" placeholder="Response (0 if success)"></asp:TextBox>
    </div>
    </form>
</body>
</html>
