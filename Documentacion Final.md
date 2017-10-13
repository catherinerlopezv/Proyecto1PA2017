Proyecto 1 (SysLey)
===================

Proposito
-------------
El congreso de la república de Goathemala se ha percatado que una de las mayores deficiencias
al momento de emitir los votos en el hemiciclo parlamentario es el desconocimiento de
las leyes del país.
Por tal motivo, ha solicitado su apoyo como futuro ingeniero de software para el diseño y
desarrollo del sistema denominado:
Sistema de control y préstamo de leyes y reglamentos de la republica - SisLey
El objetivo de este sistema es que cualquier diputado y/o asesor de diputado tenga a su disposición
una biblioteca completa de leyes y reglamentos del país bajo la premisa de que mientras
mejor acceso tengan a las leyes, sus votos mejoraran.
![enter image description here](https://lh3.googleusercontent.com/-tjuSFKHNOfg/WeAdT6YdU0I/AAAAAAAAAZ4/35z7uESpuFMZgv5OyKgGfaSyy62-bf1BQCLcBGAs/s0/Ahora.png "Ahora.png")	

Ambito del sistema
-------------
El programa SisLey está construido para el sistema Windows, un entorno bastante común y de fácil uso para la mayoría de las personas, está programado en C# y utiliza el componente grafico de Winforms para su funcionamiento 

----------


Funciones del producto
-------------------

![enter image description here](https://lh3.googleusercontent.com/-zJglDWxW1kA/WeAmQkbqZFI/AAAAAAAAAaM/fESx_VJYA7cCNstPemHNU49k43I6m-OzgCLcBGAs/s0/Captura+de+pantalla+%252876%2529.png "Captura de pantalla &#40;76&#41;.png")


Caracteristicas de los usuarios
-------------------
![enter image description here](https://lh3.googleusercontent.com/-MTHqIAUCI00/WeAn4aSeauI/AAAAAAAAAac/HK9uh53q08cqfhUFhtK71rbUxQZm2gxZgCLcBGAs/s0/Captura+de+pantalla+%252877%2529.png "Captura de pantalla &#40;77&#41;.png")
Diseño de alto nivel
-------------------


![enter image description here](https://lh3.googleusercontent.com/-ugHAGAdAOMs/WeAqzrCBLTI/AAAAAAAAAas/yqW90ymyKw8AWRI93CCQzVFfBEDZYSxDwCLcBGAs/s0/Clases.png "Clases.png")

Codigo 
-------------------

        public partial class SisLeyMdiForm : Form
    {

        private SisLey sistema;
        
        public SisLeyMdiForm()
        {
            InitializeComponent();
        }

        private void SisLey_Load(object sender, EventArgs e)
        {
            sistema = SisLey.getInstance();
            sistema.initializeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosFrm newMDIChild = new UsuariosFrm();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeyesFrm newMDIChild = new LeyesFrm();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        public void DeshabilitarOpciones()
        {
            OpcionUsuarios.Enabled = false;
            OpcionLeyes.Enabled = false;
            OpcionPrestamo.Enabled = false;
            
        }

        public void HabilitarAdministrador()
        {
            OpcionUsuarios.Enabled = true;
            OpcionLeyes.Enabled = true;
        }

        public void HabilitarPrestamo()
        {
            OpcionPrestamo.Enabled = true;
            
        }

        private void doLogin_Click(object sender, EventArgs e)
        {
            LoginFrm newMDIChild = new LoginFrm();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void doLogout_Click(object sender, EventArgs e)
        {
            DeshabilitarOpciones();
            doLogin.Enabled = true;
            doLogout.Enabled = false;
            SisLey sistema = SisLey.getInstance();
            sistema.UsuarioAsesor = null;
            sistema.UsuarioParlamentario = null;
            usuarioLabel.Text = "";
            grupoLabel.Text = "";
            tipoLabel.Text = "";
        }

        

        private void OpcionPrestamo_Click(object sender, EventArgs e)
        {
            PrestamoFrm newMDIChild = new PrestamoFrm();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

       
    }
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
            bool encontrado = false;
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

  

        public UsuariosFrm()
        {

            InitializeComponent();

        }

        private void UsuariosFrm_Load(object sender, EventArgs e)
        {
            sistema = SisLey.getInstance();
            refreshDataParlamentarios();
            accion = "";
            accionAsesor = "";
        }


        #region Parlamentarios
      

        private void nuevoParlamentario_Click(object sender, EventArgs e)
        {
            accion = "Nuevo";
            nombre.Text = "";
            usuario.Text = "";
            clave.Text = "";
            OcultaBotonesParlamentario();
        }

        private void OcultaBotonesParlamentario()
        {
            nuevoParlamentario.Visible = false;
            eliminarParlamentario.Visible = false;
            modificarParlamentario.Visible = false;
            grabarParlamentario.Visible = true;
            cancelarParlamentario.Visible = true;

            usuario.Enabled = true;
            nombre.Enabled = true;
            clave.Enabled = true;
        }

        private void MuestraBotonesParlamentario()
        {
            nuevoParlamentario.Visible = true;
            eliminarParlamentario.Visible = true;
            modificarParlamentario.Visible = true;
            grabarParlamentario.Visible = false;
            cancelarParlamentario.Visible = false;

            usuario.Enabled = false;
            nombre.Enabled = false;
            clave.Enabled = false;
        }

        private void refreshDataParlamentarios()
        {
            //limpia el datasource del grid
            //luego reasigna la lista de parlamentarios al datasource
            dgvParlamentarios.DataSource = null;
            if (sistema.Parlamentarios.Count > 0)
            {
                BindingSource bi = new BindingSource();
                bi.DataSource = sistema.Parlamentarios;
                dgvParlamentarios.DataSource = bi;
            }
            dgvParlamentarios.Refresh();


        }

        private void dgvParlamentarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvParlamentarios.SelectedRows.Count > 0)
            {
                int index = dgvParlamentarios.SelectedRows[0].Index;
                parlamentarioSeleccionado = (Parlametario)sistema.Parlamentarios[index];
                nombre.Text = parlamentarioSeleccionado.Nombre;
                usuario.Text = parlamentarioSeleccionado.InUsuario;
                clave.Text = parlamentarioSeleccionado.Clave;
                refreshDataAsesores();
            }
        }

        private void modificarParlamentario_Click(object sender, EventArgs e)
        {
            if (parlamentarioSeleccionado != null)
            {
                accion = "Modificar";
                OcultaBotonesParlamentario();
            }
        }

        private void grabarParlamentario_Click(object sender, EventArgs e)
        {
            if (accion == "Nuevo")
            {
                Parlametario parlametario = new Parlametario();
                var max_value = 0;
                if (sistema.Parlamentarios.Count > 0)
                {
                    max_value = (from Parlametario item in sistema.Parlamentarios
                                 select item.NumGrupo).Max();
                }
                max_value++;
                parlametario.NumGrupo = max_value;
                parlametario.Nombre = nombre.Text;
                parlametario.InUsuario = usuario.Text;
                parlametario.Clave = clave.Text;
                parlametario.CantAsesores = 0;
                sistema.Parlamentarios.Add(parlametario);
                nombre.Text = "";
                usuario.Text = "";
                clave.Text = "";
                refreshDataParlamentarios();
            }
            else if (accion == "Modificar")
            {
                int index = sistema.Parlamentarios.IndexOf(parlamentarioSeleccionado);
                if (index >= 0)
                {
                    parlamentarioSeleccionado.Nombre = nombre.Text;
                    parlamentarioSeleccionado.InUsuario = usuario.Text;
                    parlamentarioSeleccionado.Clave = clave.Text;
                    sistema.Parlamentarios[index] = parlamentarioSeleccionado;
                    refreshDataParlamentarios();
                }
            }
            else if (accion == "Eliminar")
            {
                int index = sistema.Parlamentarios.IndexOf(parlamentarioSeleccionado);
                if (index >= 0)
                {
                    sistema.Parlamentarios.RemoveAt(index);
                    nombre.Text = "";
                    usuario.Text = "";
                    clave.Text = "";
                    refreshDataParlamentarios();
                    parlamentarioSeleccionado = null;
                }
            }

            MuestraBotonesParlamentario();
        }

        private void cancelarParlamentario_Click(object sender, EventArgs e)
        {
            if (parlamentarioSeleccionado != null)
            {
                nombre.Text = parlamentarioSeleccionado.Nombre;
                usuario.Text = parlamentarioSeleccionado.InUsuario;
                clave.Text = parlamentarioSeleccionado.Clave;
            }
            MuestraBotonesParlamentario();
        }

        private void eliminarParlamentario_Click(object sender, EventArgs e)
        {
            if (parlamentarioSeleccionado != null)
            {
                accion = "Eliminar";
                OcultaBotonesParlamentario();
            }
        }

        

        private void nuevoAsesor_Click(object sender, EventArgs e)
        {
            if (parlamentarioSeleccionado == null)
            {
                return;
            } else
            {
                if (parlamentarioSeleccionado.CantAsesores < 8)
                {
                    accionAsesor = "Nuevo";
                    nombreAsesor.Text = "";
                    usuarioAsesor.Text = "";
                    claveAsesor.Text = "";
                    OcultaBotonesAsesor();
                } else
                {
                    MessageBox.Show("Un parlamentario no puede tener mas de 8 asesores");
                }
            }

            
        }

        private void OcultaBotonesAsesor()
        {
            nuevoAsesor.Visible = false;
            eliminarAsesor.Visible = false;
            editarAsesor.Visible = false;
            grabarAsesor.Visible = true;
            cancelarAsesor.Visible = true;

            usuarioAsesor.Enabled = true;
            nombreAsesor.Enabled = true;
            claveAsesor.Enabled = true;
        }
        private void MuestraBotonesAsesor()
        {
            nuevoAsesor.Visible = true;
            eliminarAsesor.Visible = true;
            editarAsesor.Visible = true;
            grabarAsesor.Visible = false;
            cancelarAsesor.Visible = false;

            usuario.Enabled = false;
            nombre.Enabled = false;
            clave.Enabled = false;
        }

        private void refreshDataAsesores()
        {
            //limpia el datasource del grid
            //luego reasigna la lista de asesores al datasource
            dgvAsesores.DataSource = null;
            if (parlamentarioSeleccionado != null)
            {
                if (parlamentarioSeleccionado.Asesores != null) {
                    if (parlamentarioSeleccionado.Asesores.Count > 0)
                    {
                        BindingSource bi = new BindingSource();
                        bi.DataSource = parlamentarioSeleccionado.Asesores;
                        dgvAsesores.DataSource = bi;
                    }
                }
                
                

            }

            dgvAsesores.Refresh();
        }

        private void dgvAsesores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAsesores.SelectedRows.Count > 0)
            {
                int index = dgvAsesores.SelectedRows[0].Index;
                asesorSeleccionado = (Asesor)parlamentarioSeleccionado.Asesores[index];
                nombreAsesor.Text = asesorSeleccionado.Nombre;
                usuarioAsesor.Text = asesorSeleccionado.InUsuario;
                claveAsesor.Text = asesorSeleccionado.Clave;
            }
        }

        private void editarAsesor_Click(object sender, EventArgs e)
        {
            if (asesorSeleccionado != null)
            {
                accionAsesor = "Modificar";
                OcultaBotonesAsesor();
            }
        }

        private void grabarAsesor_Click(object sender, EventArgs e)
        {
            if (parlamentarioSeleccionado != null)
            {


                if (accionAsesor == "Nuevo")

                {
                   
                    Asesor asesor = new Asesor();
 
                    asesor.Nombre = nombreAsesor.Text;
                    asesor.InUsuario = usuarioAsesor.Text;
                    asesor.Clave = claveAsesor.Text;
                    int index = sistema.Parlamentarios.IndexOf(parlamentarioSeleccionado);
                    if(index>= 0)
                    {
                        if (parlamentarioSeleccionado.Asesores == null)
                        {
                            parlamentarioSeleccionado.Asesores = new ArrayList();
                        }
                        parlamentarioSeleccionado.Asesores.Add(asesor);
                        parlamentarioSeleccionado.CantAsesores++;

                        sistema.Parlamentarios[index] = parlamentarioSeleccionado;

                        nombreAsesor.Text = "";
                        usuarioAsesor.Text = "";
                        claveAsesor.Text = "";
                        refreshDataAsesores();
                    }
                    
                }
                else if (accionAsesor == "Modificar")
                {
                    int index = sistema.Parlamentarios.IndexOf(parlamentarioSeleccionado);
                    if (index >= 0)
                    {
                        int indexAsesor = parlamentarioSeleccionado.Asesores.IndexOf(asesorSeleccionado);
                        asesorSeleccionado.Nombre = nombreAsesor.Text;
                        asesorSeleccionado.InUsuario = usuarioAsesor.Text;
                        asesorSeleccionado.Clave = claveAsesor.Text;
                        parlamentarioSeleccionado.Asesores[indexAsesor] = asesorSeleccionado;

                        sistema.Parlamentarios[index] = parlamentarioSeleccionado;

                        nombreAsesor.Text = "";
                        usuarioAsesor.Text = "";
                        claveAsesor.Text = "";
                        refreshDataAsesores();
                    }
                    
                }
                else if (accionAsesor == "Eliminar")
                {
                    int index = sistema.Parlamentarios.IndexOf(parlamentarioSeleccionado);
                    if (index >= 0)
                    {

                        int indexAsesor = parlamentarioSeleccionado.Asesores.IndexOf(asesorSeleccionado);
                        parlamentarioSeleccionado.Asesores.RemoveAt(indexAsesor);
                        parlamentarioSeleccionado.CantAsesores--;
                        sistema.Parlamentarios[index] = parlamentarioSeleccionado;
                        nombreAsesor.Text = "";
                        usuarioAsesor.Text = "";
                        claveAsesor.Text = "";
                        refreshDataAsesores();
                        asesorSeleccionado = null;
                    }
                }

                MuestraBotonesAsesor();


            }
        }

        private void cancelarAsesor_Click(object sender, EventArgs e)
        {

            if (parlamentarioSeleccionado != null)
            {
                nombreAsesor.Text = parlamentarioSeleccionado.Nombre;
                usuarioAsesor.Text = parlamentarioSeleccionado.InUsuario;
                claveAsesor.Text = parlamentarioSeleccionado.Clave;
            }
            MuestraBotonesAsesor();

        }

        private void eliminarAsesor_Click(object sender, EventArgs e)
        {
            if (asesorSeleccionado != null)
            {
                accionAsesor = "Eliminar";
                OcultaBotonesAsesor();
            }
        }
    }
       public partial class LeyesFrm : Form
    {

        private SisLey sistema;
        private Ley leySeleccionado;
        private Reglamento reglamentoSeleccionado;
        private string accion;
        private string accionReglamento;

#region leyes
        public LeyesFrm()
        {
            InitializeComponent();
        }

        private void Leyes_Load(object sender, EventArgs e)
        {
            sistema = SisLey.getInstance();
            refreshDataLeys();
            accion = "";
        }

        private void nuevaLey_Click(object sender, EventArgs e)
        {
            accion = "Nuevo";
            titulo.Text = "";
            fechaCreacion.Value = DateTime.Today;
            contenido.Text = "";
            
            OcultaBotonesLey();
        }

        private void OcultaBotonesLey()
        {
            nuevaLey.Visible = false;
            eliminarLey.Visible = false;
            modificarLey.Visible = false;
            grabarLey.Visible = true;
            cancelarLey.Visible = true;

            titulo.Enabled = true;
            fechaCreacion.Enabled = true;
            contenido.Enabled = true;
            
        }

        private void MuestraBotonesLey()
        {
            nuevaLey.Visible = true;
            eliminarLey.Visible = true;
            modificarLey.Visible = true;
            grabarLey.Visible = false;
            cancelarLey.Visible = false;

            titulo.Enabled = false;
            fechaCreacion.Enabled = false;
            contenido.Enabled = false;
        }

        private void refreshDataLeys()
        {
            //limpia el datasource del grid
            //luego reasigna la lista de Leys al datasource
            dgvLeyes.DataSource = null;
            if (sistema.Leyes.Count > 0)
            {
                BindingSource bi = new BindingSource();
                bi.DataSource = sistema.Leyes;
                dgvLeyes.DataSource = bi;
            }
            dgvLeyes.Refresh();


        }

        private void dgvLeyes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void modificarLey_Click(object sender, EventArgs e)
        {
            if (leySeleccionado != null)
            {
                accion = "Modificar";
                OcultaBotonesLey();
            }
        }

        private void grabarLey_Click(object sender, EventArgs e)
        {
            if (accion == "Nuevo")
            {
                Ley ley = new Ley();
                var max_value = 0;
                if (sistema.Leyes.Count > 0)
                {
                    max_value = (from Ley item in sistema.Leyes
                                 select item.NumeroDocumento).Max();
                }
                max_value++;
                ley.NumeroDocumento = max_value;
                ley.NumCopias = 5;
                ley.CopiasDisponibles = 5;
                ley.Titulo = titulo.Text;
                ley.FechaCreacion = fechaCreacion.Value;
                ley.Contenido = contenido.Text;
                ley.CantReglamentos = 0;
                ley.ColaCopias.Add(1);
                ley.ColaCopias.Add(2);
                ley.ColaCopias.Add(3);
                ley.ColaCopias.Add(4);
                ley.ColaCopias.Add(5);
                sistema.Leyes.Add(ley);
                titulo.Text = "";
                fechaCreacion.Value = DateTime.Today;
                contenido.Text = "";
                refreshDataLeys();
            }
            else if (accion == "Modificar")
            {
                int index = sistema.Leyes.IndexOf(leySeleccionado);
                if (index >= 0)
                {
                    leySeleccionado.Titulo = titulo.Text;
                    leySeleccionado.FechaCreacion = fechaCreacion.Value;
                    leySeleccionado.Contenido = contenido.Text;
                    sistema.Leyes[index] = leySeleccionado;
                    refreshDataLeys();
                }
            }
            else if (accion == "Eliminar")
            {
                int index = sistema.Leyes.IndexOf(leySeleccionado);
                if (index >= 0)
                {
                    sistema.Leyes.RemoveAt(index);
                    titulo.Text = "";
                    fechaCreacion.Value = DateTime.Today;
                    contenido.Text = "";
                    refreshDataLeys();
                    leySeleccionado = null;
                }
            }

            MuestraBotonesLey();

        }

        private void cancelarLey_Click(object sender, EventArgs e)
        {
            if (leySeleccionado != null)
            {
                titulo.Text = leySeleccionado.Titulo;
                fechaCreacion.Value = leySeleccionado.FechaCreacion;
                contenido.Text = leySeleccionado.Contenido;
            }
            MuestraBotonesLey();

        }

        private void eliminarLey_Click(object sender, EventArgs e)
        {
            if (leySeleccionado != null)
            {
                accion = "Eliminar";
                OcultaBotonesLey();
            }
        }
        #endregion
        private void nuevoReglamento_Click(object sender, EventArgs e)
        {
            accionReglamento = "Nuevo";
            tituloReglamento.Text = "";
            fechaCreacionReglamento.Value = DateTime.Today;
            contenidoReglamento.Text = "";
            OcultaBotonesReglamento();
        }

        private void OcultaBotonesReglamento()
        {
            nuevoReglamento.Visible = false;
            eliminarReglamento.Visible = false;
            editarReglamento.Visible = false;
            grabarReglamento.Visible = true;
            cancelarReglamento.Visible = true;

            tituloReglamento.Enabled = true;
           fechaCreacionReglamento.Enabled = true;
            contenidoReglamento.Enabled = true;
        }
        private void MuestraBotonesReglamento()
        {
            nuevoReglamento.Visible = true;
            eliminarReglamento.Visible = true;
            editarReglamento.Visible = true;
            grabarReglamento.Visible = false;
            cancelarReglamento.Visible = false;

            tituloReglamento.Enabled = false;
            fechaCreacionReglamento.Enabled = false;
            contenidoReglamento.Enabled = false;
        }

        private void refreshDataReglamentos()
        {
            //limpia el datasource del grid
            //luego reasigna la lista de Reglamentoes al datasource
            dgvReglamentos.DataSource = null;
            if (leySeleccionado != null)
            {
                if (leySeleccionado.Reglamentos != null)
                {
                    if (leySeleccionado.Reglamentos.Count > 0)
                    {
                        BindingSource bi = new BindingSource();
                        bi.DataSource = leySeleccionado.Reglamentos;
                        dgvReglamentos.DataSource = bi;
                    }
                }



            }

            dgvReglamentos.Refresh();
        }

        private void dgvReglamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void editarReglamento_Click(object sender, EventArgs e)
        {
            if (reglamentoSeleccionado != null)
            {
                accionReglamento = "Modificar";
                OcultaBotonesReglamento();
            }
        }

        private void grabarReglamento_Click(object sender, EventArgs e)
        {
            if (leySeleccionado != null)
            {


                if (accionReglamento == "Nuevo")

                {
                    Reglamento reglamento = new Reglamento();

                    var max_value = leySeleccionado.NumeroDocumento * 1000;
                    if (leySeleccionado.Reglamentos.Count > 0)
                    {
                        max_value = (from Reglamento item in leySeleccionado.Reglamentos
                                     select item.NumeroDocumento).Max();
                    }
                    max_value++;
                    reglamento.NumeroDocumento = max_value;
                    reglamento.NumCopias = 5;
                    reglamento.CopiasDisponibles = 5;
                    reglamento.ColaCopias.Add(1);
                    reglamento.ColaCopias.Add(2);
                    reglamento.ColaCopias.Add(3);
                    reglamento.ColaCopias.Add(4);
                    reglamento.ColaCopias.Add(5);
                    

                    reglamento.Titulo = tituloReglamento.Text;
                    reglamento.FechaCreacion = fechaCreacionReglamento.Value;
                    reglamento.Contenido = contenidoReglamento.Text;
                    int index = sistema.Leyes.IndexOf(leySeleccionado);
                    if (index >= 0)
                    {
                        leySeleccionado.Reglamentos.Add(reglamento);
                        leySeleccionado.CantReglamentos++;

                        sistema.Leyes[index] = leySeleccionado;

                        tituloReglamento.Text = "";
                        fechaCreacionReglamento.Value = DateTime.Today;
                        contenidoReglamento.Text = "";
                        refreshDataReglamentos();
                    }

                }
                else if (accionReglamento == "Modificar")
                {
                    int index = sistema.Leyes.IndexOf(leySeleccionado);
                    if (index >= 0)
                    {
                        int indexReglamento = leySeleccionado.Reglamentos.IndexOf(reglamentoSeleccionado);
                        reglamentoSeleccionado.Titulo =tituloReglamento.Text;
                        reglamentoSeleccionado.FechaCreacion = fechaCreacionReglamento.Value;
                        reglamentoSeleccionado.Contenido = contenidoReglamento.Text;
                        leySeleccionado.Reglamentos[indexReglamento] = reglamentoSeleccionado;

                        sistema.Leyes[index] = leySeleccionado;

                        tituloReglamento.Text = "";
                        fechaCreacionReglamento.Value = DateTime.Today;
                        contenidoReglamento.Text = "";
                        refreshDataReglamentos();
                    }

                }
                else if (accionReglamento == "Eliminar")
                {
                    int index = sistema.Leyes.IndexOf(leySeleccionado);
                    if (index >= 0)
                    {

                        int indexReglamento = leySeleccionado.Reglamentos.IndexOf(reglamentoSeleccionado);
                        leySeleccionado.Reglamentos.RemoveAt(indexReglamento);
                        leySeleccionado.CantReglamentos--;
                        sistema.Leyes[index] = leySeleccionado;
                        tituloReglamento.Text = "";
                        fechaCreacionReglamento.Value = DateTime.Today;
                        contenidoReglamento.Text = "";
                        refreshDataReglamentos();
                        reglamentoSeleccionado = null;
                    }
                }

                MuestraBotonesReglamento();


            }

        }

        private void cancelarReglamento_Click(object sender, EventArgs e)
        {
            if (leySeleccionado != null)
            {
                tituloReglamento.Text = leySeleccionado.Titulo;
                fechaCreacionReglamento.Value = leySeleccionado.FechaCreacion;
                contenidoReglamento.Text = leySeleccionado.Contenido;
            }
            MuestraBotonesReglamento();
        }

        private void eliminarReglamento_Click(object sender, EventArgs e)
        {
            if (reglamentoSeleccionado != null)
            {
                accionReglamento = "Eliminar";
                OcultaBotonesReglamento();
            }
        }

        private void dgvLeyes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLeyes.SelectedRows.Count > 0)
            {
                int index = dgvLeyes.SelectedRows[0].Index;
                leySeleccionado = (Ley)sistema.Leyes[index];
                titulo.Text = leySeleccionado.Titulo;
                fechaCreacion.Value = leySeleccionado.FechaCreacion;
                contenido.Text = leySeleccionado.Contenido;
                refreshDataReglamentos();
            }
        }

        private void dgvReglamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReglamentos.SelectedRows.Count > 0)
            {
                int index = dgvReglamentos.SelectedRows[0].Index;
                reglamentoSeleccionado = (Reglamento)leySeleccionado.Reglamentos[index];
                tituloReglamento.Text = reglamentoSeleccionado.Titulo;
                fechaCreacionReglamento.Value = reglamentoSeleccionado.FechaCreacion;
                contenidoReglamento.Text = reglamentoSeleccionado.Contenido;
            }
        }
    }
     public partial class PrestamoFrm : Form
    {

        private SisLey sistema;
        private ArrayList busquedaLeyes;
        private ArrayList busquedaReglamentos;
        private Ley leySeleccionado;
        private Reglamento reglamentoSeleccionado;
        private Prestamo prestamoLeySeleccionado;
        private Prestamo prestamoReglamentoSeleccionado;

        public PrestamoFrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sistema.Leyes.Count > 0)
            {
                if (String.IsNullOrEmpty(filtroLeyes.Text))
                {
                    busquedaLeyes = sistema.Leyes;
                } else
                {
                    busquedaLeyes = new ArrayList();
                    foreach (Ley item in sistema.Leyes) {
                        if (item.Titulo.ToLower().Contains(filtroLeyes.Text.ToLower()))
                        {
                            busquedaLeyes.Add(item);
                        }

                    }
                }
                refreshDataBusquedaLeyes();
            }
        }

        private void PrestamoFrm_Load(object sender, EventArgs e)
        {
            sistema = SisLey.getInstance();
            busquedaLeyes = new ArrayList();
            busquedaReglamentos = new ArrayList();
            refreshDataPrestamoLeyes();
            refreshDataPrestamoReglamentos();
        }

        private void refreshDataBusquedaLeyes()
        {
            //limpia el datasource del grid
            //luego reasigna la lista de parlamentarios al datasource
            dvgLeyes.DataSource = null;
            if (busquedaLeyes.Count > 0)
            {
                BindingSource bi = new BindingSource();
                bi.DataSource = busquedaLeyes;
                dvgLeyes.DataSource = bi;
            }
            dvgLeyes.Refresh();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (leySeleccionado != null)
            {
                if (leySeleccionado.Reglamentos.Count > 0)
                {
                    if (String.IsNullOrEmpty(filtroReglamentos.Text))
                    {
                        busquedaReglamentos = leySeleccionado.Reglamentos;
                    }
                    else
                    {
                        busquedaReglamentos = new ArrayList();
                        foreach (Reglamento item in leySeleccionado.Reglamentos)
                        {
                            if (item.Titulo.ToLower().Contains(filtroReglamentos.Text.ToLower()))
                            {
                                busquedaReglamentos.Add(item);
                            }

                        }
                    }
                    refreshDataBusquedaReglamentos();
                }
            }
            
        }

        private void refreshDataBusquedaReglamentos()
        {
            //limpia el datasource del grid
            //luego reasigna la lista de parlamentarios al datasource
            dvgReglamentos.DataSource = null;
            if (busquedaReglamentos.Count > 0)
            {
                BindingSource bi = new BindingSource();
                bi.DataSource = busquedaReglamentos;
                dvgReglamentos.DataSource = bi;
            }
            dvgReglamentos.Refresh();


        }

        private void refreshDataPrestamoLeyes()
        {
            //limpia el datasource del grid
            //luego reasigna la lista de parlamentarios al datasource
            dvgPrestamosLey.DataSource = null;
            if (sistema.PrestamoLeyes.Count > 0)
            {
                BindingSource bi = new BindingSource();
                if (historialPrestamos.Checked)
                {
                    bi.DataSource = sistema.PrestamoLeyes;
                } else if (informeXley.Checked)
                {
                    ArrayList pl = new ArrayList();
                    foreach (Prestamo item in sistema.PrestamoLeyes)
                    {
                        if (item.NumeroDocumento == numeroLeyoGrupo.Value)
                        {
                            pl.Add(item);
                        }
                    }
                    bi.DataSource = pl;
                }
                else
                {
                    ArrayList pl = new ArrayList();
                    foreach (Prestamo item in sistema.PrestamoLeyes)
                    {
                        if (item.NumGrupo == numeroLeyoGrupo.Value)
                        {
                            pl.Add(item);
                        }
                    }
                    bi.DataSource = pl;
                }
                
                dvgPrestamosLey.DataSource = bi;
            }
            dvgPrestamosLey.Refresh();


        }

        private void refreshDataPrestamoReglamentos()
        {
            //limpia el datasource del grid
            //luego reasigna la lista de parlamentarios al datasource
            dgvPrestamosReglamento.DataSource = null;
            if (sistema.PrestamoReglamentos.Count > 0)
            {
                BindingSource bi = new BindingSource();
                if (historialPrestamos.Checked)
                {
                    bi.DataSource = sistema.PrestamoReglamentos;
                }
                else if (informeXley.Checked)
                {
                    ArrayList pl = new ArrayList();
                    foreach (Prestamo item in sistema.PrestamoReglamentos)
                    {
                        if (item.NumeroDocumentoMaestro == numeroLeyoGrupo.Value)
                        {
                            pl.Add(item);
                        }
                    }
                    bi.DataSource = pl;
                }
                else
                {
                    ArrayList pl = new ArrayList();
                    foreach (Prestamo item in sistema.PrestamoReglamentos)
                    {
                        if (item.NumGrupo == numeroLeyoGrupo.Value)
                        {
                            pl.Add(item);
                        }
                    }
                    bi.DataSource = pl;
                }
                dgvPrestamosReglamento.DataSource = bi;
            }
            dgvPrestamosReglamento.Refresh();


        }

        private void dvgLeyes_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgLeyes.SelectedRows.Count > 0)
            {
                int index = dvgLeyes.SelectedRows[0].Index;
                leySeleccionado = (Ley)busquedaLeyes[index];
                
                refreshDataBusquedaReglamentos();
            }
        }

        private void dvgReglamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgReglamentos.SelectedRows.Count > 0)
            {
                int index = dvgReglamentos.SelectedRows[0].Index;
                reglamentoSeleccionado = (Reglamento)busquedaReglamentos[index];

            }
        }

  

        private void button3_Click(object sender, EventArgs e)
        {
            if (leySeleccionado != null)
            {
                //busca si el documento fue prestando por el mismo grupo
                
                int conteo = 0;
                foreach (Prestamo item in sistema.PrestamoLeyes)
                {
                    if (item.NumeroDocumento == leySeleccionado.NumeroDocumento )
                    {
                        if (item.NumGrupo == sistema.UsuarioParlamentario.NumGrupo)
                        {
                            if (item.Estado == "Prestado")
                            {
                                conteo++;
                            }
                        }
                    }
                }
                foreach (Reglamento itemRL in leySeleccionado.Reglamentos)
                {

                    foreach (Prestamo itemR in sistema.PrestamoReglamentos)
                    {
                        if (itemRL.NumeroDocumento == itemR.NumeroDocumento)
                        {
                            if (itemR.NumGrupo == sistema.UsuarioParlamentario.NumGrupo)
                            {
                                if (itemR.Estado == "Prestado")
                                {
                                    conteo++;
                                }
                            }
                        }
                    }
                }

                if (conteo >= 2)
                {
                    MessageBox.Show("Cada grupo solo puede tener maximo 2 copias de una ley o sus reglamentos");
                } else
                {
                    if (leySeleccionado.CopiasDisponibles <= 0)
                    {
                        MessageBox.Show("Ya no hay copias disponibles de la Ley");
                        return;
                    }

                    foreach (Reglamento itemR in leySeleccionado.Reglamentos)
                    {
                        if (itemR.CopiasDisponibles <= 0)
                        {
                            MessageBox.Show("Ya no hay copias disponibles del reglamento "+ itemR.NumeroDocumento);
                            return;
                        }
                    }

                    Prestamo prestamo = new Prestamo();
                    prestamo.NumeroDocumento = leySeleccionado.NumeroDocumento;
                    prestamo.NumGrupo = sistema.UsuarioParlamentario.NumGrupo;
                    prestamo.Usuario = (sistema.UsuarioAsesor == null ? sistema.UsuarioParlamentario.InUsuario : sistema.UsuarioAsesor.InUsuario);
                    prestamo.Estado = "Prestado";
                    int index = sistema.Leyes.IndexOf(leySeleccionado);
                    if (index >= 0)
                    {
                        //realiza el prestamo de cada uno de los reglamentos
                        int indexR;
                        for (indexR = 0; indexR < leySeleccionado.Reglamentos.Count; indexR++)
                        {
                            Reglamento itemR = (Reglamento)leySeleccionado.Reglamentos[indexR];
                            Prestamo prestamoR = new Prestamo();
                            prestamoR.NumeroDocumento = itemR.NumeroDocumento;
                            prestamoR.NumGrupo = sistema.UsuarioParlamentario.NumGrupo;
                            prestamoR.Usuario = (sistema.UsuarioAsesor == null ? sistema.UsuarioParlamentario.InUsuario : sistema.UsuarioAsesor.InUsuario);
                            prestamoR.NumeroDocumentoMaestro = leySeleccionado.NumeroDocumento;
                            prestamoR.Estado = "Prestado";
                            itemR.CopiasDisponibles--;
                            prestamoR.NumCopia = Convert.ToInt32(itemR.ColaCopias[0]);
                            itemR.ColaCopias.RemoveAt(0);

                            sistema.PrestamoReglamentos.Add(prestamoR);

                            leySeleccionado.Reglamentos[indexR] = itemR;
                            
                        }

                        leySeleccionado.CopiasDisponibles--;
                        prestamo.NumCopia = Convert.ToInt32(leySeleccionado.ColaCopias[0]);
                        leySeleccionado.ColaCopias.RemoveAt(0);

                        sistema.PrestamoLeyes.Add(prestamo);

                        sistema.Leyes[index] = leySeleccionado;

                        refreshDataPrestamoLeyes();
                        refreshDataPrestamoReglamentos();

                    }
                        
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (leySeleccionado != null && reglamentoSeleccionado != null)
            {
                //busca si el documento fue prestado por el mismo grupo
                    int conteo = 0;
                    foreach (Prestamo item in sistema.PrestamoReglamentos)
                    {
                        if (item.NumeroDocumento == reglamentoSeleccionado.NumeroDocumento)
                        {
                            if (item.NumGrupo == sistema.UsuarioParlamentario.NumGrupo)
                            {
                                if (item.Estado == "Prestado")
                                {
                                    conteo++;
                                }
                        }
                        }
                    }
                    if (conteo >= 2)
                    {
                        MessageBox.Show("Cada grupo solo puede tener maximo 2 copias de una ley o sus reglamentos");
                    }
                    else
                    {
                        if (leySeleccionado.CopiasDisponibles <= 0)
                        {
                            MessageBox.Show("Ya no hay copias disponibles de la Ley");
                            return;
                        }

                        if (reglamentoSeleccionado.CopiasDisponibles <= 0)
                            {
                                MessageBox.Show("Ya no hay copias disponibles del reglamento ");
                                return;
                            }

                        int index = sistema.Leyes.IndexOf(leySeleccionado);
                        Prestamo prestamoR = new Prestamo();
                        prestamoR.NumeroDocumento = reglamentoSeleccionado.NumeroDocumento;
                        prestamoR.NumGrupo = sistema.UsuarioParlamentario.NumGrupo;
                        prestamoR.Usuario = (sistema.UsuarioAsesor == null ? sistema.UsuarioParlamentario.InUsuario : sistema.UsuarioAsesor.InUsuario);
                        prestamoR.NumeroDocumentoMaestro = leySeleccionado.NumeroDocumento;
                        prestamoR.Estado = "Prestado";
                        int indexR = leySeleccionado.Reglamentos.IndexOf(reglamentoSeleccionado);
                        if (indexR >= 0)
                        {
                            reglamentoSeleccionado.CopiasDisponibles--;
                            prestamoR.NumCopia = Convert.ToInt32(reglamentoSeleccionado.ColaCopias[0]);
                            reglamentoSeleccionado.ColaCopias.RemoveAt(0);

                            sistema.PrestamoReglamentos.Add(prestamoR);

                            leySeleccionado.Reglamentos[indexR] = reglamentoSeleccionado;
                            sistema.Leyes[index] = leySeleccionado;

                            refreshDataPrestamoLeyes();
                            refreshDataPrestamoReglamentos();
                        }
                        

                    }
                
            }
        }

        private void dvgPrestamosLey_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dvgPrestamosLey.SelectedRows.Count > 0)
            {
                int index = dvgPrestamosLey.SelectedRows[0].Index;
                prestamoLeySeleccionado = (Prestamo)sistema.PrestamoLeyes[index];

                
            }
        }

        private void dgvPrestamosReglamento_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvPrestamosReglamento.SelectedRows.Count > 0)
            {
                int index = dgvPrestamosReglamento.SelectedRows[0].Index;
                prestamoReglamentoSeleccionado = (Prestamo)sistema.PrestamoReglamentos[index];

                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sistema.UsuarioAsesor == null)
            {
                if (sistema.UsuarioParlamentario.InUsuario.ToLower() != prestamoReglamentoSeleccionado.Usuario.ToLower())
                {
                    MessageBox.Show("Solo puede devolver Reglamento prestado con su usuario");
                    return;
                }
            } else
            {
                if (sistema.UsuarioAsesor.InUsuario.ToLower() != prestamoReglamentoSeleccionado.Usuario.ToLower())
                {
                    MessageBox.Show("Solo puede devolver Reglamento prestado con su usuario");
                    return;
                }
            }

            if (prestamoReglamentoSeleccionado.Estado == "Devuelto")
            {
                MessageBox.Show("El reglamento seleccionado ya fue devuelto");
                return;
            }

            //se devuelve la copia del reglamento
            int index = -1;
            int indexR = -1;
            Ley item;
            Reglamento itemR;
            for (index = 0; index < sistema.Leyes.Count; index++)
            {
                item = (Ley)sistema.Leyes[index];
                if (item.NumeroDocumento == prestamoReglamentoSeleccionado.NumeroDocumentoMaestro)
                {
                    for (indexR = 0; indexR < item.Reglamentos.Count; indexR++)
                    {
                        itemR = (Reglamento)item.Reglamentos[indexR];
                        if (itemR.NumeroDocumento == prestamoReglamentoSeleccionado.NumeroDocumento)
                        {
                            itemR.CopiasDisponibles++; //aumenta copias disponibles
                            itemR.ColaCopias.Add(prestamoReglamentoSeleccionado.NumCopia); //devuelve el numero de copia dejandola al final de la cola
                            item.Reglamentos[indexR] = itemR; //actualiza el reglamento
                            break;
                        }
                    }
                    sistema.Leyes[index] = item; //actualiza la ley
                    break;
                }
            }
            int indexPR = sistema.PrestamoReglamentos.IndexOf(prestamoReglamentoSeleccionado);
            prestamoReglamentoSeleccionado.Estado = "Devuelto";
            sistema.PrestamoReglamentos[indexPR] = prestamoReglamentoSeleccionado;
            refreshDataPrestamoReglamentos();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sistema.UsuarioAsesor == null)
            {
                if (sistema.UsuarioParlamentario.InUsuario.ToLower() != prestamoLeySeleccionado.Usuario.ToLower())
                {
                    MessageBox.Show("Solo puede devolver Ley prestado con su usuario");
                    return;
                }
            }
            else
            {
                if (sistema.UsuarioAsesor.InUsuario.ToLower() != prestamoLeySeleccionado.Usuario.ToLower())
                {
                    MessageBox.Show("Solo puede devolver Ley prestado con su usuario");
                    return;
                }
            }

            if (prestamoLeySeleccionado.Estado == "Devuelto")
            {
                MessageBox.Show("La ley seleccionada ya fue devuelta");
                return;
            }

            //se devuelve la copia de la ley
            int index = -1;
            
            Ley item;
            
            for (index = 0; index < sistema.Leyes.Count; index++)
            {
                item = (Ley)sistema.Leyes[index];
                if (item.NumeroDocumento == prestamoLeySeleccionado.NumeroDocumento)
                {
                    
                    item.CopiasDisponibles++; //aumenta copias disponibles
                    item.ColaCopias.Add(prestamoLeySeleccionado.NumCopia); //devuelve el numero de copia dejandola al final de la cola
                    sistema.Leyes[index] = item; //actualiza la ley
                    break;
                }
            }
            int indexPL = sistema.PrestamoLeyes.IndexOf(prestamoLeySeleccionado);
            prestamoLeySeleccionado.Estado = "Devuelto";
            sistema.PrestamoLeyes[indexPL] = prestamoLeySeleccionado;
            refreshDataPrestamoLeyes();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            refreshDataPrestamoLeyes();
            refreshDataPrestamoReglamentos();
        }
    }
y