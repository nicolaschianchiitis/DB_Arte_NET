namespace DB_Arte_NET
{
    partial class WindowsFormOpere
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
            dgvQuadriArtista = new DataGridView();
            lblQuadriArtista = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQuadriArtista).BeginInit();
            SuspendLayout();
            // 
            // dgvQuadriArtista
            // 
            dgvQuadriArtista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuadriArtista.Location = new Point(12, 48);
            dgvQuadriArtista.Name = "dgvQuadriArtista";
            dgvQuadriArtista.Size = new Size(861, 567);
            dgvQuadriArtista.TabIndex = 3;
            // 
            // lblQuadriArtista
            // 
            lblQuadriArtista.AutoSize = true;
            lblQuadriArtista.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuadriArtista.Location = new Point(373, 9);
            lblQuadriArtista.Name = "lblQuadriArtista";
            lblQuadriArtista.Size = new Size(127, 25);
            lblQuadriArtista.TabIndex = 4;
            lblQuadriArtista.Text = "Opere artista";
            // 
            // WindowsFormOpere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 627);
            Controls.Add(lblQuadriArtista);
            Controls.Add(dgvQuadriArtista);
            Name = "WindowsFormOpere";
            Text = "Opere artista";
            ((System.ComponentModel.ISupportInitialize)dgvQuadriArtista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQuadriArtista;
        private Label lblQuadriArtista;
    }
}