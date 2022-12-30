using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Consultar_tarjeta_T1
{
    public partial class pag_consulta : System.Web.UI.Page
    {

        public List<Datos_griview> lista_griview = new List<Datos_griview>();
        Datos_usuarios dtperson = new Datos_usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            dtperson = Session["dtclient"] as Datos_usuarios;

            TexCedula.Text = dtperson.Cedulac;
            
            

        }

      protected void datosapagdos(object sender, EventArgs e)
        {

            foreach (var dato in lista_griview)
            {
              //  GridView.Rows.Add(dato.NumeroTarjeta, dato.Estadotarj, dato.FechaEstado);           
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {


            Server.Transfer("Default.aspx");
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Registro.aspx");
        }
    }
}