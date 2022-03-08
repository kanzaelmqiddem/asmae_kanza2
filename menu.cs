using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PET_CLINIC
{
    public partial class menu : Form  
    {
        public menu()
        {
            InitializeComponent();
            panel4.Visible = false;
            remplicmbcategorie();
            //Changer format du datepicker 
            bunifuDatePicker1.Value = DateTime.Now.Date;
            Application.CurrentCulture = new CultureInfo("fr-FR");
            bunifuDatePicker1.Format = DateTimePickerFormat.Custom;
            bunifuDatePicker1.CustomFormat = Application.CurrentCulture.DateTimeFormat.ShortDatePattern;
            //Ajouter icon a datagridview

            //((DataGridViewImageCell)datagridanimal.Rows[0].Cells[5]).Value = Properties.Resources.flat_style_circle_edit_icon_icons_com_66939;


        }

      public void remplirdatagridpatient()
        {
            datagridanim.Rows.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=petclinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from patient",con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd.HasRows)
                {
                    datagridanim.Rows.Add(rd[0], rd[1],rd[2],rd[3],rd[4],rd[5], rd[6], rd[7],rd[8]);
                }
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;

        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

       
        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            this.Close();

            

        }

        private void bunifuLabel10_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 3;

        }

        private void menu_Load(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 4;

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 5;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ajouteranimal_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            datagridanim.Visible = false;

        }


        public void remplicmbcategorie()
        {
            cmb_categorie.Items.Add("Chat");
            cmb_categorie.Items.Add("Chien");

        }
        private void bunifuButton9_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=petclinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into patient values('"+int.Parse(txt_idanimal.Text)+"','" + txt_nomanimal.Text + "',  '" + txt_genre.Text + "','" + int.Parse(txt_age.Text) + "', '" + cmb_categorie.SelectedItem.ToString() + "', '" + txt_alergie.Text + "', '" + txt_nomprop.Text + "', '" + txt_adresse.Text + "', '" + txt_tel.Text + "')",con);

            int res = cmd.ExecuteNonQuery();
            if (res!=0)
            {
                MessageBox.Show("Bien Enregistrer");
                remplirdatagridpatient();

            }
            else
            {
                MessageBox.Show("ERREUR");
            }
        }

        private void bunifuButton8_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
            datagridanim.Visible = true ;

        }

        private void datagridanim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=petclinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("update patient set n_animal='" +datagridanim.CurrentRow.Cells[1].Value.ToString()+ "', genre='" + datagridanim.CurrentRow.Cells[2].Value.ToString()+ "', Age='" + int.Parse(datagridanim.CurrentRow.Cells[3].Value.ToString()) + "', categorie= '" + datagridanim.CurrentRow.Cells[4].Value.ToString()  + "', alergie='" + datagridanim.CurrentRow.Cells[5].Value.ToString()+ "', n_prop='" + datagridanim.CurrentRow.Cells[6].Value.ToString() +  "', adresse_prop= '" + datagridanim.CurrentRow.Cells[7].Value.ToString()  + "', tel='" + datagridanim.CurrentRow.Cells[8].Value.ToString() +  "' where id_patient='"+datagridanim.CurrentRow.Cells[0].Value.ToString()+"'", con);
            
            int res = cmd.ExecuteNonQuery();
            if (res != 0)
            {
                MessageBox.Show("Bien Modifier");
                datagridanim.Rows.Clear();
                remplirdatagridpatient();
            }
            else
            {
                MessageBox.Show("ERREUR");
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=petclinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from patient where id_patient='" + datagridanim.CurrentRow.Cells[0].Value.ToString() + "'", con);
            
            int res = cmd.ExecuteNonQuery();
            if (res != 0)
            {
                MessageBox.Show("Bien Supprimer");
                datagridanim.Rows.Clear();
                remplirdatagridpatient();
            }
            else
            {
                MessageBox.Show("ERREUR");
            }
        }


        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=petclinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from patient where n_animal='" + btn_rech_animal.Text + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd.HasRows)
                {
                    datagridanim.Rows.Clear();
                    datagridanim.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7], rd[8]);
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
