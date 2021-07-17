<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TCS.aspx.cs" Inherits="TCS.TCS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divLabel">
            <label>Prueba TCS</label>
        </div>
        <div id="divTextArea">
            <textarea id="txtArea" runat="server" ></textarea>
        </div>

        <div id="divBtnEnviar" runat="server">
            <asp:Button runat="server"  ID="btnEnviar" Text="Enviar" OnClick="btnEnviar_Click"/>
        </div>

         <div id="divLblSeleccionar" runat="server">
            <label id="lblSeleccionar" >Por favor seleccionar la palabra que desea saber cuantas veces se encuentra en la frase</label>
        </div>

        <div id="divList" runat="server">
            <asp:DropDownList  ID="idDrownList" runat="server"></asp:DropDownList>
        </div>
         <div id="divValidarCantidadesPalabra" runat="server">
            <asp:button Text="Calcular Cantidades" id="btnCalcularCantidades" runat="server" OnClick="btnCalcularCantidades_Click" ></asp:button>
        </div>
    </form>
</body>
</html>
