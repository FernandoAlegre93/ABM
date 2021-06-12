using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Data;

namespace LNEGOCIOS
{
    public class LN_llenarcmb
    {
        private AD_llenarcmb llenar = new AD_llenarcmb();
        #region Atributos
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

        public DataTable Cargar()
        {
            llenar.Idtabla = idtabla;
            llenar.Tabla = tabla;
            llenar.Campo = campo;
            llenar.Condicion = condicion;

            DataTable table = new DataTable();
            table = llenar.Cargarcmb();
            return table;
        } 
    }
}
