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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection Conexiune = new MySqlConnection("datasource=localhost;port=3306;username=root;password=050692;database=gestiune_sala;");
       
        public static string tip;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked )
                textBoxParola.PasswordChar = '\0';
            
            else
                textBoxParola.PasswordChar = '*';
        }
        private void labelSterge_Click(object sender, EventArgs e)
        {
            textBoxUtilizator.Text = "";
            textBoxParola.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            MySqlCommand cmd = new MySqlCommand("gestiune_sala.rol_login",Conexiune);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexiune.Open();
            cmd.Parameters.AddWithValue("nume", textBoxUtilizator.Text);
            cmd.Parameters.AddWithValue("parola", textBoxParola.Text);
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                if (rd[6].ToString()=="Admin")
                {
                    tip = "A";
                }
                else if (rd[6].ToString() == "User")
                {
                    tip = "U";
                }
                Acasa acasa = new Acasa();
                acasa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eroare logare");
            }
            Conexiune.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
