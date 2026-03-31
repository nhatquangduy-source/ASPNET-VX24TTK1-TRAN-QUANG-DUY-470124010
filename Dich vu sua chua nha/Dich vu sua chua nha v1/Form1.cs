using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dich_vu_sua_chua_nha_v1
{
    public partial class FrmChondichvu : Form
    {
        public FrmChondichvu()
        {
            InitializeComponent();
        }
        private void Caidathienthi()
        {
            if (lstDichvu.Items.Count == 0)
            {
                btnChon1.Enabled = false;
                btnChonhet.Enabled = false;
            }
            else
            {
                btnChon1.Enabled = true;
                btnChonhet.Enabled = true;
            }
            if (lstChondichvu.Items.Count == 0)
            {
                btnHuy1.Enabled = false;
                btnHuyhet.Enabled = false;
            }
            else
            {
                btnHuy1.Enabled = true;
                btnHuyhet.Enabled = true;
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon1_Click(object sender, EventArgs e)
        {
            if(lstDichvu.SelectedIndex != -1)
            {
                lstChondichvu.Items.Add(lstDichvu.SelectedItem);
                lstDichvu.Items.RemoveAt(lstDichvu.SelectedIndex);
            }
            this.Caidathienthi();
        }

        private void lstDichvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
