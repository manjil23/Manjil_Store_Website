<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProducts.aspx.cs" Inherits="Pages_ManageProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Name:" Font-Size="Medium"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 82px" Width="162px"></asp:TextBox>
    </p>
    <p>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Label ID="Label2" runat="server" Text="Type:" Font-Size="Medium"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 61px" Height="29px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="164px" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:manjilstoredbConnectionString %>" SelectCommand="SELECT * FROM [ProductType] ORDER BY [Name]"></asp:SqlDataSource>
    </p>
    <p>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:Label ID="Label3" runat="server" Text="Price:" Font-Size="Medium"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="Label8" runat="server" Text="$" Font-Size="X-Large"></asp:Label>&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 4px" Width="158px"></asp:TextBox>
       &nbsp; ** <asp:Label ID="Label7" runat="server" Text="Decimal Formate is not accepted." Font-Size="X-Small"></asp:Label>
        **</p>
    <p>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label4" runat="server" Text="Image: " Font-Size="Medium"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" style="margin-left: 84px" Height="29px" Width="163px">
        </asp:DropDownList>
    </p>
    <p>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Label ID="Label5" runat="server" Text="Description:" Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Height="63px" style="margin-left: 52px" TextMode="MultiLine" Width="228px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" style="margin-left: 165px" Text="Submit" Width="118px" Font-Size="Medium" OnClick="Button1_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
       &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label6" runat="server" Font-Size="Medium"></asp:Label>
    </p>
    <p>
    </p>
</asp:Content>

