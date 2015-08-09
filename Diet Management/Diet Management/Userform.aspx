<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="Userform.aspx.cs" Inherits="Diet_Management.Userform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 77%;
            height: 62px;
        }
        .style3
        {
            width: 544px;
        }
        .style5
        {
            width: 544px;
            height: 30px;
        }
        .style6
        {
            width: 1924px;
        }
        .style7
        {
            width: 1924px;
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="White"></asp:Label>
    <br />
    <table class="style1">
        <tr>
            <td class="style6">
                <br />
                <br />
                <br />
                <br />
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" 
                    Text="You want to know your BMI and Category:" ForeColor="White"></asp:Label>
                </td>
            <td class="style3">
                <asp:Button ID="Button1" runat="server" Height="47px" onclick="Button1_Click" 
                    Text="Calculate BMI" Width="170px" BackColor="#CC0000" BorderColor="White" 
                    ForeColor="White" />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style6">
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" 
                    Text="You want to know calories intake or your diet:" ForeColor="White"></asp:Label>
            </td>
            <td class="style5">
                <asp:Button ID="Button2" runat="server" Height="47px" onclick="Button2_Click" 
                    Text="Calculate Calories Intake" Width="170px" BackColor="#CC0000" 
                    BorderColor="White" ForeColor="White" />
                <br />
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
