<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="Diet_Management.Result" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label" ForeColor="White"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
    <asp:Label ID="Label1" runat="server" ForeColor="#CC0000" Text="Food Suggestion"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#CC0000" BorderColor="White" 
                    ForeColor="White" onclick="Button1_Click" Text="Back" Height="40px" 
                    Width="91px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#CC0000" BorderColor="White" 
                    ForeColor="White" Height="40px" CausesValidation="false" onclick="Button2_Click" 
                    Text="Click for Analytics" Width="120px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
