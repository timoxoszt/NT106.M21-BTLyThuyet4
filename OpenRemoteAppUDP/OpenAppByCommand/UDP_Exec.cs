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
using System.Diagnostics;

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
        public string readCommand(string s)
        {
            if (s.StartsWith("OPEN#") == true)
            {
                string[] res = { };
                for (int i = 0;i<s.Length;i++)
                {
                    res = s.Split('#');
                }
                return res[1];
            }
            return "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            serverIP = IPAddress.Parse(ipBox.Text);
            serverPort = int.Parse(portBox.Text);
            serverEP = new IPEndPoint(serverIP, serverPort);
            socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
        }

        private void btnBind_Click(object sender, EventArgs e)
        {
            socket.Bind(serverEP);
            int size = 1024;
            byte[] rcvBuffer = new byte[size];
            EndPoint remoteEP = (EndPoint)serverEP;
            var length = socket.ReceiveFrom(rcvBuffer,0, ref remoteEP);
            var rcvText = Encoding.ASCII.GetString(rcvBuffer, 0, length);
            nameBox.Text = rcvText;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = readCommand(nameBox.Text);
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();
        }
    }
}
