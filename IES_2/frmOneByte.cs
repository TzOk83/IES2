using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IES_2
{
    public partial class frmOneByte : Form
    {
        public frmOneByte()
        {
            InitializeComponent();
        }

        private void tbAdjTrack_ValueChanged(object sender, EventArgs e)
        {
            tbAdjVal.Text = tbAdjTrack.Value.ToString();
            tbAdjVal.Tag = tbAdjTrack.Value;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            byte input, output;
            input = (byte)((int)tbAdjVal.Tag);
            ((frmMain)this.Owner).ECU.Query(input, out output);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbAdjVal_TextChanged(object sender, EventArgs e)
        {
            if (tbAdjVal.Text != "")
                tbAdjVal.Tag = int.Parse(tbAdjVal.Text);
        }

        private void tbAdjVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
