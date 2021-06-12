using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    class Botonera
    {
        public static void btnForm(Form faux, Button btn)
        {
            string nombre = btn.Name;
            switch (nombre)
            {
                case "btnAgregar":
                    foreach (Control c in faux.Controls)
                    {
                            if (c is Button)
                            {
                                if (((Button)c).Name == "btnAgregar")
                                {
                                    ((Button)c).Enabled = false;
                                    ((Button)c).Visible = false;

                                }
                                if (((Button)c).Name == "btnGuardar")
                                {
                                    ((Button)c).Enabled = true;
                                    ((Button)c).Visible = true;

                                }
                                if (((Button)c).Name == "btnModificar")
                                {
                                    ((Button)c).Enabled = false;
                                    ((Button)c).Visible = false;

                                }
                                if (((Button)c).Name == "btnCancelar")
                                {
                                    ((Button)c).Enabled = true;
                                    ((Button)c).Visible = true;

                                }
                                if (((Button)c).Name == "btnEliminar")
                                {
                                    ((Button)c).Enabled = false;
                                    ((Button)c).Visible = false;

                                }
                            if (((Button)c).Name == "btnGuardarCambios")
                            {
                                ((Button)c).Enabled = false;
                                ((Button)c).Visible = false;

                            }

                            if (((Button)c).Name == "btnFecha")
                            {
                                ((Button)c).Enabled = true;
                                ((Button)c).Visible = true;
                            }

                            if (((Button)c).Name == "btnLimpiar")
                            {
                                ((Button)c).Enabled = true;
                                ((Button)c).Visible = true;
                            }

                        }   
                    }
                    break;
                case "btnGuardar":
                    foreach (Control c in faux.Controls)
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
                        }
                    }
                    break;

                case "btnModificar":
                    foreach (Control c in faux.Controls)
                    {
                        if (c is Button)
                        {
                            if (((Button)c).Name == "btnAgregar")
                            {
                                ((Button)c).Enabled = false;
                                ((Button)c).Visible = false;

                            }
                            if (((Button)c).Name == "btnGuardar")
                            {
                                ((Button)c).Enabled = false;
                                ((Button)c).Visible = false;

                            }
                            if (((Button)c).Name == "btnModificar")
                            {
                                ((Button)c).Enabled = false;
                                ((Button)c).Visible = false;

                            }
                            if (((Button)c).Name == "btnCancelar")
                            {
                                ((Button)c).Enabled = true;
                                ((Button)c).Visible = true;

                            }
                            if (((Button)c).Name == "btnEliminar")
                            {
                                ((Button)c).Enabled = false;
                                ((Button)c).Visible = false;

                            }
                            if (((Button)c).Name == "btnGuardarCambios")
                            {
                                ((Button)c).Enabled = true;
                                ((Button)c).Visible = true;
                            }
                            if (((Button)c).Name == "btnFecha")
                            {
                                ((Button)c).Enabled = true;
                                ((Button)c).Visible = true;
                            }
                        }
                    }
                    break;

                case "btnGuardaCambios":
                    foreach (Control c in faux.Controls)
                    {
                        if (c is GroupBox | c is Panel)
                        {
                            foreach (object x in c.Controls)
                            {
                                if (x is Button)
                                {
                                    if (((Button)x).Name == "btnAgregar")
                                    {
                                        ((Button)x).Enabled = true;
                                        ((Button)x).Visible = true;
                                    }
                                    if (((Button)x).Name == "btnGuardar")
                                    {
                                        ((Button)x).Enabled = false;
                                        ((Button)x).Visible = false;
                                    }
                                    if (((Button)x).Name == "btnModificar")
                                    {
                                        ((Button)x).Enabled = true;
                                        ((Button)x).Visible = true;
                                    }
                                    if (((Button)x).Name == "btnGuardarCambios")
                                    {
                                        ((Button)x).Enabled = false;
                                        ((Button)x).Visible = false;
                                    }
                                    if (((Button)x).Name == "btnCancelar")
                                    {
                                        ((Button)x).Enabled = false;
                                        ((Button)x).Visible = false;
                                    }
                                    if (((Button)x).Name == "btnEliminar")
                                    {
                                        ((Button)x).Enabled = true;
                                        ((Button)x).Visible = true;
                                    }
                                }
                            }
                        }
                    }
                    break;

                case "btnCancelar":
                    foreach (Control c in faux.Controls)
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

                            if (((Button)c).Name == "btnLimpiar")
                            {
                                ((Button)c).Enabled = false;
                                ((Button)c).Visible = false;

                            }

                            if (((Button)c).Name == "btnFecha")
                            {
                                ((Button)c).Enabled = false;
                                ((Button)c).Visible = false;

                            }
                        }
                    }
                    break;

                   case "btnEliminar":
                    foreach (Control c in faux.Controls)
                    {

                    }
                    break;


            }
        }
    }
}

