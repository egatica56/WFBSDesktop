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
using System.Globalization;

namespace EscritorioWFBS
{
    public partial class Persona : Form
    {
        String rut = "";
        ServidorWFBS.WS_wfbsClient servidor = new ServidorWFBS.WS_wfbsClient();
        public Persona()
        {
            InitializeComponent();
            

          
                Listar();
                //Listar Sexos
                cbxSexo.DisplayMember = "nombre";
                cbxSexo.ValueMember = "id";
                cbxSexo.DataSource = servidor.listarSexos();


                // Listar Cargos
                cbxTipo.DisplayMember = "Nombre";
                cbxTipo.ValueMember = "Id_tipoUsuario";
                cbxTipo.DataSource = servidor.listarTiposUsuarios();

                //Listar Comunas
                cbxComuna.DisplayMember = "nombre";
                cbxComuna.ValueMember = "id";
                cbxComuna.DataSource = servidor.listarComunas();

                //Listar Perfiles
                cbxPerfil.DisplayMember = "nombre_perfil";
                cbxPerfil.ValueMember = "id_perfil";
                cbxPerfil.DataSource = servidor.listarPerfiles();

                //Listar Rut Personas
                cbxJefe.DisplayMember = "rut_persona";
                cbxJefe.ValueMember = "rut";
                cbxJefe.DataSource = servidor.listarPersona();
            
         
            
            btnAgregar.Enabled = true;

            
        }

