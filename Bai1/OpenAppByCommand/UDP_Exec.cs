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
            try
            {
                //Nhận ip, port từ bàn phím và tạo cổng chờ sẵn kết nối
                serverIP = IPAddress.Parse(ipBox.Text);
                serverPort = int.Parse(portBox.Text);
                serverEP = new IPEndPoint(serverIP, serverPort);
                socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
                //tạo cổng chờ sẵn
                socket.Bind(serverEP);
            }
            catch (System.FormatException)
            {
                
                DialogResult res = MessageBox.Show("Nếu không nhập IP và Port thì thông số sẽ được chỉ định, đồng ý ?", "Thông báo", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    ipBox.Text = "127.0.0.1";
                    portBox.Text = "50";
                    //Nhận ip, port từ bàn phím và tạo cổng chờ sẵn kết nối
                    serverIP = IPAddress.Parse(ipBox.Text);
                    serverPort = int.Parse(portBox.Text);
                    serverEP = new IPEndPoint(serverIP, serverPort);
                    socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
                    //tạo cổng chờ sẵn
                    socket.Bind(serverEP);
                }
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            try 
            {
                socket.Close();
                serverIP = IPAddress.Parse(ipBox.Text);
                serverPort = int.Parse(portBox.Text);
                serverEP = new IPEndPoint(serverIP, serverPort);
                socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
            }
            catch (System.NullReferenceException)
            {

            }
            //Đóng kết nối và tạo sẵn kết nối mới.
        }


        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                int size = 2048;
                byte[] rcvBuffer = new byte[size];
                //phần nhận dữ liệu
                EndPoint remoteEP = (EndPoint)serverEP;
                var length = socket.ReceiveFrom(rcvBuffer, 0, ref remoteEP);
                var rcvText = Encoding.ASCII.GetString(rcvBuffer, 0, length);
                commandBox.Text = rcvText;
            }
            catch (System.NullReferenceException)
            {

            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Vui lòng nhấn nút Start trước");
            }
        }

        private void commandBox_TextChanged(object sender, EventArgs e)
        {
            if (commandBox.Text.StartsWith("OPEN#") == true)//mở ứng dụng
            {
                try
                {
                    externalProcess = new Process();
                    externalProcess.StartInfo.FileName = readCommand(commandBox.Text);
                    externalProcess.Start();
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    MessageBox.Show("File không tồn tại hoặc yêu cầu đường dẫn tuyệt đối");
                }
            }
            else if (commandBox.Text == "CLOSEAPP")//đóng ứng dụng
            {
                try
                {
                    externalProcess.Kill();
                }
                catch (System.InvalidOperationException)
                {

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng cú pháp");
            }
        }
    }
}
