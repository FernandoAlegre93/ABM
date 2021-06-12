using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;



namespace LNEGOCIOS
{
    public class LN_Concierto
    {
        private AD_Concierto Concierto = new AD_Concierto();

        #region Atributos
        private string idconcierto;
        private string idlugar;
        private string idhorario;
        private string idcategoria;
        public string idlocalidad;
        private string artista;
        private string fecha;
        private string precio;
        private string busquedartista;
        private string busquedalugar;
        #endregion

        #region PROPERTIES
        public string Idconcierto
        {
            set { idconcierto = value; }
        }
        public string Idlugar
        {
            set { idlugar = value; }
        }
        public string Idcategoria
        {
            set { idcategoria = value; }
        }
        public string Idhorario
        {
            set { idhorario = value; }
        }
        public string Idlocalidad
        {
            set { idlocalidad = value; }
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

        public DataTable MostrarConcierto()
        {
            DataTable tabla = new DataTable();
            tabla = Concierto.MostrarDatos();
            return tabla;
        }
        public void InsertarConcierto()
        {
            EnviarDatos();
            Concierto.InsertarConcierto();
        }
        public void ModificarConcierto()
        {
            EnviarDatos();
            Concierto.ModificarConcierto();
        }
        public void EliminarConcierto()
        {
            Concierto.Idconcierto = Convert.ToInt32(idconcierto);
            Concierto.EliminarConcierto();

        }
        private void EnviarDatos()
        {
            Concierto.Idconcierto = Convert.ToInt32(idconcierto);
            Concierto.Artista = this.artista;
            Concierto.Fecha = this.fecha;
            Concierto.Precio = this.precio;
            Concierto.Idlugar = Convert.ToInt32(idlugar);
            Concierto.Idcategoria = Convert.ToInt32(idcategoria);
            Concierto.Idhorario = Convert.ToInt32(idhorario);
            Concierto.Idlocalidad = Convert.ToInt32(idlocalidad);

        }

        private void EnviarBusqueda()
        {
            Concierto.BusquedaLugar = busquedalugar;
            Concierto.BusquedArtista = busquedartista;
        }

        public DataTable Busquedatabla()
        {
            DataTable Dtb = new DataTable();
            EnviarBusqueda();
            Dtb = Concierto.BuscarArtista();
            return Dtb;
        }
        #endregion


    }

}
