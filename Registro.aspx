<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Consultar_tarjeta_T1.Registro" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
   <div class="conthcl" style="width:100%; height: 800px">
        <h1>BIENVENIDO A LA INTRANET  APLICACIONES</h1>
             <asp:Label ID="label1" runat="server" Text="Numero Documeto "></asp:Label> 
              <asp:TextBox ID="TexCedula" runat="server" ></asp:TextBox> 
                <asp:Label ID="label2" runat="server" Text="Numero Tarjeta "></asp:Label> 
                   <asp:TextBox ID="TextTarjeta" runat="server" ></asp:TextBox> 
                    <asp:Label ID="label3" runat="server" Text="Nombre Titular "></asp:Label> 
                     <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox> 
                     

                         <div class="contvcl">
                         <div class="conthcl">
                            
                             <asp:Calendar runat="server"></asp:Calendar>
                           
                     
                        </div>
                        </div>
                       <div class="conthcl" style="width:280px; height: 190px; margin-top: 30px;
                         margin-left:350px;">
                     
                        </div>

                         <div class="contvcr" style="width:300px; height: 160px; margin-top: 30px;
                         margin-left:100px;">
                    
                          
                          </div>
                       


                      <div class="conthcl" style="width:150px; height: 60px; margin-top: 30px;
                         margin-left:100px;">
                       <asp:Button runat="server" Text="Atras" OnClick="Unnamed1_Click"></asp:Button>
                      <asp:Button runat="server" Text="Siguiente" OnClick="Unnamed2_Click"></asp:Button>
                 </div>          
              
           </div>
      
        
     
    


</asp:Content>