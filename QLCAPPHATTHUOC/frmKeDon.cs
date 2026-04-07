using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLCAPPHATTHUOC
{
    public partial class frmKeDon : DevExpress.XtraEditors.XtraForm
    {
        public frmKeDon()
        {
            InitializeComponent();
        }
        private void LoadThuoc()
        {
            string sql = "SELECT * FROM THUOC";
            dataGridView1.DataSource = Database.Query(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadThuoc();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}