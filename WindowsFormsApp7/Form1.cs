using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            bSend.Tag = 1;
            bSend2.Tag = 2;


            private void SendClicked(object sender, EventArgs e)
            {

                Button b = (Button)sender;


                string s = b.Tag + ":" + tbMessage.Text;
                tbChat.Text += s + Environment.NewLine;

                tbMessage.Text = "";
                 
            }


        }

    }
}
