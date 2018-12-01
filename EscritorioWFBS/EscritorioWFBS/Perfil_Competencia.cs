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
    public partial class Perfil_Competencia : Form
    {
        int idP = 0;
        int idC = 0;
        ServidorWFBS.WS_wfbsClient servidor = new ServidorWFBS.WS_wfbsClient();
        public Perfil_Competencia()
        {
            InitializeComponent();
            Listar();
            //Listar Perfiles
            cbxPerfil.DisplayMember = "nombre_perfil";
            cbxPerfil.ValueMember = "id_perfil";
            cbxPerfil.DataSource = servidor.listarPerfiles();

            // Listar Competencias
            cbxCompetencia.DisplayMember = "nombre_competencia";
            cbxCompetencia.ValueMember = "id_comp";
            cbxCompetencia.DataSource = servidor.listarCompetencia();

            btnAgregar.Enabled = true;
        }

        public void Listar()
        {
            try
            {
                foreach (var item in servidor.listarPerfilCompetencia())
                {
                    dgvPC.Update();
                    int i = dgvPC.Rows.Add();
                    var row = dgvPC.Rows[i];
                    row.Cells["IdPerfil"].Value = item.id_perfil;
                    row.Cells["NombrePerfil"].Value = item.nombre_perfil;
                    row.Cells["IdCompetencia"].Value = item.id_comp;
                    row.Cells["NombreCompetencia"].Value = item.nombre_competencia;

                }
            }
            catch (Exception ex)
            {
                Console.Write("error");
            }

        }
    

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               
                int perfil = Convert.ToInt32(cbxPerfil.SelectedValue.ToString());
                int competencia = Convert.ToInt32(cbxCompetencia.SelectedValue.ToString());
           
                bool respuesta;
                respuesta = servidor.insertarPerfilComp(perfil, competencia);

                if (respuesta == true)
                {
                    MessageBox.Show("Agregado correctamente");
                }
                else
                { MessageBox.Show("No se pudo modificar"); }
                dgvPC.Rows.Clear();
                Listar();
               
                btnAgregar.Enabled = true;

            }
            catch (Exception ex)
            {
                Console.Write("error");
            }
            finally
            { }
        }
    }
}
