<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminhome.aspx.cs" Inherits="ecommercewebsite.adminhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 162%;
            height: 338px;
        }
        .auto-style2 {
            width: 413px;
        }
        .auto-style3 {
            width: 169px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style5 {
            height: 167px;
        }
        .auto-style6 {
            width: 169px;
            height: 167px;
        }
        .auto-style7 {
            width: 413px;
            height: 167px;
        }
        .auto-style8 {
            height: 48px;
        }
        .auto-style9 {
            width: 169px;
            height: 48px;
        }
        .auto-style10 {
            width: 413px;
            height: 48px;
        }
        .auto-style11 {
            width: 180px;
            text-align: center;
            padding: 10px 0 10px 0;
            margin-left: 34px;
        }
        .auto-style12 {
            width: 56px;
        }
        .auto-style13 {
            height: 48px;
            width: 56px;
        }
        .auto-style14 {
            height: 167px;
            width: 56px;
        }
        .auto-style16 {
            text-align: center;
            padding: 10px 0 10px 0;
            margin-left: 34px;
        }
        .auto-style17 {
            margin-left: 3px;
        }
        .auto-style18 {
            width: 57px;
        }
        .auto-style19 {
            height: 48px;
            width: 57px;
        }
        .auto-style20 {
            height: 167px;
            width: 57px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" CssClass="auto-style11" Font-Names="Arial Rounded MT Bold" Font-Size="XX-Large" Text="Add Category" Width="422px"></asp:Label>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">
                <asp:ImageButton ID="categoryimgbtn" runat="server" CssClass="auto-style17" Height="189px" Width="486px" ImageUrl="~/photos/catimgbutton/z.png" PostBackUrl="~/addcategory.aspx" />
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style9"></td>
            <td class="auto-style10">
                <asp:Label ID="Label2" runat="server" CssClass="auto-style16" Font-Names="Arial Rounded MT Bold" Font-Size="XX-Large" Text="Add Product" Width="387px"></asp:Label>
            </td>
            <td class="auto-style13"></td>
            <td class="auto-style19"></td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style6"></td>
            <td class="auto-style7">
                <asp:ImageButton ID="ImageButton2" runat="server" CssClass="auto-style4" Height="167px" Width="488px" ImageUrl="~/photos/catimgbutton/tools-864983_1280.jpg" PostBackUrl="~/addproduct.aspx" />
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style20"></td>
            <td class="auto-style5"></td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3">
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Small" ForeColor="Black" OnClick="LinkButton1_Click">View User Feedbacks</asp:LinkButton>
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
