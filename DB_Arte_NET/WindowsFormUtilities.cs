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
    public partial class WindowsFormUtilities : Form
    {
        ClassDB db;

        public ClassDB Db { get => db; set => db = value; }

        public WindowsFormUtilities()
        {
            Db = new ClassDB();
            InitializeComponent();
            cbCitta.Items.AddRange(Db.GetCitta().ToArray());
        }

        private void BtnArtistiContNome_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUtilities.DataSource = Db.GetArtistiNomeContenente(tbNome.Text);
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("!! Formato dati non valido.");
            }
        }

        private void BtnArtistiNatiDopoAnno_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUtilities.DataSource = Db.GetArtistiNatiDopoAnno(int.Parse(tbAnno.Text));
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("!! Formato dati non valido.");
            }
        }

        private void BtnArtistiViventiAnno_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUtilities.DataSource = Db.GetArtistiViventiAnno(int.Parse(tbAnnoViventi.Text));
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("!! Formato dati non valido.");
            }
        }

        private void BtnTitoloAnnoEsecQuadri_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUtilities.DataSource = Db.GetTitoloAnnoEsecuzioneQuadri();
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("!! Formato dati non valido.");
            }
        }

        private void BtnMuseiCitta_Click(object sender, EventArgs e)
        {
            try
            {
                long numMusei = Db.GetNumMuseiCitta(cbCitta.Text);
                lblNumMusei.Text = $"{cbCitta.Text} ha {numMusei} " + (numMusei == 1 ? "museo." : "musei.");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("!! Formato dati non valido.");
            }
        }

        private void BtnQuadriAreaSup_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUtilities.DataSource = Db.GetQuadriAreaSuperiore(int.Parse(tbArea.Text));
            } catch (FormatException)
            {
                Console.Error.WriteLine("!! Formato dati non valido.");
            }
        }
    }
}
