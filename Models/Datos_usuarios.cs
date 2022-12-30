using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Consultar_tarjeta_T1
{
    public class Datos_usuarios
    {
        public string Nombrec = "pendiente";
        public string NumeroTarjetac = "pendiente";
        public string Cedulac = "pendiente";
    }

    public class Datos_griview
    {

        [ScaffoldColumn(false)]
        public int TitularID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string Titular { get; set; }

        [Required, StringLength(100), Display(Name = "tipo tarjeta"), DataType(DataType.MultilineText)]
        public string Tipotarjeta { get; set; }
        public string NumeroTarjeta { get; set; }
        public string Estadotarj { get; set; }
        public string FechaEstado { get; set; }

        [Display(Name = "Price")]
        public string Saldo { get; set; }

        public int? Tipo_DocID { get; set; }

        public virtual Tipo_Doc Tipo_Docs { get; set; }

    }

    
    public class Tipo_Doc
    {


        [ScaffoldColumn(false)]
        public int Tipo_DocID { get; set; }

        [Display(Name = "tipo tarjeta")]
        public string Tipotarjeta { get; set; }
        public virtual ICollection<Datos_griview>  Datos_Griviews{ get; set; }

    }
}