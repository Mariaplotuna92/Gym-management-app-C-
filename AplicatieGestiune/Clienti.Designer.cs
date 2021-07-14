namespace AplicatieGestiune
{
    partial class Clienti
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.textBoxEmailClient = new System.Windows.Forms.TextBox();
            this.textBoxNumarTelefonClient = new System.Windows.Forms.TextBox();
            this.textBoxNumeClient = new System.Windows.Forms.TextBox();
            this.labelIdClient = new System.Windows.Forms.Label();
            this.labelEmailClient = new System.Windows.Forms.Label();
            this.labelNumarTelefonClient = new System.Windows.Forms.Label();
            this.labelNumeClient = new System.Windows.Forms.Label();
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGolireFormularC = new System.Windows.Forms.Button();
            this.buttonCautareClient = new System.Windows.Forms.Button();
            this.buttonStergereClient = new System.Windows.Forms.Button();
            this.buttonEditareClient = new System.Windows.Forms.Button();
            this.buttonAdaugareClient = new System.Windows.Forms.Button();
            this.buttonExportPdf = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 93);
            this.panel1.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Plum;
            this.buttonExit.BackgroundImage = global::AplicatieGestiune.Properties.Resources.Exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Location = new System.Drawing.Point(1305, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(72, 59);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Plum;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHome.Location = new System.Drawing.Point(162, 19);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(272, 51);
            this.buttonHome.TabIndex = 14;
            this.buttonHome.Text = "Pagină principală";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clienti";
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIdClient.Location = new System.Drawing.Point(22, 153);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(441, 47);
            this.textBoxIdClient.TabIndex = 22;
            // 
            // textBoxEmailClient
            // 
            this.textBoxEmailClient.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmailClient.Location = new System.Drawing.Point(22, 373);
            this.textBoxEmailClient.Name = "textBoxEmailClient";
            this.textBoxEmailClient.Size = new System.Drawing.Size(441, 47);
            this.textBoxEmailClient.TabIndex = 20;
            // 
            // textBoxNumarTelefonClient
            // 
            this.textBoxNumarTelefonClient.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumarTelefonClient.Location = new System.Drawing.Point(22, 483);
            this.textBoxNumarTelefonClient.Name = "textBoxNumarTelefonClient";
            this.textBoxNumarTelefonClient.Size = new System.Drawing.Size(441, 47);
            this.textBoxNumarTelefonClient.TabIndex = 19;
            // 
            // textBoxNumeClient
            // 
            this.textBoxNumeClient.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumeClient.Location = new System.Drawing.Point(22, 263);
            this.textBoxNumeClient.Name = "textBoxNumeClient";
            this.textBoxNumeClient.Size = new System.Drawing.Size(441, 47);
            this.textBoxNumeClient.TabIndex = 18;
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.BackColor = System.Drawing.Color.Transparent;
            this.labelIdClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdClient.Location = new System.Drawing.Point(22, 101);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(47, 41);
            this.labelIdClient.TabIndex = 26;
            this.labelIdClient.Text = "Id";
            // 
            // labelEmailClient
            // 
            this.labelEmailClient.AutoSize = true;
            this.labelEmailClient.BackColor = System.Drawing.Color.Transparent;
            this.labelEmailClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmailClient.Location = new System.Drawing.Point(22, 321);
            this.labelEmailClient.Name = "labelEmailClient";
            this.labelEmailClient.Size = new System.Drawing.Size(95, 41);
            this.labelEmailClient.TabIndex = 25;
            this.labelEmailClient.Text = "Email";
            // 
            // labelNumarTelefonClient
            // 
            this.labelNumarTelefonClient.AutoSize = true;
            this.labelNumarTelefonClient.BackColor = System.Drawing.Color.Transparent;
            this.labelNumarTelefonClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumarTelefonClient.Location = new System.Drawing.Point(22, 431);
            this.labelNumarTelefonClient.Name = "labelNumarTelefonClient";
            this.labelNumarTelefonClient.Size = new System.Drawing.Size(227, 41);
            this.labelNumarTelefonClient.TabIndex = 24;
            this.labelNumarTelefonClient.Text = "Număr Telefon";
            // 
            // labelNumeClient
            // 
            this.labelNumeClient.AutoSize = true;
            this.labelNumeClient.BackColor = System.Drawing.Color.Transparent;
            this.labelNumeClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumeClient.Location = new System.Drawing.Point(22, 211);
            this.labelNumeClient.Name = "labelNumeClient";
            this.labelNumeClient.Size = new System.Drawing.Size(103, 41);
            this.labelNumeClient.TabIndex = 23;
            this.labelNumeClient.Text = "Nume";
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.AllowUserToAddRows = false;
            this.dataGridViewClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClienti.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridViewClienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.GridColor = System.Drawing.Color.Thistle;
            this.dataGridViewClienti.Location = new System.Drawing.Point(486, 157);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridViewClienti.RowTemplate.Height = 24;
            this.dataGridViewClienti.Size = new System.Drawing.Size(891, 379);
            this.dataGridViewClienti.TabIndex = 27;
            this.dataGridViewClienti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClienti_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(812, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 41);
            this.label2.TabIndex = 28;
            this.label2.Text = "Listă Clienți";
            // 
            // buttonGolireFormularC
            // 
            this.buttonGolireFormularC.BackColor = System.Drawing.Color.Plum;
            this.buttonGolireFormularC.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGolireFormularC.Location = new System.Drawing.Point(24, 596);
            this.buttonGolireFormularC.Name = "buttonGolireFormularC";
            this.buttonGolireFormularC.Size = new System.Drawing.Size(263, 58);
            this.buttonGolireFormularC.TabIndex = 33;
            this.buttonGolireFormularC.Text = "GolireFormular";
            this.buttonGolireFormularC.UseVisualStyleBackColor = false;
            this.buttonGolireFormularC.Click += new System.EventHandler(this.buttonGolireFormularC_Click);
            // 
            // buttonCautareClient
            // 
            this.buttonCautareClient.BackColor = System.Drawing.Color.Plum;
            this.buttonCautareClient.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCautareClient.Location = new System.Drawing.Point(321, 596);
            this.buttonCautareClient.Name = "buttonCautareClient";
            this.buttonCautareClient.Size = new System.Drawing.Size(161, 58);
            this.buttonCautareClient.TabIndex = 32;
            this.buttonCautareClient.Text = "Căutare";
            this.buttonCautareClient.UseVisualStyleBackColor = false;
            this.buttonCautareClient.Click += new System.EventHandler(this.buttonCautareClient_Click);
            // 
            // buttonStergereClient
            // 
            this.buttonStergereClient.BackColor = System.Drawing.Color.Plum;
            this.buttonStergereClient.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStergereClient.Location = new System.Drawing.Point(938, 596);
            this.buttonStergereClient.Name = "buttonStergereClient";
            this.buttonStergereClient.Size = new System.Drawing.Size(161, 58);
            this.buttonStergereClient.TabIndex = 31;
            this.buttonStergereClient.Text = "Ștergere";
            this.buttonStergereClient.UseVisualStyleBackColor = false;
            this.buttonStergereClient.Click += new System.EventHandler(this.buttonStergereClient_Click);
            // 
            // buttonEditareClient
            // 
            this.buttonEditareClient.BackColor = System.Drawing.Color.Plum;
            this.buttonEditareClient.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditareClient.Location = new System.Drawing.Point(743, 596);
            this.buttonEditareClient.Name = "buttonEditareClient";
            this.buttonEditareClient.Size = new System.Drawing.Size(161, 58);
            this.buttonEditareClient.TabIndex = 30;
            this.buttonEditareClient.Text = "Editare";
            this.buttonEditareClient.UseVisualStyleBackColor = false;
            this.buttonEditareClient.Click += new System.EventHandler(this.buttonEditareClient_Click);
            // 
            // buttonAdaugareClient
            // 
            this.buttonAdaugareClient.BackColor = System.Drawing.Color.Plum;
            this.buttonAdaugareClient.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdaugareClient.Location = new System.Drawing.Point(516, 596);
            this.buttonAdaugareClient.Name = "buttonAdaugareClient";
            this.buttonAdaugareClient.Size = new System.Drawing.Size(193, 58);
            this.buttonAdaugareClient.TabIndex = 29;
            this.buttonAdaugareClient.Text = "Adăugare";
            this.buttonAdaugareClient.UseVisualStyleBackColor = false;
            this.buttonAdaugareClient.Click += new System.EventHandler(this.buttonAdaugareClient_Click);
            // 
            // buttonExportPdf
            // 
            this.buttonExportPdf.BackColor = System.Drawing.Color.Plum;
            this.buttonExportPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExportPdf.Location = new System.Drawing.Point(1133, 596);
            this.buttonExportPdf.Name = "buttonExportPdf";
            this.buttonExportPdf.Size = new System.Drawing.Size(244, 58);
            this.buttonExportPdf.TabIndex = 36;
            this.buttonExportPdf.Text = "Export PDF";
            this.buttonExportPdf.UseVisualStyleBackColor = false;
            this.buttonExportPdf.Click += new System.EventHandler(this.buttonExportPdf_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.BackColor = System.Drawing.Color.Plum;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.Location = new System.Drawing.Point(1153, 19);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(146, 59);
            this.buttonLogout.TabIndex = 16;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicatieGestiune.Properties.Resources.image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1389, 683);
            this.Controls.Add(this.buttonExportPdf);
            this.Controls.Add(this.buttonGolireFormularC);
            this.Controls.Add(this.buttonCautareClient);
            this.Controls.Add(this.buttonStergereClient);
            this.Controls.Add(this.buttonEditareClient);
            this.Controls.Add(this.buttonAdaugareClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewClienti);
            this.Controls.Add(this.labelIdClient);
            this.Controls.Add(this.labelEmailClient);
            this.Controls.Add(this.labelNumarTelefonClient);
            this.Controls.Add(this.labelNumeClient);
            this.Controls.Add(this.textBoxIdClient);
            this.Controls.Add(this.textBoxEmailClient);
            this.Controls.Add(this.textBoxNumarTelefonClient);
            this.Controls.Add(this.textBoxNumeClient);
            this.Controls.Add(this.panel1);
            this.Name = "Clienti";
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.Clienti_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.TextBox textBoxEmailClient;
        private System.Windows.Forms.TextBox textBoxNumarTelefonClient;
        private System.Windows.Forms.TextBox textBoxNumeClient;
        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.Label labelEmailClient;
        private System.Windows.Forms.Label labelNumarTelefonClient;
        private System.Windows.Forms.Label labelNumeClient;
        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGolireFormularC;
        private System.Windows.Forms.Button buttonCautareClient;
        private System.Windows.Forms.Button buttonStergereClient;
        private System.Windows.Forms.Button buttonEditareClient;
        private System.Windows.Forms.Button buttonAdaugareClient;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonExportPdf;
        private System.Windows.Forms.Button buttonLogout;
    }
}