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
}
