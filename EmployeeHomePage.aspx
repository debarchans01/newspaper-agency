<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EmployeeHomePage.aspx.cs" Inherits="EmployeeHomePage" Theme="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" text=""></asp:Label>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:DropDownList ID="DropDownList1" runat="server" />
                <asp:ListItem>View Details</asp:ListItem>
                <asp:ListItem>Select Delivery Region</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Check Commision"  />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

