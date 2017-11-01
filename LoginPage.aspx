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
        <input id="text_Username" type="text" runat="server"/></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="text_Username" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p style="margin-left: 40px">
        Enter Password :
        <input id="text_Password" type="password" runat="server"/></p><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="text_Password" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p style="margin-left: 40px">
        Login as :
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p style="margin-left: 40px">
        <input id="Submit1" type="submit" value="Login" runat="server" onserverclick="Submit1_ServerClick"/>&nbsp;&nbsp;
        <asp:Label ID="Error_Label" runat="server" Text=""></asp:Label>
    </p>
    
</asp:Content>

