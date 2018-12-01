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
    public partial class Nivel : Form
    {
        int id = 0;
        ServidorWFBS.WS_wfbsClient servidor = new ServidorWFBS.WS_wfbsClient();
        public Nivel()
        {
            InitializeComponent();       
            Listar();
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
                foreach (var item in servidor.buscarTodoNivel())
                {
                    dgvNivel.Update();
                    int i = dgvNivel.Rows.Add();
                    var row = dgvNivel.Rows[i];
                    row.Cells["Nota"].Value = item.id_nivel;
                    row.Cells["Nombre"].Value = item.nombre_nota;
                    row.Cells["Estado"].Value = item.id_estado;
                }
            }
            catch (Exception ex)
            {
                Console.Write("error");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNota.Text != "")
            {
                if (txtNombre.Text.Length < 11)
                {
                    try
                    {
                        String nombre_nota = txtNombre.Text;
                        int id = Int32.Parse(txtNota.Text);
                        int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                        bool respuesta;
         
                        respuesta = servidor.insertarNivel(id, nombre_nota, estado);
                        if (respuesta == true)
                        {
                            MessageBox.Show("Agregado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar");
                        }
                        dgvNivel.Rows.Clear();
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
                }else
                { txtNombre.Text = ""; MessageBox.Show("El campo nombre debe tener 10 caracteres como máximo"); }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNota.Text != "")
            {
                try
                {
                    String nombre_nota = txtNombre.Text;
                    int id = Int32.Parse(txtNota.Text);
                    int estado = Convert.ToInt32(cbxEstado.SelectedValue.ToString());
                    bool respuesta;
                 
                    respuesta = servidor.modificarNivel(id, nombre_nota, estado);

                    if (respuesta == true)
                    {
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    { MessageBox.Show("No se pudo modificar"); }
                    dgvNivel.Rows.Clear();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
                try
                {

                    bool respuesta;
                   
                    respuesta = servidor.eliminarNivel(id);

                    if (respuesta == true)
                    {
                        MessageBox.Show("Eliminado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar");
                    }
                    dgvNivel.Rows.Clear();
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

        private void txtLimpiar_Click(object sender, EventArgs e)
        {

            clear();
        }
        private void clear()
        {
            id = 0;
            txtNombre.Text = "";
            txtNota.Text = "";
            btnAgregar.Enabled = true;
            cbxEstado.SelectedIndex = 0;
        }



        private void dgvNivel_Click(object sender, EventArgs e)
        {
            if (dgvNivel.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgvNivel.CurrentRow.Cells[0].Value.ToString());
                txtNota.Text = dgvNivel.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvNivel.CurrentRow.Cells[1].Value.ToString();
                cbxEstado.SelectedValue = Convert.ToInt32(dgvNivel.CurrentRow.Cells[2].Value.ToString());
                btnAgregar.Enabled = false;
            }
        }
    }
}
