namespace DB_Arte_NET
{
    public partial class FormArtisti : Form
    {
        ClassDB db = new ClassDB();
        public ClassDB Db { get => db; set => db = value; }

        public FormArtisti()
        {
            InitializeComponent();
        }

        private void BtnLoadArtisti_Click(object sender, EventArgs e)
        {
            dgvArtisti.DataSource = Db.GetTabellaArtisti();
        }

        private void DgvArtisti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                // Seleziono in base al codice artista (PK)
                try
                {
                    dgvQuadriArtista.DataSource = Db.GetQuadriArtista((string)dgvArtisti.Rows[e.RowIndex].Cells[1].Value);
                }
                catch (ArgumentOutOfRangeException ae)
                {
                    Console.Error.WriteLine($"!! Riga inesistente.\n{ae.StackTrace}");
                }
                catch (InvalidCastException ce)
                {
                    Console.Error.WriteLine($"!! Casting non riuscito.\n{ce.StackTrace}");
                }
            }
        }

        private void BtnTecniche_Click(object sender, EventArgs e)
        {
            FormTecniche tecniche = new FormTecniche();
            tecniche.Show();
        }
    }
}
