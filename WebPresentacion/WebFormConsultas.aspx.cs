using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace WebPresentacion
{
    public partial class WebFormConsultas : System.Web.UI.Page
    {
        LN bl;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) //Si es la primera ves que carga la aplicación
            {
                string cdn = ConfigurationManager.ConnectionStrings["conlocal"].ConnectionString;
                bl = new LN(cdn);
                Session["bl"] = bl;
            }
            else //Si viene de un postBack
            {

                bl = (LN)Session["bl"];
            }
            mostrarPub()
        }

        public void mostrarPub()
        {
            string msj = "";
            GridView1.DataSource = bl.InfoConsulta(ref msj);
            GridView1.DataBind();
        }
    }
}