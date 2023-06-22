<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Pages_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 228px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--First we are going to display the products to the customers
    We will create a table to do this--%>
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imageProduct" runat="server" CssClass="detailsimage" />
            </td>
            <td class="auto-style1">
                <h2>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbltitle" runat="server" Text="Label"></asp:Label>
                <hr />
                    </h2>
            </td>
        </tr>

        <tr>
            <td class="auto-style1"><asp:Label ID="lbldescription" runat="server"  CssClass="detailDescription"></asp:Label></td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblprice" runat="server"  CssClass="detailprice"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Quanity:<asp:DropDownList ID="ddlamount" runat="server"></asp:DropDownList>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" CssClass="button" Font-Size="Medium" Text="Add Product" OnClick="Button1_Click" /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
           
            <br />
            <asp:Label ID="lblresult" runat="server" Text=""></asp:Label>
        </tr>




        <tr>&nbsp; <td class="auto-style1">Product Number: <asp:Label ID="lblitemnumber" runat="server" Text="Label"></asp:Label></td>
        </tr>

        <tr>
            
            <td class="auto-style1"><asp:Label ID="Label1" runat="server" Text="Available" CssClass="productPrice"></asp:Label></td>
        </tr>
    </table>



</asp:Content>

