using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNEGOCIOS;

namespace VISTA
{
    public partial class Busqueda : Form
    {
        public delegate void CargarBusqueda(string idconcierto,string fecha, string artista, int precio, int lugar, int localidad, int categoria, int horario);
        public event CargarBusqueda BusquedaPasada;
        public Busqueda()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cargar();
            this.Dispose();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            LN_Concierto Buscador = new LN_Concierto();

            Buscador.BusquedaLugar = txtBusquedaLugar.Text;

            if (txtBusqueda.Text == "")
            {
                Buscador.BusquedArtista = null;
            }
            else
            {
                Buscador.BusquedArtista = txtBusqueda.Text;
            }

            if (txtBusquedaLugar.Text == "")
            {
                Buscador.BusquedaLugar = null;
            }
            else
            {
                Buscador.BusquedaLugar = txtBusquedaLugar.Text;
            }

            dvgBusqueda.DataSource = Buscador.Busquedatabla();
        }


            private void Cargar()
            {
                if (dvgBusqueda.SelectedRows.Count > 0)
                {
                    BusquedaPasada(
                    dvgBusqueda.Rows[dvgBusqueda.SelectedRows[0].Index].Cells["IdConcierto"].Value.ToString(),
                    dvgBusqueda.Rows[dvgBusqueda.SelectedRows[0].Index].Cells["Fecha"].Value.ToString(),
                    dvgBusqueda.Rows[dvgBusqueda.SelectedRows[0].Index].Cells ["Artista"].Value.ToString(),
                    Convert.ToInt32(dvgBusqueda.Rows[dvgBusqueda.SelectedRows[0].Index].Cells["Precio"].Value.ToString()),
                    Convert.ToInt32(dvgBusqueda.Rows[dvgBusqueda.SelectedRows[0].Index].Cells["IdLugar"].Value.ToString()),
                    Convert.ToInt32(dvgBusqueda.Rows[dvgBusqueda.SelectedRows[0].Index].Cells["IdCategoria"].Value.ToString()),
                    Convert.ToInt32(dvgBusqueda.Rows[dvgBusqueda.SelectedRows[0].Index].Cells["IdHora"].Value.ToString()),
                    Convert.ToInt32(dvgBusqueda.Rows[dvgBusqueda.SelectedRows[0].Index].Cells["idlocalidad"].Value.ToString()));

                }
            }

        private void dvgBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cargar();
            this.Dispose();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            dvgBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgBusqueda.ReadOnly = true;
            dvgBusqueda.MultiSelect = false;
            dvgBusqueda.AllowUserToAddRows = false;
        }
    }
}
