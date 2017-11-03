<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ModifySubscriptionPage.aspx.cs" Inherits="ModifySubscriptionPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" Text="Dashboard" OnClick="Button5_Click" />
    <br />
    Select one of your current subscription -
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" AllowSorting="True" DataKeyNames="S_ID">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="S_ID" HeaderText="S_ID" SortExpression="S_ID" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="P_Name" HeaderText="P_Name" SortExpression="P_Name" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
            <asp:BoundField DataField="Start_date" HeaderText="Start_date" SortExpression="Start_date" />
            <asp:BoundField DataField="End_date" HeaderText="End_date" SortExpression="End_date" />
            <asp:BoundField DataField="Pause_start" HeaderText="Pause_start" SortExpression="Pause_start" />
            <asp:BoundField DataField="Pause_end" HeaderText="Pause_end" SortExpression="Pause_end" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:con1 %>" SelectCommand="SELECT [S_ID], [P_Name], [Status], [Start_date], [End_date], [Pause_start], [Pause_end] FROM [Subscription] WHERE (([Username] = @Username) AND NOT ([Status] = @Status))">
        <SelectParameters>
            <asp:SessionParameter Name="Username" SessionField="username" Type="String" />
            <asp:Parameter DefaultValue="Cancelled" Name="Status" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
        <asp:ListItem Value="1">Pause</asp:ListItem>
        <asp:ListItem Value="2">Delete</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Label2" runat="server" Text="Select date from which your pause period starts - (Must be atleast 7 days from today)"></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
    <br />
    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
        <WeekendDayStyle BackColor="#CCCCFF" />
    </asp:Calendar>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Select date at which your pause period ends - "></asp:Label>
    <br />
    <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="Calendar2_SelectionChanged" Width="220px">
        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
        <WeekendDayStyle BackColor="#CCCCFF" />
    </asp:Calendar>
    <asp:Label ID="Label4" runat="server" Text="Confirm pausing for these dates ?"></asp:Label>

    <br />
    <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text=""></asp:Label>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text=""></asp:Label>

    <br />
    <asp:Button ID="Button1" runat="server" Text="Pause It" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Cancel" />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Are you sure you want to delete the following subscription ?"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Width="1180px"  ></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" Text="Cancel Subscription" OnClick="Button3_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" Text="Retry" />
    <br />
    <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    <br />
</asp:Content>

