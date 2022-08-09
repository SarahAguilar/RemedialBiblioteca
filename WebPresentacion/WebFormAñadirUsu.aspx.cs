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
    public partial class WebFormAñadirUsu : System.Web.UI.Page
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
            string nom = "", colonia = "", trabajo = "", tel = "";
            int num = 0, CP = 0;

            num = Convert.ToInt16(TextBoxNumero.Text);
            CP = Convert.ToInt16(TextBoxCP.Text);
            nom = TextBoxNombre.Text;
            colonia = TextBoxColonia.Text;
            trabajo = TextBoxTrabajo.Text;
            tel = TextBoxTelefono.Text;
            


            recibe = bl.InsertarUsuario(nom, colonia, num, CP, trabajo, tel);
            
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