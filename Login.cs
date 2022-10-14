using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollManagementSystemV1
{
    public partial class Login : Form
    {
        SqlConnection con;
        public static int IdUsuarioActivo = 0;
        public Login()
        {
            InitializeComponent();

        }
        
        
        private void FLogin_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\coura\OneDrive - INTEC\INTEC - ING SOFTWARE\Trimestre 2\IDS340- DESARROLLO DE SOFTWARE I\Proyecto Final\PayRollManagementSystemV1\Data\PayrollMSv1.mdf"";Integrated Security=True;Connect Timeout=30");
           
            //Cargo imagen Gif para el login:
            pbLoginGif.Image = Image.FromFile(@"C:\Users\coura\OneDrive - INTEC\INTEC - ING SOFTWARE\Trimestre 2\IDS340- DESARROLLO DE SOFTWARE I\Proyecto Final\PayRollManagementSystemV1\Recursos\ImagenInicioLogin.gif");
            pbLoginGif.SizeMode = PictureBoxSizeMode.StretchImage;

        }


        
        //Para cerrar ventana
        private void Cerrar_ventana(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        private void Acceder(object sender, EventArgs e)
        {

            String user = txtUser.Text, pwd = txtPwd.Text;
            if (txtUser.Text.Length == 0 || txtPwd.Text.Length == 0)
            {
                MessageBox.Show("Rellene todos los espacios en blanco...");
            }
            else
            {
                
                    string querry = "SELECT NombreUsuario, RolUsuario, Id FROM Usuario WHERE NombreUsuario = '" + user + "' AND Contrasena = '" + pwd + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                    DataTable dTable = new DataTable();
                    sda.Fill(dTable);

                    if (dTable.Rows.Count > 0)
                    {
                        var tipoROL = (dTable.Rows[0][1]).ToString();
                        IdUsuarioActivo = Convert.ToInt32((dTable.Rows[0][2]).ToString());

                    con.Close();
                        this.Hide();
                        Redireccionar_Tipo_Usuario(tipoROL);
                    }
                    else
                    {
                        MessageBox.Show("Las credenciales no son correctas");
                        txtUser.Clear();
                        txtPwd.Clear();

                    }

            }

        }

        public void Redireccionar_Tipo_Usuario( String Rol ) 
        {
            switch (Rol) 
            {
                case "1":
                   MessageBox.Show("Bienvenido Administrador");
                    AdministradorView ModuloAdministrador = new AdministradorView();
                    ModuloAdministrador.Show();
                   break;
                case "2":
                    MessageBox.Show("Bienvenido Encargado de Nomina");
                    //AdministradorView ModuloAdministrador = new AdministradorView();
                    //ModuloAdministrador.Show();
                    break;
                case "3":
                    MessageBox.Show("Bienvenido Supervisor");
                    //AdministradorView ModuloAdministrador = new AdministradorView();
                    //ModuloAdministrador.Show();
                    break;
                case "4":
                    MessageBox.Show("Bienvenido Empleado regular");
                    //AdministradorView ModuloAdministrador = new AdministradorView();
                    //ModuloAdministrador.Show();
                    break;
            }

        }
       

        //Para arrastrar ventana
        public int xClick = 0, yClick = 0;
        private void Flogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
