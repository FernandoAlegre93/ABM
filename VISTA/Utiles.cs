using System.Windows.Forms;

namespace CapaVista
{
    class Utiles
    {
        public static void BloquearControles(Form FRM)
        {
            foreach (Control c in FRM.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = false;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = false;
                }
            }
        }

        public static void BloquearBotones(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                if (c is Button)
                {
                    if (((Button)c).Name == "btnAgregar")
                    {
                        ((Button)c).Enabled = true;
                        ((Button)c).Visible = true;

                    }
                    if (((Button)c).Name == "btnGuardar")
                    {
                        ((Button)c).Enabled = false;
                        ((Button)c).Visible = false;

                    }
                    if (((Button)c).Name == "btnModificar")
                    {
                        ((Button)c).Enabled = true;
                        ((Button)c).Visible = true;

                    }
                    if (((Button)c).Name == "btnCancelar")
                    {
                        ((Button)c).Enabled = false;
                        ((Button)c).Visible = false;

                    }
                    if (((Button)c).Name == "btnEliminar")
                    {
                        ((Button)c).Enabled = true;
                        ((Button)c).Visible = true;

                    }
                    if (((Button)c).Name == "btnGuardarCambios")
                    {
                        ((Button)c).Enabled = false;
                        ((Button)c).Visible = false;
                    }


                    if (((Button)c).Name == "btnFecha")
                    {
                        ((Button)c).Enabled = false;
                        ((Button)c).Visible = false;
                    }

                    if (((Button)c).Name == "btnLimpiar")
                    {
                        ((Button)c).Enabled = false;
                        ((Button)c).Visible = false;
                    }

                }
                
            }
        }
       
      

        public static void DesbloquearControles(Form FRM)
        {
            foreach (Control c in FRM.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Enabled = true;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = true;
                }

            }
        }



        public static void LimpiarControles(Form FRM)
        {
            foreach (Control c in FRM.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = null;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = null;
                }
                
               if(c is Label & c.Name == "lblId")
                {
                    ((Label)c).Text = null;
                }

            }
        }

        
        
    }

}

