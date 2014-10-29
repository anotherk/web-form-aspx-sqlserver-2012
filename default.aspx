<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mi primera pagina Web Asp.Net</title>
</head>
<body>
    <header>
        <h1>Diccionario con Asp.net</h1>
    </header>
    <form id="form1" runat="server">
    <div>
        <p>Palabras con A</p>
        <asp:TextBox runat="server" ID="txtLetraA"></asp:TextBox>
        <p>Palabras con B</p>
        <asp:TextBox runat="server" ID="txtLetraB"></asp:TextBox>
        <asp:Button runat="server" ID="btnGenerar" Text="Generar" OnClick="btnGenerar_Click" />
        <p><asp:Label runat="server" ID="lblResult"></asp:Label></p>
    </div>
    </form>
    <footer>&copy; Ing. Edgar Padilla Ramos</footer>
</body>
</html>
