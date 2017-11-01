﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<script runat="server">

    
</script>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Sign Up by filling in the details below -</p>
    <p>
        Name -
        <input id="Text1" type="text" runat="server" /></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Text1" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p>
        Email ID -
        <input id="Text2" type="text" runat="server"/></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Text2" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ControlToValidate="Text2" ForeColor="Red" ErrorMessage="*Enter a valid email address." />
    <p>
        Username -
        <input id="Text3" type="text" runat="server"/></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Text3" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p>
        Password -
        <input id="Password1" type="password" runat="server"/></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="Password1" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p>
        Address -
        <input id="Text4" type="text" runat="server"/></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Text4" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p>
        City -
        <input id="Text5" type="text" runat="server"/></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Text5" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p>
        State -
        <input id="Text6" type="text" runat="server"/></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Text6" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p>
        Country -
        <input id="Text7" type="text" runat="server"/></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Text7" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p>
        Pincode -
        <input id="Text8" type="text" runat="server"/></p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="Text8" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
    <p>
        <input id="SubmitButton1" type="submit" value="Sign Up" runat="server" onserverclick="SubmitButton1_Clicked"/></p>
    <p>
        <asp:Label ID="ErrorLabel1" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>
