<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Diet_Management.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 61%;
            height: 39px;
        }
        .style2
        {
            height: 11px;
            width: 3379px;
        }
        .style3
        {
            width: 492px;
            height: 43px;
        }
        .style4
        {
            height: 11px;
            width: 492px;
        }
        .style5
        {
            width: 3379px;
            height: 43px;
        }
        .style6
        {
            height: 4px;
            width: 3379px;
        }
        .style7
        {
            height: 4px;
            width: 492px;
        }
        .style8
        {
            width: 3379px;
            height: 36px;
        }
        .style9
        {
            width: 492px;
            height: 36px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td class="style6">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False" 
                    ForeColor="Blue"></asp:Label>
            </td>
            <td class="style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="User Name" ForeColor="White"></asp:Label>
            </td>
            <td class="style9">
                <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="135px" 
                    ForeColor="Black"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="*" ForeColor="Blue" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Enter correct username" 
                    ForeColor="Blue" 
                    ValidationExpression="^[a-zA-Z]{1}[a-zA-Z0-9\s]{5,12}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Password" ForeColor="White"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox2" runat="server" Height="34px" Width="135px" 
                    TextMode="Password" ForeColor="Black"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="*" ForeColor="Blue" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ErrorMessage="Enter correct password" ForeColor="Blue" 
                    ValidationExpression="^[a-zA-Z0-9]{6,10}$" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#CC0000" 
                    CausesValidation="false" BorderColor="White" 
                    ForeColor="White" Height="40px" Text="Reset" Width="74px" 
                    onclick="Button2_Click" />
            </td>
            <td class="style4">
                <asp:Button ID="Button1" runat="server" Text="Login" Width="73px" 
                    onclick="Button1_Click" Height="40px" BackColor="#CC0000" 
                    BorderColor="White" ForeColor="White" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
