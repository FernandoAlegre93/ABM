using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace AccesoADatos
{
    class AD_Conexion
    {
        #region METODOS
        private OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|BDFINAL.accdb");

        public OleDbConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            conexion.Open();
                return conexion;
        }

        public OleDbConnection CerrarConexion()
        {
            conexion.Close();
            return conexion;
        }

        #endregion

    }
}
