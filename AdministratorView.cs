using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagementSystem
{
    public partial class AdministratorView : Form
    {
        public AdministratorView()
        {
            InitializeComponent();
        }

        


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AdministratorView_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"C:\Users\coura\OneDrive - INTEC\INTEC - ING SOFTWARE\Trimestre 2\IDS340- DESARROLLO DE SOFTWARE I\PayrollManagementSystem\PayrollManagementSystem\Data\PayrollMS.mdf");
            con.Open();
            //SqlCommand cmd = new SqlCommand
        }
    }
}
