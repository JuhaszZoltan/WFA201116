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
    public partial class FrmMain : Form
    {
        SqlConnection conn;
        public FrmMain()
        {
            conn = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;" +
                @"AttachDbFileName=|DataDirectory|\Resources\tura.mdf;");
            InitializeComponent();
        }


        private void DgvFill()
        {
            dgvTurazok.Rows.Clear();
            conn.Open();
            var r = new SqlCommand("SELECT * FROM turazo;", conn)
                .ExecuteReader();
            while (r.Read())
            {
                //var t = new object[r.FieldCount];
                //r.GetSqlValues(t);
                //dgvTurazok.Rows.Add(t);
                dgvTurazok.Rows.Add(r[0], r[1], r[2], r[3], r[4]);
            }
            conn.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DgvFill();
        }

        private void DgvTurazok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var frm = new FrmUtvonal(conn, (int)dgvTurazok[0, e.RowIndex].Value);
            frm.ShowDialog();
        }

        private void BtnUjSzemely_Click(object sender, EventArgs e)
        {
            var frm = new FrmUjTurazo(conn);
            frm.ShowDialog();
            DgvFill();
        }
    }
}
