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
    <asp:DropDownList ID="DropDownList4" runat="server">
    </asp:DropDownList>
    <p style="margin-left: 40px">
        Login as :
        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="Subscriber">Subscriber</asp:ListItem>
            <asp:ListItem Value="Employee">Employee</asp:ListItem>
        </asp:RadioButtonList>
        </p>
  
    
    <p style="margin-left: 40px">
        <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Submit1_ServerClick" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="SignUp" OnClick="Button1_Click" CausesValidation="False"/>
    </p>
    <p style="margin-left: 40px">
        &nbsp;<asp:Label ID="Error_Label" runat="server" Text=""></asp:Label>
    </p>
    <asp:Panel runat="server">  <asp:DropDownList ID="DropDownList2" runat="server"><asp:ListItem>a</asp:ListItem>
        <asp:ListItem>b</asp:ListItem></asp:DropDownList>
  </asp:Panel>
    
</asp:Content>

