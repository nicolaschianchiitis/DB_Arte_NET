namespace DB_Arte_NET
{
    public partial class WindowsFormArtisti : Form
    {
        ClassDB db = new ClassDB();
        public ClassDB Db { get => db; set => db = value; }

        public WindowsFormArtisti()
        {
            InitializeComponent();
            dgvArtisti.DataSource = Db.GetTabellaArtisti();
        }

        private void DgvArtisti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                // Seleziono in base al codice artista (PK)
                try
                {
                    string id = (string)dgvArtisti.Rows[e.RowIndex].Cells[1].Value;
                    WindowsFormOpere opere = new WindowsFormOpere(id);
                    opere.Show();
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
            WindowsFormOpereTecnica tecniche = new WindowsFormOpereTecnica();
            tecniche.Show();
        }
    }
}
