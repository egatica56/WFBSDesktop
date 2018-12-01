using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioWFBS
{
    public partial class Perfil : Form
    {
        int id = 0;
        ServidorWFBS.WS_wfbsClient servidor = new ServidorWFBS.WS_wfbsClient();
        public Perfil()
        {
            InitializeComponent();
            Listar();
            btnAgregar.Enabled = true;
            btnComp.Visible = false;
            cbxCompetencias.Visible = false;
            lblComp.Visible = false;
            //Listar Estados
            cbxEstado.DisplayMember = "Descripcion";
            cbxEstado.ValueMember = "id";
            cbxEstado.DataSource = servidor.listarEstados();
        }


        private void clear()
        {
            id = 0;
            txtNombre.Text = "";
            txtAbreviacion.Text = "";
            btnAgregar.Enabled = true;
            cbxEstado.SelectedIndex = 0;
         
        }

        public void Listar()
        {
            try
            {

                foreach (var item in servidor.listarPerfiles())
                {
                    dgvPerfil.Update();
                    int i = dgvPerfil.Rows.Add();
                    var row = dgvPerfil.Rows[i];
                    row.Cells["Identificador"].Value = item.id_perfil;
                    row.Cells["Nombre"].Value = item.nombre_perfil;
                    row.Cells["Abreviacion"].Value = item.abreviacion_perfil;
                    row.Cells["Estado"].Value = item.id_estado;

                }
            }
            catch (Exception ex)
            {
                Console.Write("error");
            }


        }
        private void dgvPerfil_Click(object sender, EventArgs e)
        {
            if (dgvPerfil.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgvPerfil.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = dgvPerfil.CurrentRow.Cells[1].Value.ToString();
                txtAbreviacion.Text = dgvPerfil.CurrentRow.Cells[2].Value.ToString();
                btnAgregar.Enabled = false;
                btnComp.Visible = true;
                cbxCompetencias.Visible = true;
                lblComp.Visible = true;
                //Listar Competencias
                cbxCompetencias.DisplayMember = "nombre_competencia";
                cbxCompetencias.ValueMember = "id_comp";
                cbxCompetencias.DataSource = servidor.listarCompSegunPerfil(id);
                cbxEstado.SelectedValue = Convert.ToInt32(dgvPerfil.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != "" && txtAbreviacion.Text != "")
            {
                try
                {

                    bool respuesta;
                    respuesta = servidor.eliminarPerfil(id);

                    if (respuesta == true)
                    {
                        MessageBox.Show("Eliminado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar");
                    }
                    dgvPerfil.Rows.Clear();
                    Listar();
                    clear();
                    btnAgregar.Enabled = true;
                    btnComp.Visible = false;
                    cbxCompetencias.Visible = false;
                    lblComp.Visible = false;
                }
                catch (Exception ex)
                {
                    Console.Write("error");
                }
                finally
                { }
            }
            else
            { MessageBox.Show("Ingrese los datos"); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtAbreviacion.Text != "")
            {
                try
                {
                    String nombre = txtNombre.Text;
                    String abreviacion = txtAbreviacion.Text;
                    int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                    bool respuesta;
                    respuesta = servidor.modificarPerfil(id, nombre, abreviacion, estado);
                    if (respuesta == true)
                    {
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar");
                    }
                    dgvPerfil.Rows.Clear();
                    Listar();
                    clear();
                    btnAgregar.Enabled = true;
                    btnComp.Visible = false;
                    cbxCompetencias.Visible = false;
                    lblComp.Visible = false;
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
            if (txtNombre.Text != "" && txtAbreviacion.Text != "")
            {
                try
                {
                    String nombre = txtNombre.Text;
                    String abreviacion = txtAbreviacion.Text;
                    int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                    bool respuesta;
                    respuesta = servidor.insertarPerfil(nombre, abreviacion, estado);
                    if (respuesta == true)
                    {
                        MessageBox.Show("Agregado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar");
                    }
                    dgvPerfil.Rows.Clear();
                    Listar();
                    clear();
                    btnAgregar.Enabled = true;
                    btnComp.Enabled = false;
                    cbxCompetencias.Enabled = false;
                    lblComp.Enabled = false;
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

        private void btnComp_Click(object sender, EventArgs e)
        {
            Perfil_Competencia com = new Perfil_Competencia();
            com.Show();
        }

      
    }
}
