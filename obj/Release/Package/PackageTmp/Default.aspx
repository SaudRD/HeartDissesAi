<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="heartV2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Heart Disses Predction </h1>
        </div>
        <table>
            <tr>
                <td>Age: </td>
                <td><asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Sex: </td>
                <td><asp:RadioButtonList ID="rbSex" runat="server">
                    <asp:ListItem Value="1">Male</asp:ListItem>
                    <asp:ListItem Value="0">Female</asp:ListItem>
                </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td>Cardiac output: </td>
                <td><asp:TextBox ID="txtcp" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Trestbps: </td>
                <td><asp:TextBox ID="txtTrestpbs" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Cholesterol: </td>
                <td><asp:TextBox ID="txtCHOL" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Fbs: </td>
                <td><asp:TextBox ID="txtFBS" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Restecg: </td>
                <td><asp:TextBox ID="txtRestecg" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Thalach: </td>
                <td><asp:TextBox ID="txtThalach" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Exang: </td>
                <td><asp:TextBox ID="txtExang" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Oldpeak: </td>
                <td><asp:TextBox ID="txtOldpeak" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Slope: </td>
                <td><asp:TextBox ID="txtSlope" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Ca: </td>
                <td><asp:TextBox ID="txtCA" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">Thal: </td>
                <td class="auto-style2"><asp:TextBox ID="txtThal" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td></td>
                <td>
                    <asp:Button ID="bPredict" runat="server" Text="Predict" OnClick="Button1_Click" CssClass="auto-style2" Font-Bold="True" Font-Names="A Hemmat" Height="30px" Width="174px" /></td>
            </tr>

        </table>
        <asp:Label ID="lblResult" runat="server" Font-Size="X-Large"></asp:Label>

    </form>
</body>
</html>
