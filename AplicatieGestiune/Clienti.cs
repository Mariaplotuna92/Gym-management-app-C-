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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace AplicatieGestiune
{
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();
        }
        MySqlConnection Conexiune = new MySqlConnection("datasource=localhost;port=3306;username=root;password=050692;database=gestiune_sala;");
        void populate()
        {
            try
            {
                Conexiune.Open();
                string Myquery = "select * from gestiune_sala.clienti";
                MySqlDataAdapter da = new MySqlDataAdapter(Myquery, Conexiune);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridViewClienti.DataSource = ds.Tables[0];
                Conexiune.Close();
            }
            catch
            {

            }
        }
        private void buttonAdaugareClient_Click(object sender, EventArgs e)
        {
            try
            {
                Conexiune.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText: "insert into gestiune_sala.clienti(Nume,Email,Telefon) values" +
                    "('" + textBoxNumeClient.Text + "','" + textBoxEmailClient.Text + "','" + textBoxNumarTelefonClient.Text + "')", Conexiune);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client adaugat cu succes!");
                Conexiune.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            if (Form1.tip == "U")
            {
                buttonStergereClient.Visible = false;
            }
            dataGridViewClienti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            populate();
        }

        private void buttonStergereClient_Click(object sender, EventArgs e)
        {
            Conexiune.Open();
            MySqlCommand comand = Conexiune.CreateCommand();
            comand.CommandType = CommandType.Text;
            comand.CommandText = "delete from gestiune_sala.clienti where Id_client='" + textBoxIdClient.Text + "'";
            comand.ExecuteNonQuery();
            MessageBox.Show("Client sters cu succes!");
            Conexiune.Close();
            populate();
        }

        private void dataGridViewClienti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewClienti.SelectedRows[0];
            if(row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
            {
                textBoxIdClient.Text = row.Cells[0].Value.ToString();
                textBoxNumeClient.Text = row.Cells[1].Value.ToString();
                textBoxEmailClient.Text = row.Cells[2].Value.ToString();
                textBoxNumarTelefonClient.Text = row.Cells[3].Value.ToString();
            }
        }

        private void buttonGolireFormularC_Click(object sender, EventArgs e)
        {
            textBoxIdClient.Text = "";
            textBoxNumeClient.Text = "";
            textBoxEmailClient.Text = "";
            textBoxNumarTelefonClient.Text = "";
        }

        private void buttonCautareClient_Click(object sender, EventArgs e)
        {
            Conexiune.Open();
            string query = "select * from gestiune_sala.clienti where Nume like '" + textBoxNumeClient.Text + "%' ";
            MySqlCommand cmd = new MySqlCommand(query, Conexiune);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBoxIdClient.Text = (dr["Id_client"].ToString());
                textBoxNumeClient.Text = (dr["Nume"].ToString());
                textBoxEmailClient.Text = (dr["Email"].ToString());
                textBoxNumarTelefonClient.Text = (dr["Telefon"].ToString());
            }
            else
            {
                textBoxIdClient.Text = "";
                textBoxNumeClient.Text = "";
                textBoxNumarTelefonClient.Text = "";
                textBoxEmailClient.Text = "";
                MessageBox.Show("Nici o inregistrare gasita!");
            }
            Conexiune.Close();
        }

        private void buttonEditareClient_Click(object sender, EventArgs e)
        {
            try
            {
                Conexiune.Open();
                MySqlCommand cmd = new MySqlCommand("update gestiune_sala.clienti set " +
                    "Id_client='" + textBoxIdClient.Text + "' , " +
                    "Nume='" + textBoxNumeClient.Text + "' ," +
                    "Email='" + textBoxEmailClient.Text + "'," +
                    "Telefon='" + textBoxNumarTelefonClient.Text + "' where " +
                    "Id_client='" + textBoxIdClient.Text + "'", Conexiune);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client editat cu succes!");
                Conexiune.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Acasa acasa = new Acasa();
            acasa.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void exportgridtopdf(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgv.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //add header
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //add datarow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();

                }
            }
        }

        private void buttonExportPdf_Click(object sender, EventArgs e)
        {
            exportgridtopdf(dataGridViewClienti, "RaportClienti");
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
