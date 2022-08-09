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
    public partial class WebForm1 : System.Web.UI.Page
    {
        LN bl = null;

        string idUsu = null;
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
            mostrarUsu();
            mostrarPrub();
        }

        public void NoVisibles()
        {

            BtnActualizar.Visible = false;
            BtnAñadir.Visible = false;
            BtnEliminar.Visible = false;
        }
        public void Visibles()
        {
            BtnActualizar.Visible = true;
            BtnAñadir.Visible = true;
            BtnEliminar.Visible = true;
        }

        public void mostrarUsu()
        {
            string msj = "";
            GridView1.DataSource = bl.MostrarUsuario(ref msj);
            GridView1.DataBind();
        }
        public void mostrarPrub()
        {
            string msj = "";
            GridView2.DataSource = bl.MostrarPublicaciones(ref msj);
            GridView2.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["id_usuario"] = GridView1.SelectedRow.Cells[1].Text; //Se guarda el id del profe en una variable de sesion
            Response.Redirect("WebFormConsultas.aspx"); //Redireccionamos
        }

        protected void BtnAñadir_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormAñadirUsu.aspx"); //Redireccionamos
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            idUsu = GridView1.SelectedRow.Cells[1].Text;
            string resp = "";
            Boolean recibe = false;
            recibe = bl.BorrarUsuario(idUsu);

            if (recibe)
            {
                TextBoxStatus.Text = "Se elimino exitosamente";
            }
            else
            {
                TextBoxStatus.Text = "ERROR! No se pudo eliminar";
            }
        }
    }
}