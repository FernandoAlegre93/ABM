using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista;
using LNEGOCIOS;

namespace VISTA
{
    public partial class form1 : Form
    {
        LN_Concierto Concert = new LN_Concierto();

        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
           
            txtFchC.ReadOnly = true;
            cboxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            Utiles.LimpiarControles(this);
           
           
            Llenacombo(cboxLugar, "Lugar", "IdLugar", "Lugar");
            Llenacombo(cboxCategoria, "Categoria", "IdCategoria", "Categoria");
            Llenacombo(cboxHora, "Horario", "IdHorario", "Horario");
            Llenacombo(cboxLocalidad, "Localidad", "idLocalidad", "Localidades");
            Utiles.BloquearControles(this);
            Utiles.BloquearBotones(this);

            cboxCategoria.SelectedIndex = -1;
            cboxHora.SelectedIndex = -1;
            cboxHora.SelectedIndex = -1;
            cboxLocalidad.SelectedIndex = -1;
            cboxLugar.SelectedIndex = -1;
        }

 
        #region Metodos

     
        private void Llenacombo(ComboBox cmb, string tabla, string idtabla, string campo, string condicion = "")
        {
            LN_llenarcmb LLc = new LN_llenarcmb();

            LLc.Tabla = tabla;
            LLc.Idtabla = idtabla;
            LLc.Campo = campo;
            LLc.Condicion = condicion;


            cmb.DataSource = LLc.Cargar();
            cmb.ValueMember = idtabla;
            cmb.DisplayMember = campo;
        }

        private void PasarDatos()
        {
         
            Concert.Artista = txtArtista.Text;
            Concert.Precio = txtPrecio.Text;
            Concert.Fecha = txtFchC.Text;
            if (string.IsNullOrEmpty(lblId.Text) )
            {
                Concert.Idconcierto = "";
                
            }
            else
            {
                Concert.Idconcierto = lblId.Text;
            }
            if (cboxLugar.SelectedItem == null)
            {
                Concert.Idlugar = "0";
            }
            else
            {
                Concert.Idlugar = cboxLugar.SelectedValue.ToString();
            }
            if (cboxCategoria.SelectedItem == null)
            {
                Concert.Idcategoria = "0";
            }
            else
            {
                Concert.Idcategoria = cboxCategoria.SelectedValue.ToString();

            }

            if (cboxHora.SelectedItem == null)
            {
                Concert.Idhorario = "0";

            }
            else
            {
                Concert.Idhorario = cboxHora.SelectedValue.ToString();
            }

            if (cboxLocalidad.SelectedItem == null)
            {
                Concert.Idlocalidad = "0";

            }
            else
            {
                Concert.idlocalidad = cboxHora.SelectedValue.ToString();
            }
        }


        private void Ejecutar(string idconcierto, string fecha, string artista, int precio, int lugar, int localidad, int categoria, int horario)
        {
            txtArtista.Text = artista;
            txtFchC.Text = fecha;
            txtPrecio.Text = Convert.ToString(precio);
            cboxCategoria.SelectedValue = categoria;
            cboxHora.SelectedValue = horario;
            cboxLocalidad.SelectedValue = localidad;
            cboxLugar.SelectedValue = lugar;
            lblId.Text = idconcierto;

        }

        #endregion


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Utiles.DesbloquearControles(this);
            Botonera.btnForm(this, btnAgregar);
            Utiles.LimpiarControles(this);
            txtFchC.Select();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Utiles.LimpiarControles(this);
            MessageBox.Show("¡Se han limpiado todos los campos!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Utiles.DesbloquearControles(this);
            txtFchC.Select();
            Botonera.btnForm(this, btnModificar);

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            PasarDatos();
            Concert.InsertarConcierto();
            Botonera.btnForm(this, btnGuardar);
            MessageBox.Show("¡Se ha agregado correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Utiles.BloquearControles(this);
            Utiles.LimpiarControles(this);
            Botonera.btnForm(this, btnCancelar);

        }

        private void btnAgregarFecha(object sender, EventArgs e)
        {
            FrmAgregarFecha fmrAgregar = new FrmAgregarFecha();

            fmrAgregar.ShowDialog();

            fecha(fmrAgregar.txtFecha.Text);

        }

        public void fecha(string fecha)
        {
            txtFchC.Text = fecha;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

           var resultado =MessageBox.Show("¿Estás seguro de ELIMINAR definitivamente al Concierto?",
                                                        "ELIMINAR CONCIERTO",
                                                        MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Concert.Idconcierto = lblId.Text;
                Concert.EliminarConcierto();
                Utiles.LimpiarControles(this);

                MessageBox.Show("Se ha eliminado correctamente el Concierto", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            PasarDatos();
            Concert.ModificarConcierto();
            Botonera.btnForm(this, btnGuardarCambios);
            Utiles.BloquearControles(this);
            Utiles.LimpiarControles(this);

            MessageBox.Show("¡Se han realizado los cambios!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Utiles.LimpiarControles(this);
            btnAgregar.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Enabled = true;
            btnModificar.Visible = true;
            btnEliminar.Enabled = true;
            btnEliminar.Visible = true;
            btnGuardarCambios.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           Busqueda fmrAgregar = new Busqueda();
            fmrAgregar.BusquedaPasada += new Busqueda.CargarBusqueda(Ejecutar);
            fmrAgregar.ShowDialog();
        }
        
    }
}

