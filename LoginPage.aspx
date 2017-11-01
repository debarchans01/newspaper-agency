<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <p>
        <br />
&nbsp;&nbsp;&nbsp;
    </p>
    <p style="margin-left: 40px">
        Enter username :
        <input id="Username" type="text" /></p>
    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="Username" ></asp:RequiredFieldValidator>
    <p style="margin-left: 40px">
        Enter Password :
        <input id="Password" type="password" /></p>
    <p style="margin-left: 40px">
        Login as :
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p style="margin-left: 40px">
        <input id="Submit1" type="submit" value="Login" runat="server" onserverclick="Submit1_ServerClick"/></p>
    
</asp:Content>

