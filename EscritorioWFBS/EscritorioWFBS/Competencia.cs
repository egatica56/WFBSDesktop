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
    public partial class Competencia : Form
    {
        int id = 0;
        ServidorWFBS.WS_wfbsClient servidor = new ServidorWFBS.WS_wfbsClient();
        public Competencia()
        {
            InitializeComponent();
            //Listar Nivel
            cbxNivel.DisplayMember = "id_nivel";
            cbxNivel.ValueMember = "id_nivel";
            cbxNivel.DataSource = servidor.buscarTodoNivel();
            Listar();
            //Listar Estados
            cbxEstado.DisplayMember = "Descripcion";
            cbxEstado.ValueMember = "id";
            cbxEstado.DataSource = servidor.listarEstados();
            btnAgregar.Enabled = true;
        }


        private void txtLimpiar_Click(object sender, EventArgs e)
        {

            clear();
        }
        private void clear()
        {
            id = 0;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtSigla.Text = "";
            cbxNivel.SelectedIndex = 0;
            btnAgregar.Enabled = true;
            cbxEstado.SelectedIndex = 0;
        }


        public void Listar()
        {
            try
            {
                foreach (var item in servidor.listarCompetencia())
                {
                    dgvCompetencia.Update();
                    int i = dgvCompetencia.Rows.Add();
                    var row = dgvCompetencia.Rows[i];
                    row.Cells["Identificador"].Value = item.id_comp;
                    row.Cells["Nombre"].Value = item.nombre_competencia;
                    row.Cells["Sigla"].Value = item.sigla_competencia;
                    row.Cells["Nivel"].Value = item.id_nivel;
                    row.Cells["Descripción"].Value = item.descripcion_competencia;
                    row.Cells["Estado"].Value = item.id_estado;
                }
            }
            catch (Exception ex)
            {
                Console.Write("error");
            }

        }


        private void dgvCompetencia_Click_1(object sender, EventArgs e)
        {
            if (dgvCompetencia.CurrentRow.Index != -1)
            {

                id = Convert.ToInt32(dgvCompetencia.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = dgvCompetencia.CurrentRow.Cells[1].Value.ToString();
                txtSigla.Text = dgvCompetencia.CurrentRow.Cells[2].Value.ToString();
                cbxNivel.SelectedValue = Convert.ToInt32(dgvCompetencia.CurrentRow.Cells[3].Value.ToString());
                txtDescripcion.Text = dgvCompetencia.CurrentRow.Cells[4].Value.ToString();
                cbxEstado.SelectedValue = Convert.ToInt32(dgvCompetencia.CurrentRow.Cells[5].Value.ToString());
                btnAgregar.Enabled = false;
            }
        }



        private void txtLimpiar_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDescripcion.Text != "" && txtSigla.Text != "")
            {
                if (txtSigla.Text.Length < 6)
                {
                    try
                    {

                        String nombre = txtNombre.Text;
                        String descripcion = txtDescripcion.Text;
                        String sigla = txtSigla.Text;
                        int nivel = Convert.ToInt32(cbxNivel.SelectedValue.ToString());
                        int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                        bool respuesta;
                        respuesta = servidor.insertarCompetencia(nombre, descripcion, sigla, nivel, estado);
                        if (respuesta == true)
                        {
                            MessageBox.Show("Agregado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar");
                        }
                        dgvCompetencia.Rows.Clear();
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

                else { txtSigla.Text = ""; MessageBox.Show("El campo sigla debe ser menor a 6"); }
            }
            else
            {

                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDescripcion.Text != "" && txtSigla.Text != "")
            {
                if (txtSigla.Text.Length < 6)
                {
                    try
                    {
                        String nombre = txtNombre.Text;
                        String descripcion = txtDescripcion.Text;
                        String sigla = txtSigla.Text;
                        int nivel = Int32.Parse(cbxNivel.Text);
                        int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                        bool respuesta;
                        respuesta = servidor.modificarCompetencia(id, nombre, descripcion, sigla, nivel, estado);

                        if (respuesta == true)
                        {
                            MessageBox.Show("Modificiado correctamente");
                        }
                        else
                        { MessageBox.Show("No se pudo modificar"); }
                        dgvCompetencia.Rows.Clear();
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
                else { MessageBox.Show("El campo sigla debe ser menor a 6"); }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (id != 0)
            {
                try
                {

                    bool respuesta;
                    respuesta = servidor.eliminarCompetencia(id);

                    if (respuesta == true)
                    {
                        MessageBox.Show("Eliminado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar");
                    }
                    dgvCompetencia.Rows.Clear();
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
                MessageBox.Show("Seleccione la Competencia a eliminar");
            }
        }

    }
}
