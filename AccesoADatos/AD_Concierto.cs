using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;



namespace AccesoADatos
{
    public class AD_Concierto
    {
        AD_Conexion conexion = new AD_Conexion();
        OleDbDataReader Odr;
        DataTable tabla = new DataTable();
        OleDbCommand comando = new OleDbCommand();



        #region ATRIBUTOS

        private int idconcierto;
        private int idlugar;
        private int idcategoria;
        private int idhorario;
        private int idlocalidad;
        private string artista;
        private string fecha;
        private string precio;
        private string busquedartista;
        private string busquedalugar;
        #endregion


        #region PROPERTIES
        public int Idconcierto
        {
            set { idconcierto = value; }
        }
        public int Idlugar
        {
            set { idlugar = value;}
        }
        public int Idcategoria
        {
            set { idcategoria = value; }
        }
        public int Idhorario
        {
            set { idhorario = value; }
        }
        public int Idlocalidad
        {
            set {idlocalidad = value; }
            }
        public string Artista
        {
            set { artista = value; }
        }
        public string Fecha
        {
            set { fecha = value; }
        }
        public string Precio
        {
            set { precio = value; }
        }
        public string BusquedArtista
        {
            set { busquedartista = value; }
        }
        public string BusquedaLugar
        {
            set { busquedalugar = value; }
        }
        #endregion


        #region METODOS


        public DataTable MostrarDatos()
        {
            AD_Conexion conexion = new AD_Conexion();
            comando.Connection=conexion.AbrirConexion();
            comando.CommandText = "Select * from Concierto";
            Odr = comando.ExecuteReader();
            tabla.Load(Odr);
            conexion.CerrarConexion();
            return tabla;
    }
        public void InsertarConcierto()
        {
            string sSql = "INSERT INTO Concierto " +
               "(Artista, Fecha, Precio, IdLugar, IdCategoria, IdHora,IdLocalidad) " +
                "values" +
                " ('" + artista + "','" + fecha + "'," + precio + "," + idlugar +
                ",'" + idcategoria + "','" + idhorario + "','" + idlocalidad + "')";
            Ejecutar(sSql);
        }
        public void ModificarConcierto()
        {
            string sSql = "UPDATE Concierto set " + "Artista= '" + artista + "', Fecha= '" + fecha + "', Precio = '" + precio + 
                "', IdLugar= '" + idlugar + "', IdCategoria= '" + idcategoria + "', IdHora= '" + 
                idhorario + "', Idlocalidad= '" + idlocalidad + "' WHERE IdConcierto = " + idconcierto;
            Ejecutar(sSql);

        }


        public void EliminarConcierto()
        {
            string sSql = "DELETE FROM Concierto WHERE IdConcierto =" + idconcierto;
            Ejecutar(sSql);

        }

        public DataTable BuscarArtista()
        {
            string sql = "Select * from Concierto";
            string condicion;

            if (busquedartista!= null)
            {
                condicion = " where Concierto.Artista like '%" + busquedartista +"%'";
                sql += condicion;
            }
            if (busquedalugar != null)
            {
                condicion = " where Concierto.Lugar like '%" + busquedalugar + "%'";
                sql += condicion;
            }

            OleDbCommand enviar = new OleDbCommand(sql, conexion.AbrirConexion());
            OleDbDataReader dtr = enviar.ExecuteReader();
            DataTable DtBusqueda = new DataTable();
            DtBusqueda.Load(dtr);
            conexion.CerrarConexion();
            return DtBusqueda;



        }
        private void Ejecutar(string sSQL)
        {
            OleDbCommand com = new OleDbCommand(sSQL, conexion.AbrirConexion());
            com.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        #endregion

    }
}
