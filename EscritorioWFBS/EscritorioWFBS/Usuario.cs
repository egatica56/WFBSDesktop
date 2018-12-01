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
    public partial class Usuario : Form
    {
        int id = 0;
        ServidorWFBS.WS_wfbsClient servidor = new ServidorWFBS.WS_wfbsClient();
        public Usuario()
        {
            InitializeComponent();
            Listar();
            //Listar Estados
            cbxEstado.DisplayMember = "Descripcion";
            cbxEstado.ValueMember = "id";
            cbxEstado.DataSource = servidor.listarEstados();
                  
           // Listar Tipo Usuarios
            cbxTipo.DisplayMember = "Nombre";
            cbxTipo.ValueMember = "Id_tipoUsuario";
            cbxTipo.DataSource = servidor.listarTiposUsuarios();
            
            //Listar Rut Personas
            cbxPersona.DisplayMember = "rut_persona";
            cbxPersona.ValueMember = "rut";
            cbxPersona.DataSource = servidor.listarPersona();

            btnAgregar.Enabled = true;
        }

        private void clear()
        {
            id = 0;
            txtUsername.Text = "";
            txtPass.Text = "";
            cbxTipo.SelectedIndex = 0;
            cbxPersona.SelectedIndex = 0;
            cbxEstado.SelectedIndex = 0;
            btnAgregar.Enabled = true;
        }

        public void Listar()
        {
            try
            {

                foreach (var item in servidor.listarUsuarios())
                {
                    dgvUsuario.Update();
                    int i = dgvUsuario.Rows.Add();
                    var row = dgvUsuario.Rows[i];
                    row.Cells["Id"].Value = item.id_usuario;
                    row.Cells["Username"].Value = item.username;
                    row.Cells["Password"].Value = item.password;
                    row.Cells["Tipo"].Value = item.id_tipo_usuario;
                    row.Cells["Rut"].Value = item.rut_persona;
                    row.Cells["Estado"].Value = item.id_estado;
                }

            }
            catch (Exception ex)
            {
                Console.Write("error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           /* try
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
            { }*/
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                try
                {
                    String username = txtUsername.Text;
                    String pass = txtPass.Text;
                    int tipo = Convert.ToInt32(cbxTipo.SelectedValue.ToString());
                    int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                    String rut = cbxPersona.Text;
                    bool respuesta;
                    respuesta = servidor.modificarUsuario(id, username, pass, tipo, rut, estado);

                    if (respuesta == true)
                    {
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    { MessageBox.Show("No se pudo modificar"); }
                    dgvUsuario.Rows.Clear();
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
            if (txtUsername.Text != "" )
            {
                try
                {
                    String username = txtUsername.Text;
                    String pass = txtPass.Text;
                    int tipo = Convert.ToInt32(cbxTipo.SelectedValue.ToString());
                    int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                    String rut = cbxPersona.Text;
                    bool respuesta;
                    respuesta = servidor.insertarUsuario( username, pass, tipo, rut, estado);

                    if (respuesta == true)
                    {
                        MessageBox.Show("Agregado correctamente");
                    }
                    else
                    { MessageBox.Show("No se pudo modificar"); }
                    dgvUsuario.Rows.Clear();
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

        private void dgvUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value.ToString());
                txtUsername.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
                txtPass.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
                cbxTipo.SelectedValue = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[3].Value.ToString());
                cbxPersona.Text = dgvUsuario.CurrentRow.Cells[4].Value.ToString();
                cbxEstado.SelectedValue = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[5].Value.ToString());
                btnAgregar.Enabled = false;
            }
        }
    }
}
