namespace AplicatieGestiune
{
    partial class Acasa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxClienti = new System.Windows.Forms.PictureBox();
            this.labelClienti = new System.Windows.Forms.Label();
            this.labelServicii = new System.Windows.Forms.Label();
            this.pictureBoxServicii = new System.Windows.Forms.PictureBox();
            this.labelUtilizatori = new System.Windows.Forms.Label();
            this.pictureBoxUtilizatori = new System.Windows.Forms.PictureBox();
            this.dataGridViewExpirare = new System.Windows.Forms.DataGridView();
            this.labelExpirare = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewExpAzi = new System.Windows.Forms.DataGridView();
            this.pictureBoxVanzari = new System.Windows.Forms.PictureBox();
            this.labelBonuri = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServicii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpirare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpAzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVanzari)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 104);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Plum;
            this.buttonExit.BackgroundImage = global::AplicatieGestiune.Properties.Resources.Exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Location = new System.Drawing.Point(687, 24);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(72, 59);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.BackColor = System.Drawing.Color.Plum;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.Location = new System.Drawing.Point(535, 24);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(146, 59);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pagină Principală";
            // 
            // pictureBoxClienti
            // 
            this.pictureBoxClienti.BackColor = System.Drawing.Color.Plum;
            this.pictureBoxClienti.BackgroundImage = global::AplicatieGestiune.Properties.Resources.Clienti;
            this.pictureBoxClienti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxClienti.Location = new System.Drawing.Point(12, 121);
            this.pictureBoxClienti.Name = "pictureBoxClienti";
            this.pictureBoxClienti.Size = new System.Drawing.Size(152, 95);
            this.pictureBoxClienti.TabIndex = 1;
            this.pictureBoxClienti.TabStop = false;
            this.pictureBoxClienti.Click += new System.EventHandler(this.pictureBoxClienti_Click);
            // 
            // labelClienti
            // 
            this.labelClienti.AutoSize = true;
            this.labelClienti.BackColor = System.Drawing.Color.Transparent;
            this.labelClienti.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClienti.Location = new System.Drawing.Point(29, 219);
            this.labelClienti.Name = "labelClienti";
            this.labelClienti.Size = new System.Drawing.Size(119, 45);
            this.labelClienti.TabIndex = 2;
            this.labelClienti.Text = "Clienți";
            // 
            // labelServicii
            // 
            this.labelServicii.AutoSize = true;
            this.labelServicii.BackColor = System.Drawing.Color.Transparent;
            this.labelServicii.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelServicii.Location = new System.Drawing.Point(203, 219);
            this.labelServicii.Name = "labelServicii";
            this.labelServicii.Size = new System.Drawing.Size(132, 45);
            this.labelServicii.TabIndex = 4;
            this.labelServicii.Text = "Servicii";
            // 
            // pictureBoxServicii
            // 
            this.pictureBoxServicii.BackColor = System.Drawing.Color.Plum;
            this.pictureBoxServicii.BackgroundImage = global::AplicatieGestiune.Properties.Resources.Servicii;
            this.pictureBoxServicii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxServicii.Location = new System.Drawing.Point(187, 121);
            this.pictureBoxServicii.Name = "pictureBoxServicii";
            this.pictureBoxServicii.Size = new System.Drawing.Size(172, 95);
            this.pictureBoxServicii.TabIndex = 3;
            this.pictureBoxServicii.TabStop = false;
            this.pictureBoxServicii.Click += new System.EventHandler(this.pictureBoxServicii_Click);
            // 
            // labelUtilizatori
            // 
            this.labelUtilizatori.AutoSize = true;
            this.labelUtilizatori.BackColor = System.Drawing.Color.Transparent;
            this.labelUtilizatori.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUtilizatori.Location = new System.Drawing.Point(568, 219);
            this.labelUtilizatori.Name = "labelUtilizatori";
            this.labelUtilizatori.Size = new System.Drawing.Size(173, 45);
            this.labelUtilizatori.TabIndex = 6;
            this.labelUtilizatori.Text = "Utilizatori";
            // 
            // pictureBoxUtilizatori
            // 
            this.pictureBoxUtilizatori.BackColor = System.Drawing.Color.Plum;
            this.pictureBoxUtilizatori.BackgroundImage = global::AplicatieGestiune.Properties.Resources.Utilizatori;
            this.pictureBoxUtilizatori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUtilizatori.Location = new System.Drawing.Point(561, 121);
            this.pictureBoxUtilizatori.Name = "pictureBoxUtilizatori";
            this.pictureBoxUtilizatori.Size = new System.Drawing.Size(189, 95);
            this.pictureBoxUtilizatori.TabIndex = 5;
            this.pictureBoxUtilizatori.TabStop = false;
            this.pictureBoxUtilizatori.Click += new System.EventHandler(this.pictureBoxUtilizatori_Click);
            // 
            // dataGridViewExpirare
            // 
            this.dataGridViewExpirare.AllowUserToAddRows = false;
            this.dataGridViewExpirare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpirare.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridViewExpirare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpirare.Location = new System.Drawing.Point(12, 367);
            this.dataGridViewExpirare.Name = "dataGridViewExpirare";
            this.dataGridViewExpirare.RowHeadersWidth = 51;
            this.dataGridViewExpirare.RowTemplate.Height = 24;
            this.dataGridViewExpirare.Size = new System.Drawing.Size(738, 156);
            this.dataGridViewExpirare.TabIndex = 7;
            // 
            // labelExpirare
            // 
            this.labelExpirare.AutoSize = true;
            this.labelExpirare.BackColor = System.Drawing.Color.Transparent;
            this.labelExpirare.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExpirare.Location = new System.Drawing.Point(12, 306);
            this.labelExpirare.Name = "labelExpirare";
            this.labelExpirare.Size = new System.Drawing.Size(637, 45);
            this.labelExpirare.TabIndex = 8;
            this.labelExpirare.Text = "Servicii care expiră în următoarele 7 zile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Servicii care au expirat astăzi";
            // 
            // dataGridViewExpAzi
            // 
            this.dataGridViewExpAzi.AllowUserToAddRows = false;
            this.dataGridViewExpAzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpAzi.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridViewExpAzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpAzi.Location = new System.Drawing.Point(12, 584);
            this.dataGridViewExpAzi.Name = "dataGridViewExpAzi";
            this.dataGridViewExpAzi.RowHeadersWidth = 51;
            this.dataGridViewExpAzi.RowTemplate.Height = 24;
            this.dataGridViewExpAzi.Size = new System.Drawing.Size(738, 156);
            this.dataGridViewExpAzi.TabIndex = 10;
            // 
            // pictureBoxVanzari
            // 
            this.pictureBoxVanzari.BackColor = System.Drawing.Color.Plum;
            this.pictureBoxVanzari.BackgroundImage = global::AplicatieGestiune.Properties.Resources.Comenzi;
            this.pictureBoxVanzari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxVanzari.Location = new System.Drawing.Point(382, 121);
            this.pictureBoxVanzari.Name = "pictureBoxVanzari";
            this.pictureBoxVanzari.Size = new System.Drawing.Size(156, 95);
            this.pictureBoxVanzari.TabIndex = 11;
            this.pictureBoxVanzari.TabStop = false;
            this.pictureBoxVanzari.Click += new System.EventHandler(this.pictureBoxVanzari_Click);
            // 
            // labelBonuri
            // 
            this.labelBonuri.AutoSize = true;
            this.labelBonuri.BackColor = System.Drawing.Color.Transparent;
            this.labelBonuri.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBonuri.Location = new System.Drawing.Point(395, 219);
            this.labelBonuri.Name = "labelBonuri";
            this.labelBonuri.Size = new System.Drawing.Size(134, 45);
            this.labelBonuri.TabIndex = 12;
            this.labelBonuri.Text = "Vânzari";
            // 
            // Acasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicatieGestiune.Properties.Resources.image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 767);
            this.Controls.Add(this.labelBonuri);
            this.Controls.Add(this.pictureBoxVanzari);
            this.Controls.Add(this.dataGridViewExpAzi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelExpirare);
            this.Controls.Add(this.dataGridViewExpirare);
            this.Controls.Add(this.labelUtilizatori);
            this.Controls.Add(this.pictureBoxUtilizatori);
            this.Controls.Add(this.labelServicii);
            this.Controls.Add(this.pictureBoxServicii);
            this.Controls.Add(this.labelClienti);
            this.Controls.Add(this.pictureBoxClienti);
            this.Controls.Add(this.panel1);
            this.Name = "Acasa";
            this.Text = "Acasa";
            this.Load += new System.EventHandler(this.Acasa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServicii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpirare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpAzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVanzari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxClienti;
        private System.Windows.Forms.Label labelClienti;
        private System.Windows.Forms.Label labelServicii;
        private System.Windows.Forms.PictureBox pictureBoxServicii;
        private System.Windows.Forms.Label labelUtilizatori;
        private System.Windows.Forms.PictureBox pictureBoxUtilizatori;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridViewExpirare;
        private System.Windows.Forms.Label labelExpirare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewExpAzi;
        private System.Windows.Forms.PictureBox pictureBoxVanzari;
        private System.Windows.Forms.Label labelBonuri;
    }
}