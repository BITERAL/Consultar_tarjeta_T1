using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.DynamicData;

namespace  Consultar_tarjeta_T1
{

   
    public partial class _Default : Page
    {
        public SqlConnection cn = new SqlConnection("Data Source=BG-10814-EXNPRO;Initial Catalog=RadicacionTC;Integrated Security=True");
        Datos_usuarios dtperson = new Datos_usuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Clientes", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView.DataSource = dt;

        }
        void consulta()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from clientes where Cedula like'" + TexCedula.Text + "%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GridView.DataSource = dt;
            GridView.DataBind();
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            consulta();
            


            // Server.Transfer("pag_Consulta.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            
            dtperson.Cedulac = TexCedula.Text;
            Session["dtclient"] = dtperson;
            Server.Transfer("pag_Consulta.aspx");

            consulta();
        }

        protected void TexCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}