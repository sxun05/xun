using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHANSU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_NHANSUDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NHANSUDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_NHANSUDataSet.NHANVIEN);

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            nHANVIENBindingSource.AddNew();
            txtmanv.Focus();
       
        }

        private void bbtnsua_Click(object sender, EventArgs e)
        {
            txtmanv.Enabled = true;
            txthoten.Focus();
       
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("bạn có muốn xóa hay không?", "thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                nHANVIENBindingSource.RemoveCurrent();
                tableAdapterManager.UpdateAll(this.qL_NHANSUDataSet);

            }
        }
        private void btnin_Click(object sender, EventArgs e)
        {
            RFORMNHANVIEN frm = new RFORMNHANVIEN();
            frm.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("bạn có muốn thoát form không?", "thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                this.Close();
        }
    }
}
