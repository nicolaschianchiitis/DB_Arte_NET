namespace DB_Arte_NET
{
    partial class FormArtisti
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvArtisti = new DataGridView();
            SelectArtista = new DataGridViewButtonColumn();
            btnCaricaArtisti = new Button();
            dgvQuadriArtista = new DataGridView();
            lblArtisti = new Label();
            lblQuadriArtista = new Label();
            btnTecniche = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArtisti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuadriArtista).BeginInit();
            SuspendLayout();
            // 
            // dgvArtisti
            // 
            dgvArtisti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtisti.Columns.AddRange(new DataGridViewColumn[] { SelectArtista });
            dgvArtisti.Location = new Point(15, 48);
            dgvArtisti.Name = "dgvArtisti";
            dgvArtisti.Size = new Size(669, 534);
            dgvArtisti.TabIndex = 0;
            dgvArtisti.CellClick += DgvArtisti_CellClick;
            // 
            // SelectArtista
            // 
            SelectArtista.HeaderText = "Seleziona";
            SelectArtista.Name = "SelectArtista";
            // 
            // btnCaricaArtisti
            // 
            btnCaricaArtisti.Location = new Point(190, 595);
            btnCaricaArtisti.Name = "btnCaricaArtisti";
            btnCaricaArtisti.Size = new Size(209, 44);
            btnCaricaArtisti.TabIndex = 1;
            btnCaricaArtisti.Text = "Carica artisti";
            btnCaricaArtisti.UseVisualStyleBackColor = true;
            btnCaricaArtisti.Click += BtnLoadArtisti_Click;
            // 
            // dgvQuadriArtista
            // 
            dgvQuadriArtista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuadriArtista.Location = new Point(703, 48);
            dgvQuadriArtista.Name = "dgvQuadriArtista";
            dgvQuadriArtista.Size = new Size(741, 534);
            dgvQuadriArtista.TabIndex = 0;
            // 
            // lblArtisti
            // 
            lblArtisti.AutoSize = true;
            lblArtisti.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtisti.Location = new Point(280, 20);
            lblArtisti.Name = "lblArtisti";
            lblArtisti.Size = new Size(66, 25);
            lblArtisti.TabIndex = 2;
            lblArtisti.Text = "Artisti";
            // 
            // lblQuadriArtista
            // 
            lblQuadriArtista.AutoSize = true;
            lblQuadriArtista.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuadriArtista.Location = new Point(1022, 20);
            lblQuadriArtista.Name = "lblQuadriArtista";
            lblQuadriArtista.Size = new Size(134, 25);
            lblQuadriArtista.TabIndex = 2;
            lblQuadriArtista.Text = "Quadri artista";
            // 
            // btnTecniche
            // 
            btnTecniche.Location = new Point(594, 595);
            btnTecniche.Name = "btnTecniche";
            btnTecniche.Size = new Size(184, 44);
            btnTecniche.TabIndex = 3;
            btnTecniche.Text = "Mostra quadri per tecnica";
            btnTecniche.UseVisualStyleBackColor = true;
            btnTecniche.Click += BtnTecniche_Click;
            // 
            // FormArtisti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 649);
            Controls.Add(btnTecniche);
            Controls.Add(lblQuadriArtista);
            Controls.Add(lblArtisti);
            Controls.Add(btnCaricaArtisti);
            Controls.Add(dgvQuadriArtista);
            Controls.Add(dgvArtisti);
            Name = "FormArtisti";
            Text = "Artisti";
            ((System.ComponentModel.ISupportInitialize)dgvArtisti).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuadriArtista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArtisti;
        private Button btnCaricaArtisti;
        private DataGridView dgvQuadriArtista;
        private Label lblArtisti;
        private Label lblQuadriArtista;
        private DataGridViewButtonColumn SelectArtista;
        private Button btnTecniche;
    }
}
