using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectro
{
    public partial class LoginFrm : Form
    {
        private string usuario;
        private string clave;

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = usuarioLogin.Text;
            clave = claveLogin.Text;

            if (String.IsNullOrEmpty(usuario) || String.IsNullOrWhiteSpace(usuario))
            {
                errorLogin.Text = "Debe ingresar el usuario";
                return;
            }

            if (String.IsNullOrEmpty(clave) || String.IsNullOrWhiteSpace(clave))
            {
                errorLogin.Text = "Debe ingresar la clave";
                return;
            }

            if (usuario == "admin" && clave != "admin")
            {
                errorLogin.Text = "Clave incorrecta";
                return;
            }

            if (usuario == "admin" && clave == "admin")
            {

                Form p = (Form)this.MdiParent;
                Control[] c = p.Controls.Find("OpcionUsuarios", true);
                Button b = (Button)c[0];
                b.Enabled = true;
                c = p.Controls.Find("OpcionLeyes", true);
                b = (Button)c[0];
                b.Enabled = true;

                c = p.Controls.Find("OpcionPrestamo", true);
                b = (Button)c[0];
                b.Enabled = false;
                c = p.Controls.Find("OpcionDevolucion", true);
                b = (Button)c[0];
                b.Enabled = false;


                c = p.Controls.Find("doLogin", true);
                b = (Button)c[0];
                b.Enabled = false;
                c = p.Controls.Find("doLogout", true);
                b = (Button)c[0];
                b.Enabled = true;

                c = p.Controls.Find("usuarioLabel", true);
                Label l = (Label)c[0];
                l.Text = usuario;

                c = p.Controls.Find("tipoLabel", true);
                l = (Label)c[0];
                l.Text = "administrador";

                c = p.Controls.Find("grupoLabel", true);
                l = (Label)c[0];
                l.Text = "";

                this.Hide();

                return;
            }

            // en otro caso busca en la lista de parlamentarios y asesores
            SisLey sistema = SisLey.getInstance();
            Parlametario parlametario;
            bool encontrado;
            if (sistema.Parlamentarios.Count > 0)
            {
                foreach (Parlametario item in sistema.Parlamentarios)
                {
                    if (item.InUsuario.ToLower() == usuario.ToLower())
                    {
                        if (item.Clave.ToLower() == clave.ToLower())
                        {
                            encontrado = true;
                            sistema.UsuarioParlamentario = item;

                            Form p = (Form)this.MdiParent;
                            Control[] c = p.Controls.Find("OpcionUsuarios", true);
                            Button b = (Button)c[0];
                            b.Enabled = false;
                            c = p.Controls.Find("OpcionLeyes", true);
                            b = (Button)c[0];
                            b.Enabled = false;

                            c = p.Controls.Find("OpcionPrestamo", true);
                            b = (Button)c[0];
                            b.Enabled = true;
                            c = p.Controls.Find("OpcionDevolucion", true);
                            b = (Button)c[0];
                            b.Enabled = true;


                            c = p.Controls.Find("doLogin", true);
                            b = (Button)c[0];
                            b.Enabled = false;
                            c = p.Controls.Find("doLogout", true);
                            b = (Button)c[0];
                            b.Enabled = true;

                            c = p.Controls.Find("usuarioLabel", true);
                            Label l = (Label)c[0];
                            l.Text = usuario;

                            c = p.Controls.Find("tipoLabel", true);
                            l = (Label)c[0];
                            l.Text = "parlamentario";

                            c = p.Controls.Find("grupoLabel", true);
                            l = (Label)c[0];
                            l.Text = Convert.ToString(item.NumGrupo);

                            this.Hide();

                            return;

                        }
                        else
                        {
                            errorLogin.Text = "Clave no coincide";
                            return;
                        }
                    }
                }

                //se valida el login a nivel de asesores
                foreach (Parlametario item in sistema.Parlamentarios)
                {
                    foreach (Asesor itemA in item.Asesores)
                    {
                        if (itemA.InUsuario.ToLower() == usuario.ToLower())
                        {
                            if (itemA.Clave.ToLower() == clave.ToLower())
                            {
                                encontrado = true;
                                sistema.UsuarioParlamentario = item;
                                sistema.UsuarioAsesor = itemA;
                                
                                Form p = (Form)this.MdiParent;
                                Control[] c = p.Controls.Find("OpcionUsuarios", true);
                                Button b = (Button)c[0];
                                b.Enabled = false;
                                c = p.Controls.Find("OpcionLeyes", true);
                                b = (Button)c[0];
                                b.Enabled = false;

                                c = p.Controls.Find("OpcionPrestamo", true);
                                b = (Button)c[0];
                                b.Enabled = true;
                                c = p.Controls.Find("OpcionDevolucion", true);
                                b = (Button)c[0];
                                b.Enabled = true;


                                c = p.Controls.Find("doLogin", true);
                                b = (Button)c[0];
                                b.Enabled = false;
                                c = p.Controls.Find("doLogout", true);
                                b = (Button)c[0];
                                b.Enabled = true;

                                c = p.Controls.Find("usuarioLabel", true);
                                Label l = (Label)c[0];
                                l.Text = usuario;

                                c = p.Controls.Find("tipoLabel", true);
                                l = (Label)c[0];
                                l.Text = "asesor";

                                c = p.Controls.Find("grupoLabel", true);
                                l = (Label)c[0];
                                l.Text = Convert.ToString(item.NumGrupo);

                                this.Hide();

                                return;

                            }
                            else
                            {
                                errorLogin.Text = "Clave no coincide";
                                return;
                            }
                        }
                    }

                }

            }

            errorLogin.Text = "Usuario no encontrado";
        }

        
    }
}

