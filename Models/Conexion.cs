using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Consultar_tarjeta_T1.Models
{
    public static class Conexion
    {

        public static SqlConnection Open()
        {

            SqlConnection Cn = new SqlConnection("Data Source=BG-10814-EXNPRO;Initial Catalog=Consultar_Tarjeta_T1;Integrated Security=True");
            Cn.Open();
            return Cn;
        }
     public static SqlConnection Close()
        {

            SqlConnection Cn = new SqlConnection("Data Source=BG-10814-EXNPRO;Initial Catalog=Consultar_Tarjeta_T1;Integrated Security=True");
            Cn.Close();
            return Cn;
        }
    }
}