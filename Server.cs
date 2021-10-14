using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;  //套接字的命名空间
using System.Net; //IPAddress的命名空间
using System.Threading; //线程的命名空间

namespace 五子棋
{
    public partial class Server : Form
    {
        //声明套接字
        Socket serverSocket = null;
        //创建用来专门作为监听来电等待工作的线程
        Thread listenThread = null;

        Socket ClientSocket = null;
        Gameing sgame = null;
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            System.Net.Sockets.TcpClient c = new System.Net.Sockets.TcpClient();
            c.Connect("www.baidu.com", 80);
            inputIP.Text = ((System.Net.IPEndPoint)c.Client.LocalEndPoint).Address.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress address = IPAddress.Parse(inputIP.Text.Trim());
            IPEndPoint endPoint = new IPEndPoint(address, int.Parse(skNum.Text.Trim()));
            try
            {
                //2.套接字绑定端口号和IP
                serverSocket.Bind(endPoint);
                link_msg.Text += "开启服务成功\n";
            }
            catch (Exception ex)
            {
                link_msg.Text += ex.Message +"开启服务失败\n";//ex.Message为出现异常的消息
                return;
            }
            serverSocket.Listen(10); //参数为最大监听的用户数
            listenThread = new Thread(ListenConnectSocket);
            listenThread.IsBackground = true; //关闭后天线程
            listenThread.Start();

            sgame = new Gameing(this);
            sgame.Show();
        }
        bool isOpen = true;
        void ListenConnectSocket()
        {
            while (isOpen)
            {
                try
                {
                    ClientSocket = serverSocket.Accept();
                    byte[] buffer = Encoding.Default.GetBytes("成功连接到服务器！");
                    
                    ClientSocket.Send(buffer);
                    string client = ClientSocket.RemoteEndPoint.ToString();
                    MessageBox.Show(client);
                    link_msg.Text += "成功连接到服务器！\n";
                   Thread thr = new Thread(ReceiveCkientMsg);
                    thr.IsBackground = true;
                    thr.Start(ClientSocket);
                }
                catch (Exception ex)
                {
                    listenThread.Abort(ex.Message);
                }
            }
        }
        private void ReceiveCkientMsg(object clientSocket)
        {
            Socket client = clientSocket as Socket;
            while (true)
            {
                byte[] recBuffer = new byte[1024 * 1024 * 2];
                int length = -1;
                try
                {
                    length = client.Receive(recBuffer);
                }
                catch (Exception ex)
                {
                    string str = client.RemoteEndPoint.ToString();
                    MessageBox.Show(str);
                    break;
                }
                if (length == 0)
                {
                    string str = client.RemoteEndPoint.ToString();
                    link_msg.Text += "下线";
                    break;
                }
                else
                {
                    
                    string msg = Encoding.Default.GetString(recBuffer, 0, length);
                    string msgStr = $"Server{DateTime.Now}【接收{client.RemoteEndPoint.ToString()}】{msg}";
                    link_msg.Text += msgStr + Environment.NewLine + "\n";
                    sgame.msgdone(msg);
                }
            }
        }
        public void sendMsg(string str)
        {
            byte[] buffer = Encoding.Default.GetBytes(str);
            //MessageBox.Show(serverSocket.ToString());
            ClientSocket.Send(buffer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendMsg("我是服务器喵！\n连接成功了哟o(*￣▽￣*)ブ");
        }
    }
}
