using System;
using System.Collections;
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
    public partial class UsuariosFrm : Form
    {
        private SisLey sistema;
        private string accion;
        private Parlametario parlamentarioSeleccionado;
        private Asesor asesorSeleccionado;
        private string accionAsesor;


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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        #endregion
        //Asesores
        private void dgvAsesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvParlamentarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nuevoAsesor_Click(object sender, EventArgs e)
        {
            accionAsesor = "Nuevo";
            nombreAsesor.Text = "";
            usuarioAsesor.Text = "";
            claveAsesor.Text = "";
            OcultaBotonesAsesor();
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
}
