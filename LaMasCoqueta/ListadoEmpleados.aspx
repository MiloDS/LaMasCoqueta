<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoEmpleados.aspx.cs" Inherits="LaMasCoqueta.ListadoEmpleados" %>

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
            <div id="panelContent" class="panel-content">
                <asp:Panel ID="pnlInicio" runat="server" CssClass="inicio-container">
                    <asp:GridView ID="gvEmpleados" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Codigo" HeaderText="Código" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                            <asp:BoundField DataField="Edad" HeaderText="Edad" />
                            <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                            <asp:BoundField DataField="SalarioBase" HeaderText="Salario Base" DataFormatString="{0:C}" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </div>
        </form>
    </div>
</body>
</html>
