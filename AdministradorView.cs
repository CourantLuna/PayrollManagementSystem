using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;

namespace PayRollManagementSystemV1
{
    public partial class AdministradorView : Form
    {
        SqlConnection con;
        SqlCommand cmd;
       // SqlDataReader dr;
       // SqlDataAdapter da;

        public AdministradorView()
        {
            InitializeComponent();
        }


        private void AdministradorView_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\coura\OneDrive - INTEC\INTEC - ING SOFTWARE\Trimestre 2\IDS340- DESARROLLO DE SOFTWARE I\Proyecto Final\PayRollManagementSystemV1\Data\PayrollMSv1.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();

            //cargo dvg Empleados
            CargarTablaEmpleado();

            //cargo dvg Usuarios*/
            CargarTablaUsuario();

            //cargo cbb Rol Usuario
            cbbRolUsuario.DisplayMember = "Text";
            cbbRolUsuario.ValueMember = "Value";

            var items = new[]
            {
            new { Text = "Administrador", Value = "1" },
            new { Text = "Enc. de nomina", Value = "2" },
            new { Text = "Supervisor", Value = "3" },
            new { Text = "Empleado Regular", Value = "4" }
            };

            cbbRolUsuario.DataSource = items;
        }

        private void CargarTablaEmpleado() 
        {
            string querry = "SELECT * FROM Empleado";
            SqlDataAdapter sda = new SqlDataAdapter(querry, con);

            DataTable dTable = new DataTable();
            sda.Fill(dTable);

            dgvEmpleados.DataSource = dTable;
            
        }

        private void CargarTablaUsuario()
        {
            string querry = "SELECT * FROM Usuario";
            SqlDataAdapter sda = new SqlDataAdapter(querry, con);

            DataTable dTable = new DataTable();
            sda.Fill(dTable);

            dvgUsuarios.DataSource = dTable;

        }



        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Ventana_AdministradorView(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Salis_Sesion_AdministradorView(object sender, EventArgs e)
        {
            Login Flogin = new Login();
            Login.IdUsuarioActivo = 0;
            this.Hide();
            Flogin.Show();

        }

        private void Agregar_Empleado(object sender, EventArgs e)
        {
            
            
            string querry = "INSERT INTO Empleado " +
                "(Nombre, Apellido, Cargo, Telefono, Cedula, Email, SalarioBruto, Entrada, CreadoPor)" +
                "VALUES (@Nombre, @Apellido, @Cargo, @Telefono, @Cedula, @Email, @SalarioBruto, @Entrada, @CreadoPor)";

            cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            cmd.Parameters.AddWithValue("@Cargo", txtCargo.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@SalarioBruto", txtSalarioBruto.Text);
            cmd.Parameters.AddWithValue("@Entrada", DateTime.Now.ToString());
            
            using (Login Flogin = new Login()) 
            {
                cmd.Parameters.AddWithValue("@CreadoPor", Login.IdUsuarioActivo.ToString());
            }

            cmd.ExecuteNonQuery();
            CargarTablaEmpleado();

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow;
            int indexcolumna = dgvEmpleados.CurrentCell.ColumnIndex;

            if(indexcolumna == 0) 
            {
                indexrow = dgvEmpleados.CurrentCell.RowIndex;
                txtprueba.Text = "row: " + indexrow + " colum" + indexcolumna;
            }

            
            
        }

        private void Agregar_Usuario(object sender, EventArgs e)
        {
            string querry = "INSERT INTO Usuario " +
               "(Nombre, Apellido, Cargo, Telefono, Cedula, Email, SalarioBruto, Entrada, CreadoPor)" +
               "VALUES (@Nombre, @Apellido, @Cargo, @Telefono, @Cedula, @Email, @SalarioBruto, @Entrada, @CreadoPor)";

            cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            cmd.Parameters.AddWithValue("@Cargo", txtCargo.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@SalarioBruto", txtSalarioBruto.Text);
            cmd.Parameters.AddWithValue("@Entrada", DateTime.Now.ToString());

            using (Login Flogin = new Login())
            {
                cmd.Parameters.AddWithValue("@CreadoPor", Login.IdUsuarioActivo.ToString());
            }

            cmd.ExecuteNonQuery();
            CargarTablaEmpleado();
        }
    }
}
