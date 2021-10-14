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
    public partial class Client : Form
    {
        Socket clientSocket = null;
        Thread clientThread = null;
        Gameing cgame = null;
        
        public Client()
        {
            InitializeComponent();
            //让子线程调用msg控件
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//地址类型，数据传输方式，协议
            //2.1 设置IP地址
            IPAddress address = IPAddress.Parse(inputIP.Text.Trim());
            //2.2 设置IP地址和端口号
            IPEndPoint endPoint = new IPEndPoint(address, int.Parse(skNum.Text.Trim()));
            try
            {              
                clientSocket.Connect(endPoint); // 与服务器连接
            }
            catch (Exception ex)
            {
                cli_msg.Text += ("连接失败：" + ex.Message+"友情提示")+"\n";
                return;
            }
            cli_msg.Text += ("与服务器连接成功！" + Environment.NewLine)+"\n";
            //4.接收或发送消息 使用线程来实现
            clientThread = new Thread(ReceiveMsg);
            clientThread.IsBackground = true; //开启后台线程
            clientThread.Start();
            cgame = new Gameing(this);
            cgame.Show();
        }

        private void ReceiveMsg()
        {
            while (true)
            {
                byte[] recBuffer = new byte[1024 * 1024 * 2];//声明最大字符内存
                int length = -1; //字节长度
                try
                {
                    length = clientSocket.Receive(recBuffer);//返回接收到的实际的字节数量
                }               
                catch (Exception ex)
                {
                    cli_msg.Text += $"与服务器断开连接：{ex.Message}{Environment.NewLine}\n";
                             
                    break;
                }
                //接收到消息
                if (length > 0)
                {
                    
                    string msg = Encoding.Default.GetString(recBuffer, 0, length);//转译字符串(字符串，开始的索引，字符串长度)
                    string str = $"Client{DateTime.Now}【接收】{msg}{Environment.NewLine}";//接收的时间，内容，换行
                    cli_msg.Text += str;
                    cgame.msgdone(msg);
                }
            }
        }
        public void sendMsg(string str)
        {
            byte[] buffer = Encoding.Default.GetBytes(str);
            clientSocket.Send(buffer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendMsg("客户端收到！！！！！");
        }
    }
}
