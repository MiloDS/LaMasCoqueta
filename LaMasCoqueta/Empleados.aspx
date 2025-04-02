<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="LaMasCoqueta.Empleados" %>

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

    <div class="container">
        <h2>Registro de Empleados</h2>
        <form id="form1" runat="server">
            <div class="form-group">
                <label>Código:</label>
                <asp:TextBox ID="txtCodigo" runat="server" CssClass="input-field"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="input-field"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Apellido:</label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="input-field"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Edad:</label>
                <asp:TextBox ID="txtEdad" runat="server" CssClass="input-field" TextMode="Number"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Cargo:</label>
                <asp:DropDownList ID="ddlCargo" runat="server" CssClass="input-field">
                    <asp:ListItem Text="Seleccione un cargo" Value="" />
                    <asp:ListItem Text="Operario" Value="Operario" />
                    <asp:ListItem Text="Supervisor" Value="Supervisor" />
                    <asp:ListItem Text="Administrativo" Value="Administrativo" />
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Salario Base:</label>
                <asp:TextBox ID="txtSalarioBase" runat="server" CssClass="input-field" TextMode="Number"></asp:TextBox>
            </div>

            <div class="button-group">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn-primary" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn-secondary" OnClick="btnLimpiar_Click" />
            </div>
        </form>
    </div>
</body>
</html>
