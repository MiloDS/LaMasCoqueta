<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoNomina.aspx.cs" Inherits="LaMasCoqueta.ListadoNomina" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Listado de Nómina - Textiles La Coqueta S.A.S</title>
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
                <li><a href="ListadoNomina.aspx">Historial Pagos</a></li>
            </ul>
        </nav>
    </div>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Listado Completo de Nómina</h2>
            <asp:GridView ID="gvNomina" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Código" />
                    <asp:BoundField DataField="NombreCompleto" HeaderText="Empleado" />
                    <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                    <asp:BoundField DataField="SalarioBase" HeaderText="Salario Base" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="DeduccionSalud" HeaderText="Deducción Salud" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="DeduccionPension" HeaderText="Deducción Pensión" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="AuxilioTransporte" HeaderText="Auxilio Transporte" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="SalarioNeto" HeaderText="Salario Neto" DataFormatString="{0:C}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
