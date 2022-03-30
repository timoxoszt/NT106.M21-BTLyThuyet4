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

//còn đây là client
namespace OpenRemoteAppUDP
{
    public partial class UDP_Caller : Form
    {
        private IPAddress serverIP;
        private int serverPort;
        private IPEndPoint serverEP;
        private Socket socket;
        Encoding encode = Encoding.ASCII;
        public UDP_Caller()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //kết nới tới socket đã được start
            serverIP = IPAddress.Parse(ipBox.Text);
            serverPort = int.Parse(portBox.Text);
            serverEP = new IPEndPoint(serverIP, serverPort);
            socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //gửi dữ liệu
            string sndText = sendBox.Text;
            var sndBuffer = encode.GetBytes(sndText);
            socket.SendTo(sndBuffer, serverEP);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            socket.Close();
        }
    }
}
