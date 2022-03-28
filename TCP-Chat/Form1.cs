using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Client frmClient = new Client();
            frmClient.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Server frmServer = new Server();
            frmServer.Show();
        }
    }
}
