<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminreg.aspx.cs" Inherits="ecommercewebsite.adminreg1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 111%;
            height: 218px;
        }
        .auto-style2 {
            width: 129px;
        }
        .auto-style3 {
            width: 232px;
        }
        .auto-style4 {
            width: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Name</td>
            <td class="auto-style3">
                    <asp:TextBox ID="txtadminname" runat="server"></asp:TextBox>
                </td>
            <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtadminname" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Address</td>
            <td class="auto-style3">
                    <asp:TextBox ID="txtadminaddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtadminaddress" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Email</td>
            <td class="auto-style3">
                    <asp:TextBox ID="txtadminemail" runat="server"></asp:TextBox>
                </td>
            <td class="auto-style4">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtadminemail" ErrorMessage="Enter valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Phone</td>
            <td class="auto-style3">
                    <asp:TextBox ID="txtadminphone" runat="server"></asp:TextBox>
                </td>
            <td class="auto-style4">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtadminphone" ErrorMessage="Enter valid Phone number" ValidationExpression="^[6789]\d{9}$"></asp:RegularExpressionValidator>
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Username</td>
            <td class="auto-style3">
                    <asp:TextBox ID="txtadminusername" runat="server" AutoPostBack="True" OnTextChanged="txtadminusername_TextChanged"></asp:TextBox>
                </td>
            <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtadminusername" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            <td>
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Password</td>
            <td class="auto-style3">
                    <asp:TextBox ID="txtadminpwd" runat="server" AutoPostBack="True" OnTextChanged="txtadminpwd_TextChanged"></asp:TextBox>
                </td>
            <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtadminpwd" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            <td>
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Confirm Password</td>
            <td class="auto-style3">
                    <asp:TextBox ID="txtadmincpwd" runat="server"></asp:TextBox>
                </td>
            <td class="auto-style4">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtadminpwd" ControlToValidate="txtadmincpwd" ErrorMessage="Password mismatch"></asp:CompareValidator>
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
                </td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
