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

        }
    }
}
