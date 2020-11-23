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
    public partial class FrmUjTurazo : Form
    {

        SqlConnection conn;
        public FrmUjTurazo(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void BtnRogzit_Click(object sender, EventArgs e)
        {
            conn.Open();
            new SqlCommand(
                "INSERT INTO turazo VALUES " +
                $"('{tbVNev.Text}', '{tbKNev.Text}', '{tbVaros.Text}', '{tbTel.Text}');",
                conn).ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Sikeres Rögzítés!");

            this.Dispose();
        }
    }
}
