using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaWindowsKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (Cmb1.Text == "Notepad")
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }

            if (Cmb1.Text == "Paint")
            {
                System.Diagnostics.Process.Start("mspaint.exe");
            }
        }

        private void Chb_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb.Checked == true)
            {
                groupBox1.Visible = true;
            }

            if (Chb.Checked == false)
            {
                groupBox1.Visible = false;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBoxName.Clear();
            TxtBoxDesc.Clear();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme", "Obavještenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog(Owner) == DialogResult.OK)
            {
                TxtBoxName.AppendText(form2.Name1);
                TxtBoxDesc.AppendText(form2.Desc);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li ste sigurni da želite zatvoriti aplikaciju?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
