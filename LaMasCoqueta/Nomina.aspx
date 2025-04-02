<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nomina.aspx.cs" Inherits="LaMasCoqueta.Nomina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Textiles La Coqueta S.A.S</title>
    <!--<link href="~/css/global.css" rel="stylesheet" type="text/css" />-->
    <link href="~/css/global2.css" rel="stylesheet" type="text/css" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;600&display=swap" rel="stylesheet" />
</head>
<body>
    <div class="header">
        <h1>GESTIÓN DE NÓMINA</h1>
        <nav class="menu">
            <ul>
                <li><a href="Default.aspx">Inicio</a></li>
                <li class="dropdown">
                    <a href="javascript:void(0)" class="dropbtn">Empleados</a>
                    <div class="dropdown-content">
                        <a href="ListadoEmpleados.aspx">Listado</a>
                        <a href="Empleados.aspx">Registro</a>
                    </div>
                </li>
                <li><a href="Nomina.aspx">Pagos</a></li>
            </ul>
        </nav>
    </div>
    <!--Contenido pricipal-->
    <div class="container">
        <form id="frmInicio" runat="server">

            <div class="form-group">
                <label for="ddlEmpleado">Empleado:</label>
                <asp:DropDownList ID="ddlEmpleado" runat="server" CssClass="input-field"></asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="txtSalarioBase">Salario Base:</label>
                <asp:TextBox ID="txtSalarioBase" runat="server" CssClass="input-field" ReadOnly="true"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtHorasExtras">Horas Extras:</label>
                <asp:TextBox ID="txtHorasExtras" runat="server" CssClass="input-field" TextMode="Number"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtDeducciones">Deducciones:</label>
                <asp:TextBox ID="txtDeducciones" runat="server" CssClass="input-field" TextMode="Number"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtAuxilioTransporte">Auxilio de Transporte:</label>
                <asp:TextBox ID="txtAuxilioTransporte" runat="server" CssClass="input-field" ReadOnly="true"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtTotalPagar">Total a Pagar:</label>
                <asp:TextBox ID="txtTotalPagar" runat="server" CssClass="input-field" ReadOnly="true"></asp:TextBox>
            </div>

            <div class="button-group">
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular Pago" CssClass="btn btn-primary" OnClick="btnCalcular_Click" />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar Nómina" CssClass="btn btn-secondary" OnClick="btnGuardar_Click" />
            </div>
        </form>
    </div>
</body>
</html>
