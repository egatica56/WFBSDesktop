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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            lblUser.Text = Sesion.usuario;
            //lblUsuario2.Text = Sesion.usuario;
        }

        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nivel niv = new Nivel();
            niv.Show();
        }

        private void competenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Competencia com = new Competencia();
            com.Show();
        }

        private void observaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Observacion obs = new Observacion();
            obs.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil per = new Perfil();
            per.Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona prs = new Persona();
            prs.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            usr.Show();
        }

        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoUsuario tu = new TipoUsuario();
            tu.Show();
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();
            per.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }
    }
}
