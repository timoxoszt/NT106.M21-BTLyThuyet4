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

//Đây là server
namespace OpenAppByCommand
{
    public partial class UDP_Exec : Form
    {
        private IPAddress serverIP;
        private int serverPort;
        private IPEndPoint serverEP;
        private Socket socket;
        Process externalProcess;
        public UDP_Exec()
        {
            InitializeComponent();
        }
        //Hàm tách chuỗi OPEN# chừa lại tên app
        public string readCommand(string s)
        {
            string[] res = { };
            for (int i = 0; i < s.Length; i++)
            {
                res = s.Split('#');
            }
            return res[1];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Nhận ip, port từ bàn phím và tạo cổng chờ sẵn kết nối
            serverIP = IPAddress.Parse(ipBox.Text);
            serverPort = int.Parse(portBox.Text);
            serverEP = new IPEndPoint(serverIP, serverPort);
            socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
            //tạo cổng chờ sẵn
            socket.Bind(serverEP);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            socket.Close();
            //Đóng kết nối và tạo sẵn kết nối mới.
            serverIP = IPAddress.Parse(ipBox.Text);
            serverPort = int.Parse(portBox.Text);
            serverEP = new IPEndPoint(serverIP, serverPort);
            socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
        }


        private void btnListen_Click(object sender, EventArgs e)
        {
            //phần tạo bộ đệm
            int size = 2048;
            byte[] rcvBuffer = new byte[size];
            //phần nhận dữ liệu
            EndPoint remoteEP = (EndPoint)serverEP;
            var length = socket.ReceiveFrom(rcvBuffer, 0, ref remoteEP);
            var rcvText = Encoding.ASCII.GetString(rcvBuffer, 0, length);
            commandBox.Text = rcvText;
        }

        private void commandBox_TextChanged(object sender, EventArgs e)
        {
            if (commandBox.Text.StartsWith("OPEN#") == true)//mở ứng dụng
            {
                externalProcess = new Process();
                externalProcess.StartInfo.FileName = readCommand(commandBox.Text);
                externalProcess.Start();
            }
            else if (commandBox.Text == "CLOSEAPP")//đóng ứng dụng
            {
                externalProcess.Kill();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng cú pháp");
            }
        }
    }
}
