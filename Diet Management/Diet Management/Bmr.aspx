<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeBehind="Bmr.aspx.cs" Inherits="Diet_Management.Bmr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 73%;
            height: 339px;
        }
        .style2
        {
            width: 733px;
        }
        .style3
        {
            width: 196px;
        }
        .style4
        {
            width: 733px;
            height: 18px;
        }
        .style5
        {
            width: 196px;
            height: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Label" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <br />
    <table class="style1">
        <tr>
            <td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Label ID="Label1" runat="server" Text="Calculating Bmr" ForeColor="White"></asp:Label>
&nbsp; </td>
            <td class="style3">
                <asp:Label ID="Label8" runat="server" Text="Label" Visible="False" 
                    ForeColor="White"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style4">
                <br />
            </td>
            <td class="style5">
                </td>
        </tr>
        <tr>
            <td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label 
                    ID="Label9" runat="server" Text="Do you want food suggestion?" 
                    Visible="False" ForeColor="White"></asp:Label>
            </td>
            <td class="style3">
                <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="RadioButtonList3_SelectedIndexChanged" 
                    Visible="False" Height="47px" Width="22px" ForeColor="White">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label12" runat="server" ForeColor="White" 
                    Text="You want to weight gain or loss? " Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    Height="34px" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                    Visible="False">
                    <asp:ListItem>Gain</asp:ListItem>
                    <asp:ListItem>Loss</asp:ListItem>
                    <asp:ListItem>Noneed</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Height(in inches)" ForeColor="White"></asp:Label>
                &nbsp;</td>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="54px" Height="34px">0</asp:TextBox>
                <asp:Label ID="Label7" runat="server" ForeColor="White" Text="feets"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Between 1-90 Accepted" 
                    ForeColor="Blue" ValidationExpression="^[1-9]{1}[0-5]{0,1}$"></asp:RegularExpressionValidator>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Width="54px" Height="34px">0</asp:TextBox>
                <asp:Label ID="Label6" runat="server" ForeColor="White" Text="inches"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox4" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="TextBox4" ErrorMessage="0-12 digits only accepted" 
                    ForeColor="Blue" ValidationExpression="^([0-9]|[0-1][0-2])$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Weight(in pounds)" ForeColor="White"></asp:Label>
                </td>
            <td class="style3">
                <asp:TextBox ID="TextBox2" runat="server" Width="135px" Height="34px">0</asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="Only 1-999 pounds accepted" 
                    ForeColor="Blue" ValidationExpression="^[1-9]{1}[0-9]{0,2}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Label ID="Label4" runat="server" Text="Gender" ForeColor="White"></asp:Label>
            </td>
            <td class="style3">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                    Width="35px" Height="50px" ForeColor="White">
                    <asp:ListItem Selected="True">Female  </asp:ListItem>
                    <asp:ListItem>  Male</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="RadioButtonList1" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Label ID="Label10" runat="server" Text="Age(in years)" ForeColor="White"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="TextBox3" runat="server" Width="135px" Height="34px">0</asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="Only 1-999 years accepted" 
                    ForeColor="Blue" ValidationExpression="^[1-9]{1}[0-9]{0,2}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label11" runat="server" Text="Work Done" ForeColor="White"></asp:Label>
            </td>
            <td class="style3">
                <asp:DropDownList ID="DropDownList2" runat="server" Height="35px" 
                    style="margin-left: 0px">
                    <asp:ListItem>Hardest</asp:ListItem>
                    <asp:ListItem>Heaviest</asp:ListItem>
                    <asp:ListItem>Moderate</asp:ListItem>
                    <asp:ListItem>Lightest</asp:ListItem>
                    <asp:ListItem>Verylow</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="DropDownList2" ErrorMessage="*" ForeColor="#3333FF"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                    ID="Button2" runat="server" CausesValidation="false" 
                    onclick="Button2_Click" Text="Back" Height="39px" Width="78px" 
                    BackColor="#CC0000" BorderColor="White" ForeColor="White" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" 
                    BackColor="#CC0000" BorderColor="White" CausesValidation="false" 
                    ForeColor="White" Height="40px" 
                    Text="Reset" Width="78px" onclick="Button3_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            <td class="style3">
                <asp:Button ID="Button1" runat="server" Text="Calculate" Width="117px" 
                    onclick="Button1_Click" Height="44px" BackColor="#CC0000" 
                    BorderColor="White" ForeColor="White" />
            </td>
        </tr>
        </table>
    <br />
    <br />
    </asp:Content>
