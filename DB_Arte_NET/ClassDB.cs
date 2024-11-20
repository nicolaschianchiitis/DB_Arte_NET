using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Arte_NET
{
    public class ClassDB
    {
        private string stringaConn;

        public string StringaConn { get => stringaConn; set => stringaConn = value; }

        public ClassDB()
        {
            StringaConn = "Server=localhost;Database=arte;Uid=root;Pwd=''";
        }

        public DataTable GetTabellaArtisti()
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT * FROM artisti";
            adapter.SelectCommand = com;
            // Adattiamo il formato dei dati per la DataTable
            adapter.Fill(tabella);
            return tabella;
        }

        public DataTable GetQuadriArtista(string codiceArtista)
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT * FROM quadri WHERE QQ_CodiceArtista = '{codiceArtista}'";
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            return tabella;
        }

        public List<string> GetTecniche()
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dtTecniche = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT DISTINCT QQ_Tecnica from quadri order by QQ_Tecnica";
            adapter.SelectCommand = com;
            adapter.Fill(dtTecniche);
            List<string> tecniche = new List<string>();
            /* ------ Aggiungere questo, se la query è senza DISTINCT
            string tecnica = "";
            foreach (DataRow r in dtTecniche.Rows)
            {
                tecnica = (string)r["QQ_Tecnica"];
                if (!tecniche.Contains(tecnica))
                {
                    tecniche.Add(tecnica);
                }
            }*/
            foreach (DataRow r in dtTecniche.Rows)
            {
                tecniche.Add((string)r["QQ_Tecnica"]);
            }
            return tecniche;
        }

        public List<string> GetCitta()
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dtCitta = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT DISTINCT MM_Citta FROM musei ORDER BY MM_Citta";
            adapter.SelectCommand = com;
            adapter.Fill(dtCitta);
            List<string> citta = new List<string>();
            foreach (DataRow r in dtCitta.Rows)
            {
                citta.Add((string)r["MM_Citta"]);
            }
            citta.Remove("NULL");
            return citta;
        }

        public DataTable GetQuadriPerTecnica(string tecnica)
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT * FROM quadri WHERE QQ_Tecnica = '{tecnica}'";
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            return tabella;
        }

        public DataTable GetArtistiNomeContenente(string str)
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT * FROM artisti WHERE artisti.AR_Nome LIKE '%{str}%'";
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            return tabella;
        }

        public DataTable GetArtistiNatiDopoAnno(int anno)
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT * FROM artisti WHERE AR_DataNascita >= {anno}";
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            return tabella;
        }

        public DataTable GetArtistiViventiAnno(int anno)
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT * FROM artisti WHERE {anno} BETWEEN AR_DataNascita AND AR_DataMorte";
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            return tabella;
        }

        public DataTable GetTitoloAnnoEsecuzioneQuadri()
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT QQ_TitoloQuadro, QQ_AnnoEsecuzione FROM quadri";
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            return tabella;
        }

        public long GetNumMuseiCitta(string citta)
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT COUNT(MM_Citta) FROM musei WHERE MM_Citta = '{citta}'";
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            if (tabella.Rows.Count > 0)
            {
                return (long)tabella.Rows[0][0];
            } else
            {
                return 0;
            }
        }

        public DataTable GetQuadriAreaSuperiore(int areaMinima)
        {
            MySqlConnection conn = new MySqlConnection(StringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT *, QQ_Altezza * QQ_Larghezza AS area FROM quadri WHERE QQ_Altezza * QQ_Larghezza > {areaMinima} ORDER BY area";
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            return tabella;
        }
    }
}
