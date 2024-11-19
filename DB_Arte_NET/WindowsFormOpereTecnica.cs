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
    public partial class WindowsFormOpereTecnica : Form
    {
        ClassDB db = new ClassDB();
        public ClassDB Db { get => db; set => db = value; }

        public WindowsFormOpereTecnica()
        {
            InitializeComponent();
            cbTecnica.Items.AddRange(Db.GetTecniche().ToArray());
        }

        private void CbTecnica_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tecnica = cbTecnica.GetItemText(cbTecnica.SelectedItem);
            if (tecnica != null && cbTecnica.Items.Contains(tecnica))
            {
                dgvQuadriPerTecnica.DataSource = Db.GetQuadriPerTecnica(tecnica);
            }
        }
    }
}
