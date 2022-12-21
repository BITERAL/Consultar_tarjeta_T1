<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Consultar_tarjeta_T1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>BIENVENIDO A LA INTRANET APLICACIONES</h1>       
        <div class="conthcl" style="width:800px; height: 180px; margin-top: 100px;
      margin-left:100px;">
        <asp:Label ID="label" runat="server" Text="Selecciona Tipo de Documento"></asp:Label> 
        <asp:DropDownList ID="tipdoc" runat="server">
            <asp:ListItem Value="CC"></asp:ListItem>
            <asp:ListItem Value="TI"></asp:ListItem>
            <asp:ListItem Value="CE"></asp:ListItem>
               
        </asp:DropDownList>
         <asp:Label ID="label1" runat="server" Text="Ingrese Documento"></asp:Label> 
         <asp:TextBox ID="Dro" runat="server"></asp:TextBox> 
         <asp:Button ID="button" runat="server" Text="Consultar"></asp:Button>
               </div>
                   </div>
     
</asp:Content>
