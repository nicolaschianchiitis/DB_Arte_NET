namespace DB_Arte_NET
{
    partial class WindowsFormArtisti
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
            lblArtisti = new Label();
            btnTecniche = new Button();
            btnUtilities = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArtisti).BeginInit();
            SuspendLayout();
            // 
            // dgvArtisti
            // 
            dgvArtisti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtisti.Columns.AddRange(new DataGridViewColumn[] { SelectArtista });
            dgvArtisti.Location = new Point(15, 48);
            dgvArtisti.Name = "dgvArtisti";
            dgvArtisti.Size = new Size(854, 574);
            dgvArtisti.TabIndex = 0;
            dgvArtisti.CellClick += DgvArtisti_CellClick;
            // 
            // SelectArtista
            // 
            SelectArtista.HeaderText = "Seleziona";
            SelectArtista.Name = "SelectArtista";
            // 
            // lblArtisti
            // 
            lblArtisti.AutoSize = true;
            lblArtisti.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtisti.Location = new Point(407, 9);
            lblArtisti.Name = "lblArtisti";
            lblArtisti.Size = new Size(66, 25);
            lblArtisti.TabIndex = 2;
            lblArtisti.Text = "Artisti";
            // 
            // btnTecniche
            // 
            btnTecniche.Location = new Point(244, 638);
            btnTecniche.Name = "btnTecniche";
            btnTecniche.Size = new Size(184, 44);
            btnTecniche.TabIndex = 3;
            btnTecniche.Text = "Mostra opere per tecnica";
            btnTecniche.UseVisualStyleBackColor = true;
            btnTecniche.Click += BtnTecniche_Click;
            // 
            // btnUtilities
            // 
            btnUtilities.Location = new Point(461, 638);
            btnUtilities.Name = "btnUtilities";
            btnUtilities.Size = new Size(175, 44);
            btnUtilities.TabIndex = 4;
            btnUtilities.Text = "Mostra finestra Utilities";
            btnUtilities.UseVisualStyleBackColor = true;
            btnUtilities.Click += BtnUtilities_Click;
            // 
            // WindowsFormArtisti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 694);
            Controls.Add(btnUtilities);
            Controls.Add(btnTecniche);
            Controls.Add(lblArtisti);
            Controls.Add(dgvArtisti);
            Name = "WindowsFormArtisti";
            Text = "Artisti";
            ((System.ComponentModel.ISupportInitialize)dgvArtisti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArtisti;
        private Label lblArtisti;
        private DataGridViewButtonColumn SelectArtista;
        private Button btnTecniche;
        private Button btnUtilities;
    }
}
