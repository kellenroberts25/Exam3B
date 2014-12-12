<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="./css/StyleSheet.css" />
    <title>Language Translator</title>
</head>

<body>
    <form id="form1" runat="server">
    
        <div id ="body">
        <div id="header">
        <h1>
            <asp:Label ID="Welcomelbl" runat="server" Text="Welcome to" meta:resourceKey="Welcomelbl"></asp:Label>&nbsp;MSCI:3300</h1>
        <h2>
            <asp:Label ID="Classlbl" runat="server" Text="Software Design and Development" meta:resourceKey="Classlbl"></asp:Label></h2>
        </div>

    <div id="left_column">
        <div id="leftcolumn_text">
            <asp:Label ID="Languagelbl" runat="server" Text="Please select your language:" meta:resourceKey="Languagelbl"></asp:Label>
        &nbsp;&nbsp;<asp:DropDownList ID="ListBox1" runat="server" AutoPostBack="true">
            <asp:ListItem Value="en-US">English(US)</asp:ListItem>
            <asp:ListItem Value="zh-CN">中國(Chinese)</asp:ListItem>
            <asp:ListItem Value="ar-IQ">العربية(Arabic)</asp:ListItem>
            <asp:ListItem Value="es-MX">Español</asp:ListItem>
        </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" meta:resourceKey="imgDefault" />

        </div>

    </div>

    <div id="right_column">
        <div id="rightcolumn_text">
        <asp:Label ID="lblName" runat="server" Text="My name is:" meta:resourceKey="lblName"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="tbName" runat="server" meta:resourceKey="tbName" Text=""></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbName" ErrorMessage="You must enter a Name!!" Font-Italic="True" ForeColor="Red" meta:resourceKey="validate1"></asp:RequiredFieldValidator>
        <br />
        <br />
      <asp:Label ID="lblGender" runat="server" Text="I am:" meta:resourceKey="lblGender"></asp:Label>&nbsp;&nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="16px" RepeatDirection="Horizontal" Width="206px">
                <asp:ListItem Value="0" Text="Female" meta:resourceKey="liFemale"></asp:ListItem>
                <asp:ListItem Value="1" Text="Male" meta:resourceKey="liMale"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="You must select a Gender!!" Font-Italic="True" ForeColor="Red" meta:resourceKey="validate2"></asp:RequiredFieldValidator>
        <br />
            <asp:Label ID="lblGrad" runat="server" Text="I plan to graduate on:" meta:resourceKey="lblGrad"></asp:Label>
        <br />
        <br />
        <asp:Calendar ID="calendar_grad" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Label ID="lblEarn" runat="server" Text="When I graduate, I hope to earn:" meta:resourceKey="lblEarn"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="tbSalary" runat="server"  meta:resourceKey="tbSalary" Text=""></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbSalary" ErrorMessage="You must enter a Salary!!" Font-Italic="True" ForeColor="Red" meta:resourceKey="validate3"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit"  meta:resourceKey="btnSubmit"/>
            </div>
    </div>
    </div>
    </form>
</body>
</html>
