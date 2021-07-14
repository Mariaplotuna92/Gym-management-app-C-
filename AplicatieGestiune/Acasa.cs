using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace AplicatieGestiune
{
    public partial class Acasa : Form
    {
        public Acasa()
        {
            InitializeComponent();
        }
        MySqlConnection Conexiune = new MySqlConnection("datasource=localhost;port=3306;username=root;password=050692;database=gestiune_sala;");
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBoxClienti_Click(object sender, EventArgs e)
        {
            Clienti clienti = new Clienti();
            clienti.Show();
            this.Hide();
        }

        private void pictureBoxUtilizatori_Click(object sender, EventArgs e)
        {
            Utilizatori utilizatori = new Utilizatori();
            utilizatori.Show();
            this.Hide();
        }
        private void pictureBoxVanzari_Click(object sender, EventArgs e)
        {
            Vanzari vanzari = new Vanzari();
            vanzari.Show();
            this.Hide();
        }
        private void pictureBoxServicii_Click(object sender, EventArgs e)
        {
            Servicii servicii = new Servicii();
            servicii.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Acasa_Load(object sender, EventArgs e)
        {
            if( Form1.tip == "U")
            {
                pictureBoxUtilizatori.Visible = false;
                labelUtilizatori.Visible = false;

            }
            dataGridViewExpirare.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpAzi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            populate();
        }
        void populate()
        {
            try
            {
                Conexiune.Open();
                string Myquery = "select * from gestiune_sala.data_expirare;";
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, Conexiune);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridViewExpirare.DataSource = ds.Tables[0];

                string Myquery1 = "select * from gestiune_sala.data_expirare_azi;";
                MySqlDataAdapter da1 = new MySqlDataAdapter(Myquery1, Conexiune);
                MySqlCommandBuilder builder1 = new MySqlCommandBuilder(da1);
                var ds1 = new DataSet();
                da1.Fill(ds1);
                dataGridViewExpAzi.DataSource = ds1.Tables[0];
                Conexiune.Close();
            }
            catch
            {

            }
        
        }

        
    }
}