        public void Listar()
        {
            try
            {

                foreach (var item in servidor.listarPersona())
                {
                    dgvPersona.Update();
                    int i = dgvPersona.Rows.Add();
                    var row = dgvPersona.Rows[i];

                    row.Cells["RutP"].Value = item.rut_persona;
                    row.Cells["Nombre"].Value = item.nombre_persona;
                    row.Cells["ApellidoPaterno"].Value = item.apellido_paterno;
                    row.Cells["ApellidoMaterno"].Value = item.apellido_materno;
                    row.Cells["Dirección"].Value = item.direccion_persona;
                    row.Cells["Teléfono"].Value = item.telefono_fijo;
                    row.Cells["Celular"].Value = item.telefono_celular;
                    row.Cells["Email"].Value = item.email_persona;
                    row.Cells["Sexo"].Value = item.id_sexo;
                    row.Cells["Comuna"].Value = item.id_comuna;
                    row.Cells["Perfil"].Value = item.id_perfil;
                    row.Cells["Cargo"].Value = item.cargo_persona;
                    row.Cells["Jefe"].Value = item.rut_jefe;
                    //var dtStr = "2011-03-21 13:26";
                    //DateTime? dt = dtStr.toDate("yyyy-MM-dd HH:mm");
                    row.Cells["Nacimiento"].Value = item.fecha_nacimiento;
                }
            }
            catch (Exception ex)
            {
                Console.Write("error");
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(cbxSexo.SelectedValue.ToString());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtRut.Text != "" && txtPaterno.Text != ""
              && txtMaterno.Text != "" && txtDireccion.Text != ""
               && txtFijo.Text != "" && txtCelular.Text != ""
               && txtEmail.Text != "")
            {
                //  if (txtNombre.Text.Length < 11)
                // {
                try
                {
                    String rut = txtRut.Text;
                    MessageBox.Show(rut);
                    String nombre = txtNombre.Text;
                    String paterno = txtPaterno.Text;
                    String materno = txtMaterno.Text;
                    String direccion = txtDireccion.Text;
                    String nacimiento = dt.Value.ToString("yyyy-MM-dd");
                    String fijo = txtFijo.Text;
                    String celular = txtCelular.Text;
                    String email = txtEmail.Text;
                    int sexo = Convert.ToInt32(cbxSexo.SelectedValue.ToString());
                    int comuna = Convert.ToInt32(cbxComuna.SelectedValue.ToString());
                    int perfil = Convert.ToInt32(cbxPerfil.SelectedValue.ToString());
                    String cargo = cbxTipo.Text;
                    String jefe = cbxJefe.Text;

                    bool respuesta;

                    respuesta = servidor.modificarPersona(rut, nombre, paterno, materno, direccion,
                        nacimiento, fijo, celular, email, cargo, sexo, comuna, perfil, jefe);
                    if (respuesta == true)
                    {
                        MessageBox.Show("Modificado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar");
                    }
                    dgvPersona.Rows.Clear();
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
                //  }
                //else
                //{ txtNombre.Text = ""; MessageBox.Show("El campo nombre debe tener 10 caracteres como máximo"); }
            }
            else
            {
                MessageBox.Show("Le falta ingresar un dato");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtRut.Text != "" && txtPaterno.Text != "" 
                && txtMaterno.Text != "" && txtDireccion.Text != ""
                 && txtFijo.Text != "" && txtCelular.Text != ""
                 && txtEmail.Text != "")
            {
              //  if (txtNombre.Text.Length < 11)
               // {
                    try
                    {
                        String rut = txtRut.Text;                     
                        String nombre = txtNombre.Text;
                        String paterno = txtPaterno.Text;
                        String materno = txtMaterno.Text;
                        String direccion = txtDireccion.Text;
                        String nacimiento = dt.Value.ToString("yyyy-MM-dd");
                    
                        String fijo = txtFijo.Text;
                        String celular = txtCelular.Text;
                        String email = txtEmail.Text;
                        int sexo = Convert.ToInt32(cbxSexo.SelectedValue.ToString());
                        int comuna = Convert.ToInt32(cbxComuna.SelectedValue.ToString());
                        int perfil = Convert.ToInt32(cbxPerfil.SelectedValue.ToString());
                        String cargo = cbxTipo.Text;
                        String jefe = cbxJefe.Text;
                        
                        bool respuesta;

                        respuesta = servidor.insertarPersona(rut, nombre, paterno, materno, direccion,
                            nacimiento, fijo, celular, email, cargo, sexo, comuna, perfil, jefe);
                        if (respuesta == true)
                        {
                            MessageBox.Show("Agregado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar");
                        }
                        dgvPersona.Rows.Clear();
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
              //  }
                //else
                //{ txtNombre.Text = ""; MessageBox.Show("El campo nombre debe tener 10 caracteres como máximo"); }
            }
            else
            {
                MessageBox.Show("Le falta ingresar un dato");
            }
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            rut = "";
            txtRut.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtFijo.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            btnAgregar.Enabled = true;
            cbxComuna.SelectedValue = 1;
            cbxJefe.SelectedValue = 1;
            cbxPerfil.SelectedValue = 1;
            cbxTipo.SelectedValue = 1;
            cbxSexo.SelectedValue = 1;
            dt.Value = DateTime.Now;
        }
        private void dgvPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersona.CurrentRow.Index != -1)
                {
                    txtRut.Text = dgvPersona.CurrentRow.Cells[0].Value.ToString();
                    txtNombre.Text = dgvPersona.CurrentRow.Cells[1].Value.ToString();
                    txtPaterno.Text = dgvPersona.CurrentRow.Cells[2].Value.ToString();
                    txtMaterno.Text = dgvPersona.CurrentRow.Cells[3].Value.ToString();
                    txtDireccion.Text = dgvPersona.CurrentRow.Cells[4].Value.ToString();

                    txtFijo.Text = dgvPersona.CurrentRow.Cells[5].Value.ToString();
                    txtCelular.Text = dgvPersona.CurrentRow.Cells[6].Value.ToString();
                    txtEmail.Text = dgvPersona.CurrentRow.Cells[7].Value.ToString();
                    cbxSexo.SelectedValue = Convert.ToInt32(dgvPersona.CurrentRow.Cells[8].Value.ToString());
                    cbxComuna.SelectedValue = Convert.ToInt32(dgvPersona.CurrentRow.Cells[9].Value.ToString());
                    cbxPerfil.SelectedValue = Convert.ToInt32(dgvPersona.CurrentRow.Cells[10].Value.ToString());
                    cbxTipo.SelectedValue = Convert.ToInt32(dgvPersona.CurrentRow.Cells[11].Value.ToString());
                     cbxJefe.SelectedValue = dgvPersona.CurrentRow.Cells[12].Value.ToString();
                     DateTime dati = DateTime.ParseExact(dgvPersona.CurrentRow.Cells[13].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                     dt.Value = dati;

                    //fecha 

                    // string d = dgvPersona.CurrentRow.Cells[13].Value.ToString();// año mes dia
                    //dt.Value = DateTime.Parse(d);

                    //sexo
                    //comuna
                    //perfil
                    //cargo
                    //jefe

                    btnAgregar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.Write("error");
            }
        }
    }
}
