using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Arte_NET
{
    public partial class WindowsFormOpere : Form
    {
        string idArtista;
        ClassDB db;

        public string IdArtista { get => idArtista; set => idArtista = value; }
        public ClassDB Db { get => db; set => db = value; }

        public WindowsFormOpere(string idArtista)
        {
            IdArtista = idArtista;
            Db = new ClassDB();
            InitializeComponent();
            dgvQuadriArtista.DataSource = Db.GetQuadriArtista(IdArtista);
        }
    }
}
