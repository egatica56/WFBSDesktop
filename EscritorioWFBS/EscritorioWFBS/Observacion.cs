using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace EscritorioWFBS
{
    public partial class Observacion : Form
    {
        int id = 0;
        ServidorWFBS.WS_wfbsClient servidor = new ServidorWFBS.WS_wfbsClient();
        public Observacion()
        {
            InitializeComponent();      
            Listar();
            //Listar Competencia
            cbxCompetencia.DisplayMember = "nombre_competencia";
            cbxCompetencia.ValueMember = "id_comp";
            cbxCompetencia.DataSource = servidor.listarCompetencia();
            btnAgregar.Enabled = true;

            //Listar Estados
            cbxEstado.DisplayMember = "Descripcion";
            cbxEstado.ValueMember = "id";
            cbxEstado.DataSource = servidor.listarEstados();
            
        }

        public void Listar()
        {

            try
            {
                foreach (var item in servidor.listarObservaciones())
                {
                    dgvObservacion.Update();
                    int i = dgvObservacion.Rows.Add();
                    var row = dgvObservacion.Rows[i];
                    row.Cells["Identificador"].Value = item.id_observacion;
                    row.Cells["Competencia"].Value = item.id_comp;
                    row.Cells["MensajeSuperior"].Value = item.mensaje_puntaje_superior;
                    row.Cells["MensajeInferior"].Value = item.mensaje_puntaje_inferior;
                    row.Cells["Estado"].Value = item.id_estado;
                }
            }
            catch (Exception ex)
            {
                Console.Write("error");
            }


        }

        private void clear()
        {
            id = 0;
            txtInferior.Text = "";
            txtSuperior.Text = "";
            cbxCompetencia.SelectedIndex = 0;
            btnAgregar.Enabled = true;
            cbxEstado.SelectedIndex = 0;
            
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                bool respuesta;
                respuesta = servidor.eliminarObservacion(id);

                if (respuesta == true)
                {
                    MessageBox.Show("Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar");
                }
                dgvObservacion.Rows.Clear();
                Listar();
                clear();
                btnAgregar.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.Write("error");
            }
            finally
            { }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtSuperior.Text != "" && txtInferior.Text != "")
            {
                try
                {
                    String mensajeSuperior = txtSuperior.Text;
                    String mensajeInferior = txtInferior.Text;
                    int comp = Convert.ToInt32(cbxCompetencia.SelectedValue.ToString());
                    int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                    bool respuesta;
                    respuesta = servidor.modificarObservacion(id, mensajeSuperior, mensajeInferior, comp, estado);
                    if (respuesta == true)
                    {
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar");
                    }
                    dgvObservacion.Rows.Clear();
                    Listar();
                    clear();
                    btnAgregar.Enabled = true;

                }
                catch (Exception ex)
                {
                    Console.Write("error");
                }
                finally
                { }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtSuperior.Text != "" && txtInferior.Text != "" )
            {
                try
                {
                    String mensajeSuperior = txtSuperior.Text;
                    String mensajeInferior = txtInferior.Text;
                    int comp = Convert.ToInt32(cbxCompetencia.SelectedValue.ToString());
                    int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                    bool respuesta;
                    respuesta = servidor.insertarObservacion(mensajeSuperior, mensajeInferior, comp, estado);
                    if (respuesta == true)
                    {
                        MessageBox.Show("Agregado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar");
                    }
                    dgvObservacion.Rows.Clear();
                    Listar();
                    clear();
                    btnAgregar.Enabled = true;

                }
                catch (Exception ex)
                {
                    Console.Write("error");
                }
                finally
                { }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvObservacion_Click(object sender, EventArgs e)
        {
            if (dgvObservacion.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgvObservacion.CurrentRow.Cells[0].Value.ToString());
                cbxCompetencia.SelectedValue = Convert.ToInt32(dgvObservacion.CurrentRow.Cells[1].Value.ToString());
                txtSuperior.Text = dgvObservacion.CurrentRow.Cells[2].Value.ToString();
                txtInferior.Text = dgvObservacion.CurrentRow.Cells[3].Value.ToString();
                cbxEstado.SelectedValue = Convert.ToInt32(dgvObservacion.CurrentRow.Cells[4].Value.ToString());
                btnAgregar.Enabled = false;
            }
        }




    }
}
