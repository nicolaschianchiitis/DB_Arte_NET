namespace DB_Arte_NET
{
    partial class WindowsFormUtilities
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
            dgvUtilities = new DataGridView();
            btnArtistiContNome = new Button();
            tbNome = new TextBox();
            btnArtistiNatiDopoAnno = new Button();
            tbAnno = new TextBox();
            btnArtistiViventiAnno = new Button();
            tbAnnoViventi = new TextBox();
            btnTitoloAnnoEsecQuadri = new Button();
            btnMuseiCitta = new Button();
            lblNumMusei = new Label();
            cbCitta = new ComboBox();
            btnQuadriAreaSup = new Button();
            tbArea = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUtilities).BeginInit();
            SuspendLayout();
            // 
            // dgvUtilities
            // 
            dgvUtilities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUtilities.Location = new Point(582, 12);
            dgvUtilities.Name = "dgvUtilities";
            dgvUtilities.Size = new Size(871, 341);
            dgvUtilities.TabIndex = 0;
            // 
            // btnArtistiContNome
            // 
            btnArtistiContNome.Location = new Point(27, 23);
            btnArtistiContNome.Name = "btnArtistiContNome";
            btnArtistiContNome.Size = new Size(269, 26);
            btnArtistiContNome.TabIndex = 1;
            btnArtistiContNome.Text = "Artisti il cui nome contiene la stringa inserita";
            btnArtistiContNome.UseVisualStyleBackColor = true;
            btnArtistiContNome.Click += BtnArtistiContNome_Click;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(325, 23);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(223, 23);
            tbNome.TabIndex = 2;
            // 
            // btnArtistiNatiDopoAnno
            // 
            btnArtistiNatiDopoAnno.Location = new Point(27, 73);
            btnArtistiNatiDopoAnno.Name = "btnArtistiNatiDopoAnno";
            btnArtistiNatiDopoAnno.Size = new Size(269, 26);
            btnArtistiNatiDopoAnno.TabIndex = 1;
            btnArtistiNatiDopoAnno.Text = "Artisti nati dopo un certo anno";
            btnArtistiNatiDopoAnno.UseVisualStyleBackColor = true;
            btnArtistiNatiDopoAnno.Click += BtnArtistiNatiDopoAnno_Click;
            // 
            // tbAnno
            // 
            tbAnno.Location = new Point(325, 73);
            tbAnno.Name = "tbAnno";
            tbAnno.Size = new Size(223, 23);
            tbAnno.TabIndex = 2;
            // 
            // btnArtistiViventiAnno
            // 
            btnArtistiViventiAnno.Location = new Point(27, 124);
            btnArtistiViventiAnno.Name = "btnArtistiViventiAnno";
            btnArtistiViventiAnno.Size = new Size(269, 26);
            btnArtistiViventiAnno.TabIndex = 1;
            btnArtistiViventiAnno.Text = "Artisti viventi in un certo anno";
            btnArtistiViventiAnno.UseVisualStyleBackColor = true;
            btnArtistiViventiAnno.Click += BtnArtistiViventiAnno_Click;
            // 
            // tbAnnoViventi
            // 
            tbAnnoViventi.Location = new Point(325, 124);
            tbAnnoViventi.Name = "tbAnnoViventi";
            tbAnnoViventi.Size = new Size(223, 23);
            tbAnnoViventi.TabIndex = 2;
            // 
            // btnTitoloAnnoEsecQuadri
            // 
            btnTitoloAnnoEsecQuadri.Location = new Point(27, 311);
            btnTitoloAnnoEsecQuadri.Name = "btnTitoloAnnoEsecQuadri";
            btnTitoloAnnoEsecQuadri.Size = new Size(269, 26);
            btnTitoloAnnoEsecQuadri.TabIndex = 1;
            btnTitoloAnnoEsecQuadri.Text = "Titolo ed anno esecuzione di ogni quadro";
            btnTitoloAnnoEsecQuadri.UseVisualStyleBackColor = true;
            btnTitoloAnnoEsecQuadri.Click += BtnTitoloAnnoEsecQuadri_Click;
            // 
            // btnMuseiCitta
            // 
            btnMuseiCitta.Location = new Point(27, 227);
            btnMuseiCitta.Name = "btnMuseiCitta";
            btnMuseiCitta.Size = new Size(269, 26);
            btnMuseiCitta.TabIndex = 1;
            btnMuseiCitta.Text = "Conta quanti musei ha la città indicata";
            btnMuseiCitta.UseVisualStyleBackColor = true;
            btnMuseiCitta.Click += BtnMuseiCitta_Click;
            // 
            // lblNumMusei
            // 
            lblNumMusei.AutoSize = true;
            lblNumMusei.Location = new Point(27, 269);
            lblNumMusei.Name = "lblNumMusei";
            lblNumMusei.Size = new Size(0, 15);
            lblNumMusei.TabIndex = 3;
            // 
            // cbCitta
            // 
            cbCitta.FormattingEnabled = true;
            cbCitta.Location = new Point(325, 227);
            cbCitta.Name = "cbCitta";
            cbCitta.Size = new Size(223, 23);
            cbCitta.TabIndex = 4;
            cbCitta.Text = "Scegli una città...";
            // 
            // btnQuadriAreaSup
            // 
            btnQuadriAreaSup.Location = new Point(27, 175);
            btnQuadriAreaSup.Name = "btnQuadriAreaSup";
            btnQuadriAreaSup.Size = new Size(269, 26);
            btnQuadriAreaSup.TabIndex = 1;
            btnQuadriAreaSup.Text = "Quadri con area superiore a quella indicata";
            btnQuadriAreaSup.UseVisualStyleBackColor = true;
            btnQuadriAreaSup.Click += BtnQuadriAreaSup_Click;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(325, 175);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(223, 23);
            tbArea.TabIndex = 2;
            // 
            // WindowsFormUtilities
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 368);
            Controls.Add(cbCitta);
            Controls.Add(lblNumMusei);
            Controls.Add(tbArea);
            Controls.Add(tbAnnoViventi);
            Controls.Add(tbAnno);
            Controls.Add(btnTitoloAnnoEsecQuadri);
            Controls.Add(btnMuseiCitta);
            Controls.Add(btnQuadriAreaSup);
            Controls.Add(btnArtistiViventiAnno);
            Controls.Add(tbNome);
            Controls.Add(btnArtistiNatiDopoAnno);
            Controls.Add(btnArtistiContNome);
            Controls.Add(dgvUtilities);
            Name = "WindowsFormUtilities";
            Text = "Utilities";
            ((System.ComponentModel.ISupportInitialize)dgvUtilities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUtilities;
        private Button btnArtistiContNome;
        private TextBox tbNome;
        private Button btnArtistiNatiDopoAnno;
        private TextBox tbAnno;
        private Button btnArtistiViventiAnno;
        private TextBox tbAnnoViventi;
        private Button btnTitoloAnnoEsecQuadri;
        private Button btnMuseiCitta;
        private Label lblNumMusei;
        private ComboBox cbCitta;
        private Button btnQuadriAreaSup;
        private TextBox tbArea;
    }
}