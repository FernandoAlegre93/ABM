using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace AccesoADatos
{
    public class AD_llenarcmb
    {
        private DataTable dtcmbox = new DataTable();

        #region ATRIBUTOS
        private string idtabla;
        private string tabla;
        private string campo;
        private string condicion;

        #endregion

        #region PROPERTIES
        public string Idtabla
        {
            set { idtabla = value; }
        }

        public string Tabla
        {
            set { tabla = value; }
        }
        public string Campo
        {
            set { campo = value; }
        }

        public string Condicion
        {
            set { condicion = value; }
        }
        #endregion


        #region METODOS

        public DataTable Cargarcmb()
        {
            string SQL;

            if (condicion == "")
            {
                SQL = " SELECT " + idtabla + "," + campo + " FROM " + tabla;
            }
            else
            {
                SQL = " SELECT " + idtabla + "," + campo + " FROM " + tabla + " WHERE "+ condicion ;
            }
        

            AD_Conexion conexion = new AD_Conexion();
            OleDbCommand COM = new OleDbCommand(SQL, conexion.AbrirConexion());
            OleDbDataReader Dtr = COM.ExecuteReader();
            dtcmbox.Load(Dtr);
            conexion.CerrarConexion();
            return dtcmbox;
        }

        #endregion
    }
}
