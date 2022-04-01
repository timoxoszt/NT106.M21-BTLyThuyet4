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

namespace Server
{
    public partial class Server : Form
    {
        private IPAddress serverIPAddress;
        private int serverPort;
        private TcpListener server;
        Socket socket;
        Encoding ascii = Encoding.ASCII;
        public Server()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            serverIPAddress = IPAddress.Parse(ipBox.Text);
            serverPort = int.Parse(portBox.Text);
            server = new TcpListener(serverIPAddress, serverPort);
            server.Start();
            socket = server.AcceptSocket();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            socket.Close();
            server.Stop();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            int size = 2048;
            byte[] data = new byte[size];
            socket.Receive(data);
            string str = ascii.GetString(data);
            messageTxtBox.Text = str.ToUpper();
        }
    }
}
