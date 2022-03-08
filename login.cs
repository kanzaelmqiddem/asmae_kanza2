using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PET_CLINIC
{
    public partial class login : Form
    {
        menu menu = new menu();
        public login()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
           SqlDataReader rd= methodes.selection("petclinic", "select * from login where username='" + txt_username.Text + "'and password='" + txt_password.Text + "'");
            if (rd.HasRows == true)
            {
                this.Close();
                menu.Show();
            }
        }
    }
}
