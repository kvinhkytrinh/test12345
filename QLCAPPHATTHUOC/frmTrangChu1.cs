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
    public partial class frmTrangChu1 : DevExpress.XtraEditors.XtraForm
    {
        public frmTrangChu1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this. Hide ();
            frmKeDon f = new frmKeDon();    
            f.ShowDialog();
        }
    }
}