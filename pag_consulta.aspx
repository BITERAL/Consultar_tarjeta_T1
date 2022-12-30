<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pag_Consulta.aspx.cs" Inherits="Consultar_tarjeta_T1.pag_consulta" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>BIENVENIDO A LA INTRANET APLICACIONES</h1>
            <div class="conthcl" style="width:600px; height: 60px; margin-top: 30px;
                margin-left:100px;">
              <asp:Label ID="label1" runat="server" Text="La consulta para el usuario"></asp:Label> 
              <asp:TextBox ID="TexCedula" runat="server" ></asp:TextBox> 
            
                  <div>
                  
                      <asp:Button runat="server" Text="Atras" OnClick="Unnamed1_Click"></asp:Button>
                      <asp:Button runat="server" Text="Siguiente" OnClick="Unnamed2_Click"></asp:Button>
                  </div>
                <asp:GridView ID="GridView" runat="server">  </asp:GridView>  
        
             </div>          
     </div>
    <%--  --%>


</asp:Content>