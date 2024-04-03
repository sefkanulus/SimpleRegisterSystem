<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RegisterSystem.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        CUSTOMERNAME
        <p>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            CITY</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            BIRTHDAE</p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            DISTRICT</p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            GENDER</p>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="Blue" ForeColor="White" OnClick="Button1_Click" Text="REGİSTER" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Kayıt Olun."></asp:Label>
        </p>
    </form>
</body>
</html>
