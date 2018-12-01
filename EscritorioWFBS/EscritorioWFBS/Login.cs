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
    public partial class Login : Form
    {
        ServidorWFBS.WS_wfbsClient servidor = new ServidorWFBS.WS_wfbsClient();

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           if (txtUser.Text != "" && txtPass.Text != "")
            {
                try
                {
                    String user = txtUser.Text;
                    String pass = txtPass.Text;
                    int respuesta;

                   // Usuario usuario = servidor.login(user, pass);

                    respuesta = servidor.login(user, pass);
                    if (respuesta ==1)
                    {
                        Sesion.usuario = user;
                        Inicio ini = new Inicio();
                        ini.Show();
                        this.Hide();
                        //Sesion.usuario = user;


                        

                        
                                                
                    }
                    else
                    {
                        MessageBox.Show("Usuario no valido, intente nuevamente");
                        txtPass.Text = "";
                        txtUser.Text = "";
                    }
                    

                }
                catch (Exception ex)
                {
                    Console.Write("error No controlado"+ ex.Message);
                }
                finally
                { }
            }
            else
            {
                MessageBox.Show("Ingrese los datos");
            }
        }
    }
}
