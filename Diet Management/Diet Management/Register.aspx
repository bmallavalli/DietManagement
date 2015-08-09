<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Diet_Management.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 68%;
            height: 72px;
        }
        .style2
        {
            width: 769px;
        }
        .style3
        {
            width: 487px;
            margin-left: 40px;
        }
        .style4
        {
            width: 769px;
            height: 18px;
        }
        .style5
        {
            width: 487px;
            height: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False" 
                    ForeColor="Blue"></asp:Label>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="User Name" ForeColor="White"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox1" runat="server" 
                    style="margin-left: 0px; margin-bottom: 0px" Height="34px" Width="135px" 
                    ForeColor="Black"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="TextBox1" 
                    ErrorMessage="Min 6 characters start with alphabet and Maximim 12 characters" 
                    ValidationExpression="^[a-zA-Z]{1}[a-zA-Z0-9\s]{5,12}$" 
                    ForeColor="Blue"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Password" ForeColor="White"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Height="34px" 
                    Width="135px" ForeColor="Black"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="TextBox2" 
                    ErrorMessage="Minimum 6 character's and  Maximum 10 characters" 
                    ValidationExpression="^[a-zA-Z0-9]{6,10}$" ForeColor="Blue"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                    ID="Label4" runat="server" Text="&nbsp;&nbsp;&nbsp; Re-type Password" 
                    ForeColor="White"></asp:Label>
            </td>
            <td class="style3">
                &nbsp;<asp:TextBox ID="TextBox3" runat="server" TextMode="Password" 
                    Height="34px" Width="135px" ForeColor="Black"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="TextBox2" ControlToValidate="TextBox3" 
                    ErrorMessage="must match with password" ForeColor="Blue"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#CC0000" CausesValidation="false" BorderColor="White" 
                    ForeColor="White" Height="36px" onclick="Button2_Click" Text="Reset" 
                    Width="87px" />
            </td>
            <td class="style5">
                <asp:Button ID="Button1" runat="server" Text="Register" 
                    onclick="Button1_Click" Height="36px" Width="87px" BackColor="#CC0000" 
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
</asp:Content>
