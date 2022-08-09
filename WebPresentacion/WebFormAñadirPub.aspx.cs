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
    public partial class WebFormAñadirPub : System.Web.UI.Page
    {
        LN bl;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string cdn = ConfigurationManager.ConnectionStrings["conlocal"].ConnectionString;
                bl = new LN(cdn);
                Session["bl"] = bl;
            }
            else
            {
                bl = (LN)Session["bl"];

            }
        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            Boolean recibe = false;
            string msj = "";
            string tit = "";
            int ejem = 0;

            ejem = Convert.ToInt16(TextBoxEjemplar.Text);
            tit = TextBoxtitulo.Text;
            



            recibe = bl.InsertarPublicacion(tit, ejem);

            if (recibe == true)
            {
                TextBoxStatus.Text = "Nuevo registro agregado exitosamente";
            }
            else
            {
                TextBoxStatus.Text = "Error!, no se agrego el registro";
            }
        }
    }
}