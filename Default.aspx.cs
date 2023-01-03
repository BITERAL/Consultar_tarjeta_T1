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
using System.Xml.Linq;
using Consultar_tarjeta_T1.Models;

namespace Consultar_tarjeta_T1
{


    public partial class _Default : Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                tipdoc_SelectedIndexChanged();
            }

        }
        protected void tipdoc_SelectedIndexChanged()
        {

                SqlCommand cmd = new SqlCommand("Select Documento_ID,Tipo_Documento from Consultar_Tarjeta_T1.dbo.Documento order by Documento_ID", Conexion.Open());
                SqlDataAdapter datos = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                datos.Fill(ds);

                tipdoc.DataSource = ds;
                tipdoc.DataTextField = "Tipo_Documento";
                tipdoc.DataValueField = "Documento_ID";
                tipdoc.DataBind();
                tipdoc.Items.Insert(0, new ListItem("<Seleccionar>", "0"));
        }
      

    }
}
