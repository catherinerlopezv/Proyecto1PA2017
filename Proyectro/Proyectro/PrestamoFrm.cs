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
    public partial class PrestamoFrm : Form
    {

        private SisLey sistema;
        private ArrayList busquedaLeyes;
        private ArrayList busquedaReglamentos;
        private Ley leySeleccionado;
        private Reglamento reglamentoSeleccionado;


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
                bi.DataSource = sistema.PrestamoLeyes;
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
                bi.DataSource = sistema.PrestamoReglamentos;
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

        private void dvgPrestamosLey_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvPrestamosReglamento_SelectionChanged(object sender, EventArgs e)
        {

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
                                conteo++;
                            }
                            foreach (Prestamo itemR in sistema.PrestamoReglamentos)
                            {
                                if (itemR.NumGrupo == sistema.UsuarioParlamentario.NumGrupo)
                                {
                                    conteo++;
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
                        int index = sistema.Leyes.IndexOf(leySeleccionado);
                        if (index >= 0)
                        {
                            leySeleccionado.CopiasDisponibles--;
                            prestamo.NumCopia = Convert.ToInt32(leySeleccionado.ColaCopias[0]);
                            leySeleccionado.ColaCopias.RemoveAt(0);

                            sistema.PrestamoLeyes.Add(prestamo);

                            //realiza el prestamo de cada uno de los reglamentos
                            foreach (Reglamento itemR in leySeleccionado.Reglamentos)
                            {
                                Prestamo prestamoR = new Prestamo();
                                prestamoR.NumeroDocumento = itemR.NumeroDocumento;
                                prestamoR.NumGrupo = sistema.UsuarioParlamentario.NumGrupo;
                                prestamoR.Usuario = (sistema.UsuarioAsesor == null ? sistema.UsuarioParlamentario.InUsuario : sistema.UsuarioAsesor.InUsuario);
                                int indexR = leySeleccionado.Reglamentos.IndexOf(itemR);
                                if (indexR >= 0)
                                {
                                    itemR.CopiasDisponibles--;
                                    prestamoR.NumCopia = Convert.ToInt32(itemR.ColaCopias[0]);
                                    itemR.ColaCopias.RemoveAt(0);

                                    sistema.PrestamoReglamentos.Add(prestamoR);

                                    leySeleccionado.Reglamentos[indexR] = reglamentoSeleccionado;
                                }
                            }

                            
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
                //busca si el documento fue prestando por el mismo grupo
                if (sistema.PrestamoLeyes.Count > 0)
                {
                    int conteo = 0;
                    foreach (Prestamo item in sistema.PrestamoLeyes)
                    {
                        if (item.NumeroDocumento == leySeleccionado.NumeroDocumento)
                        {
                            if (item.NumGrupo == sistema.UsuarioParlamentario.NumGrupo)
                            {
                                conteo++;
                            }
                            foreach (Prestamo itemR in sistema.PrestamoReglamentos)
                            {

                                if (itemR.NumGrupo == sistema.UsuarioParlamentario.NumGrupo)
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
        }
    }
}
