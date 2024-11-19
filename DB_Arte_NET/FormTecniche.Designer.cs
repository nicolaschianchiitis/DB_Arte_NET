namespace DB_Arte_NET
{
    partial class FormTecniche
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
            cbTecnica = new ComboBox();
            lblTecniche = new Label();
            dgvQuadriPerTecnica = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvQuadriPerTecnica).BeginInit();
            SuspendLayout();
            // 
            // cbTecnica
            // 
            cbTecnica.FormattingEnabled = true;
            cbTecnica.Location = new Point(236, 25);
            cbTecnica.Name = "cbTecnica";
            cbTecnica.Size = new Size(199, 23);
            cbTecnica.TabIndex = 0;
            cbTecnica.SelectedIndexChanged += CbTecnica_SelectedIndexChanged;
            // 
            // lblTecniche
            // 
            lblTecniche.AutoSize = true;
            lblTecniche.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTecniche.Location = new Point(23, 20);
            lblTecniche.Name = "lblTecniche";
            lblTecniche.Size = new Size(175, 25);
            lblTecniche.TabIndex = 1;
            lblTecniche.Text = "Quadri per tecnica";
            // 
            // dgvQuadriPerTecnica
            // 
            dgvQuadriPerTecnica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuadriPerTecnica.Location = new Point(12, 64);
            dgvQuadriPerTecnica.Name = "dgvQuadriPerTecnica";
            dgvQuadriPerTecnica.Size = new Size(1146, 525);
            dgvQuadriPerTecnica.TabIndex = 2;
            // 
            // FormTecniche
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 601);
            Controls.Add(dgvQuadriPerTecnica);
            Controls.Add(lblTecniche);
            Controls.Add(cbTecnica);
            Name = "FormTecniche";
            Text = "Quadri per tecnica";
            ((System.ComponentModel.ISupportInitialize)dgvQuadriPerTecnica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTecnica;
        private Label lblTecniche;
        private DataGridView dgvQuadriPerTecnica;
    }
}