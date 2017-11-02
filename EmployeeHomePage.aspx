<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EmployeeHomePage.aspx.cs" Inherits="EmployeeHomePage" Theme="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" text=""></asp:Label>
        
            Choose option - <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>Change Theme</asp:ListItem>
                <asp:ListItem>Select Delivery Region</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Check Commision"  />
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" AllowSorting="true" AllowPaging="true" PageSize="4" DataSourceID ="sqlDB"></asp:GridView>
            <asp:SqlDataSource ID="sqlDB" runat="server" ConnectionString="<%$ ConnectionStrings:con1 %>" SelectCommand="select * from Subscription where Region=@var1 order by Pincode">
                <SelectParameters>
                    <asp:ControlParameter Name="var1" ControlID="DropDownList2" PropertyName="SelectedValue" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Check Commision" OnClick="Button1_Click" />

            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
       