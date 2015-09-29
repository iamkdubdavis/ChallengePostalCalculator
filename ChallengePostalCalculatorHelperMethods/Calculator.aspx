<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:
        <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        Height: <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        Length:
        <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="PostalGroup" OnCheckedChanged="groundShipping_CheckedChanged" Text="Ground" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="PostalGroup" OnCheckedChanged="airShipping_CheckedChanged" Text="Air" />
        <br />
        <asp:RadioButton ID="nextDayAirRadioButton" runat="server" AutoPostBack="True" GroupName="PostalGroup" OnCheckedChanged="nextDayShipping_CheckedChanged" Text="Next Day Air" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
