using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class FrmAgregarFecha : Form
    {
        public FrmAgregarFecha()
        {
            InitializeComponent();
        }
       
       

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtFecha.Text== "")
            {
                MessageBox.Show("¡Elija una fecha por favor!" , "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);

                return;
            }
            this.Close();
            
            

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            txtFecha.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" +
                monthCalendar1.SelectionStart.Month.ToString() + "/" +
                monthCalendar1.SelectionStart.Year.ToString();
            

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmAgregarFecha_Load(object sender, EventArgs e)
        {
            if (txtFecha.Text != " ")
            { btnAceptar.Enabled = false; 
            
             }
            else { 
                btnAceptar.Enabled = true; }
            

        }
    }
}
