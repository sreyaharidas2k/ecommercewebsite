<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="editcategory.aspx.cs" Inherits="ecommercewebsite.editcategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 160%;
            height: 295px;
        }
        .auto-style2 {
            height: 20px;
        }
        .auto-style3 {
            height: 19px;
        }
        .auto-style4 {
            height: 18px;
        }
        .auto-style5 {
            width: 288px;
        }
        .auto-style6 {
            height: 19px;
            width: 288px;
        }
        .auto-style7 {
            height: 18px;
            width: 288px;
        }
        .auto-style8 {
            height: 20px;
            width: 288px;
        }
        .auto-style9 {
            width: 162px;
        }
        .auto-style10 {
            height: 19px;
            width: 162px;
        }
        .auto-style11 {
            height: 18px;
            width: 162px;
        }
        .auto-style12 {
            height: 20px;
            width: 162px;
        }
        .auto-style13 {
            width: 49px;
        }
        .auto-style14 {
            height: 19px;
            width: 49px;
        }
        .auto-style15 {
            height: 18px;
            width: 49px;
        }
        .auto-style16 {
            height: 20px;
            width: 49px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style5">
                <asp:GridView ID="GridView1" runat="server" CellPadding="2" CellSpacing="2" DataKeyNames="Cat_Id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" Width="443px">
                    <AlternatingRowStyle Font-Size="Larger" Height="20px" Width="3001px" />
                    <Columns>
                        <asp:CommandField HeaderText="Edit Image" ShowSelectButton="True" />
                        <asp:CommandField HeaderText="Edit content" ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style11"></td>
            <td class="auto-style7">
            </td>
            <td class="auto-style15"></td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="EDIT IMAGE"></asp:Label>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style7">
                <asp:Image ID="Image1" runat="server" Height="88px" Width="116px" />
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD" />
                <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style12"></td>
            <td class="auto-style8"></td>
            <td class="auto-style16"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
