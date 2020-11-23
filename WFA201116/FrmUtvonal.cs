using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA201116
{

    public partial class FrmUtvonal : Form
    {
        SqlConnection conn;
        int turazoId;
        public FrmUtvonal(SqlConnection conn, int turazoId)
        {
            this.conn = conn;
            this.turazoId = turazoId;
            InitializeComponent();
        }

        private void FrmUtvonal_Load(object sender, EventArgs e)
        {
            dgvUtvonalak.Rows.Clear();
            conn.Open();

            var r = new SqlCommand(
                "SELECT honnan, hova, km FROM utvonal " +
                $"WHERE turazoId = {turazoId}", conn)
                .ExecuteReader();

            while (r.Read())
            {
                dgvUtvonalak.Rows.Add(r[0], r[1], r[2]);
            }
            conn.Close();

            var sum = 0;
            foreach (DataGridViewRow s in dgvUtvonalak.Rows)
                sum += (int)s.Cells[2].Value;

            tbOsszKm.Text = $"{sum}";
            tbOsszPont.Text = $"{sum / 20}";

        }
    }
}
