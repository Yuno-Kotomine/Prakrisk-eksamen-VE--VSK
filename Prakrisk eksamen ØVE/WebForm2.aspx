<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Prakrisk_eksamen_ØVE.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    </style>
</head>
<body style="height: 386px">
        <form id="form1" runat="server">

        <div>
            <asp:Label ID="Label1" runat="server" Text="Søk here for din elev informasjon!"></asp:Label>
        </div>
            <asp:Label ID="Label2" runat="server" Text="NB! du kan kun søke om spesefik informasjon som etter or fornavn, adresse, posrnr og klasseID! "></asp:Label>
            <p></p>
            <asp:GridView ID="GridView1" runat="server" Height="249px" Width="356px" style="margin-top: 9px"></asp:GridView>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="240px" style="margin-bottom: 0px" Height="19px"></asp:TextBox>
            <asp:Button ID="Button" runat="server" Text="Select" OnClick="Button_Click" Height="28px" Width="78px" />
      
        </form>

      
</body>
</html>
