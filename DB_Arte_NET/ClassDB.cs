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
        private string stringaConn = "Server=localhost;Database=arte;Uid=root;Pwd=''";

        public DataTable GetTabellaArtisti()
        {
            MySqlConnection conn = new MySqlConnection(stringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = "SELECT * FROM artisti";
            adapter.SelectCommand = com;
            // Adattiamo il formato dei dati per la DataTable
            adapter.Fill(tabella);
            return tabella;
        }

        public DataTable GetQuadriArtista(string codiceArtista)
        {
            MySqlConnection conn = new MySqlConnection(stringaConn);
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
            MySqlConnection conn = new MySqlConnection(stringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dtTecniche = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT QQ_Tecnica FROM quadri";
            adapter.SelectCommand = com;
            adapter.Fill(dtTecniche);
            List<string> tecniche = new List<string>();
            string tecnica = "";
            foreach (DataRow r in dtTecniche.Rows)
            {
                tecnica = (string)r["QQ_Tecnica"];
                if (!tecniche.Contains(tecnica))
                {
                    tecniche.Add(tecnica);
                }
            }
            return tecniche;
        }

        public DataTable GetQuadriPerTecnica(string tecnica)
        {
            MySqlConnection conn = new MySqlConnection(stringaConn);
            MySqlCommand com = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabella = new DataTable();

            com.Connection = conn;
            com.CommandText = $"SELECT * FROM quadri WHERE QQ_Tecnica = '{tecnica}'";
            adapter.SelectCommand = com;
            adapter.Fill(tabella);
            return tabella;
        }
    }
}
