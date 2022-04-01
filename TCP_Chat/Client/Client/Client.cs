using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace Client
{
    public partial class Client : Form
    {
        private TcpClient client;
        private IPAddress serverIPAddress;
        private int serverPort;
        Stream clientStream;
        Encoding ascii = Encoding.ASCII;
        public Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serverIPAddress = IPAddress.Parse(ipBox.Text);
            serverPort = int.Parse(portBox.Text);
            client.Connect(serverIPAddress, serverPort);
            clientStream = client.GetStream();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            clientStream.Close();
            client.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string sndData = messageTxtBox.Text;
            byte[] buffer = ascii.GetBytes(sndData);
            clientStream.Write(buffer, 0, buffer.Length);
        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new TcpClient();
        }
    }
}
