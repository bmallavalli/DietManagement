<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="Food.aspx.cs" Inherits="Diet_Management.Food" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 67%;
        }
        .style2
        {
            width: 631px;
        }
        .style3
        {
            width: 631px;
            height: 17px;
        }
        .style4
        {
            height: 17px;
            width: 376px;
        }
        .style5
        {
            width: 376px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
            </td>
        </tr>
        <tr>
            <td class="style3">
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label14" runat="server" Text="Label" ForeColor="White"></asp:Label>
                <br />
                <br />
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" ForeColor="White"></asp:Label>
            </td>
            <td class="style4">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
                    Height="58px" Width="33px" ForeColor="White">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="RadioButtonList1" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Text="Select the disease" Visible="False" 
                    ForeColor="White"></asp:Label>
            </td>
            <td class="style4">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" 
                    onselectedindexchanged="CheckBoxList1_SelectedIndexChanged" Visible="False" 
                    Width="43px" Height="93px" ForeColor="White" AutoPostBack="True">
                    <asp:ListItem Value="Diabetes">Diabetic Issues</asp:ListItem>
                    <asp:ListItem Value="Heart Disease">Cardiac Problems</asp:ListItem>
                    <asp:ListItem Value="HighBP">HighBlood Pressure</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                    ID="Button1" runat="server" onclick="Button1_Click" Text="Ok" 
                    Visible="False" Width="91px" Height="40px" BackColor="#CC0000" 
                    BorderColor="White" ForeColor="White" />
                &nbsp;&nbsp;&nbsp;
                </td>
            <td class="style4">
                <asp:Button ID="Button5" runat="server" BackColor="#CC0000" BorderColor="White" 
                    ForeColor="White" Height="41px" CausesValidation="false" onclick="Button5_Click" 
                    Text="Click for Analytics" Width="121px" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Select 2 fruits from the list" 
                    Visible="False" ForeColor="White"></asp:Label>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ListBox ID="ListBox1" runat="server" Height="100px" 
                    SelectionMode="Multiple" Visible="False" 
                    onselectedindexchanged="ListBox1_SelectedIndexChanged" Width="141px"></asp:ListBox>
                &nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="ListBox1" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                &nbsp;
                <asp:Label ID="Label10" runat="server" Text="select only 2" Visible="False" 
                    ForeColor="Blue"></asp:Label>
                </td>
            <td class="style5">
                &nbsp;
                <asp:Label ID="Label3" runat="server" Text="Select 4 Vegetables from the list" 
                    Visible="False" ForeColor="White"></asp:Label>
                <asp:ListBox ID="ListBox2" runat="server" Height="100px" 
                    SelectionMode="Multiple" Visible="False" 
                    onselectedindexchanged="ListBox2_SelectedIndexChanged" Width="145px"></asp:ListBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="ListBox2" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                <asp:Label ID="Label11" runat="server" Text="select only 4" Visible="False" 
                    ForeColor="Blue"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" 
                    Text="Select 2 diary items from the list" Visible="False" 
                    ForeColor="White"></asp:Label>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ListBox ID="ListBox3" runat="server" Height="100px" 
                    SelectionMode="Multiple" Visible="False" 
                    onselectedindexchanged="ListBox3_SelectedIndexChanged" Width="146px"></asp:ListBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="ListBox3" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                <asp:Label ID="Label12" runat="server" Text="select only 2" Visible="False" 
                    ForeColor="Blue"></asp:Label>
            </td>
            <td class="style5">
                <asp:Label ID="Label5" runat="server" Text="Select 2 proteins from the list" 
                    Visible="False" ForeColor="White"></asp:Label>
                &nbsp;&nbsp;
                <asp:ListBox ID="ListBox4" runat="server" Height="100px" 
                    SelectionMode="Multiple" Visible="False" 
                    onselectedindexchanged="ListBox4_SelectedIndexChanged" Width="144px"></asp:ListBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="ListBox4" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                <asp:Label ID="Label13" runat="server" Text="select only 2" Visible="False" 
                    ForeColor="Blue"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button3" runat="server" CausesValidation="false" 
                    onclick="Button3_Click" Text="Back" Width="91px" Height="41px" 
                    BackColor="#CC0000" BorderColor="White" ForeColor="White" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                    ID="Button4" runat="server" ForeColor="#FFFFCC" Height="41px" 
                    onclick="Button4_Click" Text="Click For Result" Visible="False" 
                    Width="164px" BackColor="#CC0000" BorderColor="#336600" />
                &nbsp;</td>
            <td class="style5">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Ok" 
                    Visible="False" Width="91px" Height="40px" BackColor="#CC0000" 
                    BorderColor="White" ForeColor="White" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            <td class="style5">
                <asp:Label ID="Label9" runat="server" Visible="False" ForeColor="White"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                </td>
            <td class="style5">
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
