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
    public partial class TipoUsuario : Form
    {
        int id = 0;
        ServidorWFBS.WS_wfbsClient servidor = new ServidorWFBS.WS_wfbsClient();
        public TipoUsuario()
        {
            InitializeComponent();
 
            Listar();
            btnAgregar.Enabled = true;

            //Listar Estados
            cbxEstado.DisplayMember = "Descripcion";
            cbxEstado.ValueMember = "id";
            cbxEstado.DataSource = servidor.listarEstados();

        }

        private void clear()
        {
            id = 0;
            txtNombre.Text = "";
            btnAgregar.Enabled = true;
            cbxEstado.SelectedIndex = 0;
        }

        public void Listar()
        {
            try
            {
                foreach (var item in servidor.listarTiposUsuarios())
                {
                    dgvTipoUsuario.Update();
                    int i = dgvTipoUsuario.Rows.Add();
                    var row = dgvTipoUsuario.Rows[i];
                    row.Cells["Id"].Value = item.id_tipoUsuario;
                    row.Cells["Nombre"].Value = item.nombre;
                    row.Cells["Estado"].Value = item.id_estado;

                }

            }
            catch (Exception ex)
            {
                Console.Write("error");
            }


        }
        private void dgvTipoUsuario_Click(object sender, EventArgs e)
        {
            if (dgvTipoUsuario.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgvTipoUsuario.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = dgvTipoUsuario.CurrentRow.Cells[1].Value.ToString();
                cbxEstado.SelectedValue = Convert.ToInt32(dgvTipoUsuario.CurrentRow.Cells[2].Value.ToString());
                btnAgregar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                try
                {

                    bool respuesta;
                    respuesta = servidor.eliminarTipoUsuario(id);

                    if (respuesta == true)
                    {
                        MessageBox.Show("Eliminado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar");
                    }
                    dgvTipoUsuario.Rows.Clear();
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
                MessageBox.Show("No ha seleccionado un id");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                try
                {
                    String nombre = txtNombre.Text;
                    bool respuesta;
                    int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                    respuesta = servidor.modificarTipoUsuario(id, nombre, estado);
                    if (respuesta == true)
                    {
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar");
                    }
                    dgvTipoUsuario.Rows.Clear();
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
            if (txtNombre.Text != "" )
            {
                try
                {
                    String nombre = txtNombre.Text;
                    bool respuesta;
                    int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                    respuesta = servidor.insertarTipoUsuario(nombre, estado);
                    if (respuesta == true)
                    {
                        MessageBox.Show("Agregado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar");
                    }
                    dgvTipoUsuario.Rows.Clear();
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
    }
}
