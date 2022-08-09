using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using RemedialBiblioteca;

namespace Logica
{
    public class LN
    {
        public AcceDatos acceso;
        private string conexion;

        public LN(string cdn) //Constructor
        {
            conexion = cdn;
            acceso = new AcceDatos(cdn);
        }
        public string Open() //Metodo abrir conexion
        {
            string msj = "";
            acceso.AbrirConexion(ref msj);
            return msj;
        }

        public DataTable MostrarUsuario(ref string msj)
        {
            string query = "SELECT * FROM usuarios;";
            DataTable salida = null;
            DataSet ds = null;
            List<SqlParameter> listaP = new List<SqlParameter>();
            ds = acceso.ConsultaDS(query, acceso.AbrirConexion(ref msj), ref msj, listaP);
            if (ds != null) //Si el DataSet no esta vacio
            {
                salida = ds.Tables[0]; //Obtiene las tablas del DataSet
            }
            return salida;
        }
        public DataTable MostrarPublicaciones(ref string msj)
        {
            string query = "SELECT * FROM publicaciones;";
            DataTable salida = null;
            DataSet ds = null;
            List<SqlParameter> listaP = new List<SqlParameter>();
            ds = acceso.ConsultaDS(query, acceso.AbrirConexion(ref msj), ref msj, listaP);
            if (ds != null) //Si el DataSet no esta vacio
            {
                salida = ds.Tables[0]; //Obtiene las tablas del DataSet
            }
            return salida;
        }

        public Boolean BorrarUsuario(string id)
        {
            string query = "DELETE FROM usuario where id_usuario = " + id;
            string msj = "";
            Boolean salida = false;
            List<SqlParameter> listaP = new List<SqlParameter>();
            salida = acceso.Modificar(acceso.AbrirConexion(ref msj), query, ref msj, listaP);
            return salida;
        }

        public Boolean InsertarUsuario(string nom, string colonia, int num, int CP, string trabajo, string tel)
        {
            Boolean salida = false;
            string msj = "";
            string query = "INSERT INTO usuarios (nombre, colonia, numero, cp, nom_centroTrabajo, telefono)" + 
                           "VALUES(@nom, @colonia, @num, @CP, @trabajo, @tel); ";
            List<SqlParameter> listaP = new List<SqlParameter>();
          
            listaP.Add(new SqlParameter()
            {
                ParameterName = "nom",
                SqlDbType = SqlDbType.VarChar,
                Size = 40,
                Value = nom
            });
            listaP.Add(new SqlParameter()
            {
                ParameterName = "colonia",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Value = colonia
            });
            listaP.Add(new SqlParameter()
            {
                ParameterName = "num",
                SqlDbType = SqlDbType.Int,
                Value = num
            });
            listaP.Add(new SqlParameter()
            {
                ParameterName = "CP",
                SqlDbType = SqlDbType.Int,
                Value = CP
            });
            listaP.Add(new SqlParameter()
            {
                ParameterName = "trabajo",
                SqlDbType = SqlDbType.VarChar,
                Size = 30,
                Value = trabajo
            });
            listaP.Add(new SqlParameter()
            {
                ParameterName = "tel",
                SqlDbType = SqlDbType.VarChar,
                Size = 12,
                Value = tel
            });
            
            salida = acceso.Modificar(acceso.AbrirConexion(ref msj), query, ref msj, listaP);
            return salida;
        }
        public DataTable InfoConsulta(ref string msj, string id)
        {
           string query = "Select * from consulta where id_usuario = " + id;
            DataTable salida = null;
            DataSet ds = null;
            List<SqlParameter> listaP = new List<SqlParameter>();
            ds = acceso.ConsultaDS(query, acceso.AbrirConexion(ref msj), ref msj, listaP);
            if (ds != null) //Si el DataSet no esta vacio
            {
                salida = ds.Tables[0]; //Obtiene las tablas del DataSet
            }
            return salida;
        }
    }
}