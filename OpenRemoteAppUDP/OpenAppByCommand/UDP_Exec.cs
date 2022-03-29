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

//làm ơn nhớ đây là server
namespace OpenAppByCommand
{
    public partial class UDP_Exec : Form
    {
        private IPAddress serverIP;
        private int serverPort;
        private IPEndPoint serverEP;
        private Socket socket;
        string cmd;
        public UDP_Exec()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            serverIP = IPAddress.Parse(ipBox.Text);
            serverPort = int.Parse(portBox.Text);
            serverEP = new IPEndPoint(serverIP, serverPort);
            socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(serverEP);
            int size = 1024;
            byte[] rcvBuffer = new byte[size];
            EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            var length = socket.ReceiveFrom(rcvBuffer, ref remoteEndPoint);
            var rcvText = Encoding.ASCII.GetString(rcvBuffer, 0, length);
            nameBox.Text = rcvText.Substring(5, rcvText.Length);
        }
    }
}
